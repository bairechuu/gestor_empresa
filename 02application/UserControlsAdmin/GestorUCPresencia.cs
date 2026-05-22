using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace gestor_empresa
{
    internal class GestorUCPresencia
    {
        // 1. Monitor en Tiempo Real: Jornadas abiertas (sin hora_salida) en el día actual
        public DataTable ObtenerJornadasAbiertas()
        {
            string fechaHoy = DateTime.Today.ToString("yyyy-MM-dd");

            string sql = @"
                SELECT 
                    j.id_jornada AS ID,
                    c.id_contrato AS 'ID Contrato',
                    e.nif AS NIF,
                    CONCAT(e.nombre, ' ', e.apellidos) AS Empleado,
                    j.hora_entrada AS 'Hora Entrada'
                FROM jornada j
                INNER JOIN contrato c ON j.id_contrato = c.id_contrato
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                WHERE j.hora_salida IS NULL 
                  AND j.fecha = @fechaHoy
                ORDER BY j.hora_entrada DESC";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@fechaHoy", fechaHoy)
            };

            return Database.Consulta(sql, parametros);
        }

        // 2. Auditoría de Fichajes: Obtener el histórico completo
        public DataTable ObtenerTodasLasJornadas()
        {
            string sql = @"
                SELECT 
                    j.id_jornada AS ID,
                    c.id_contrato AS 'ID Contrato',
                    CONCAT(e.nombre, ' ', e.apellidos) AS Empleado,
                    j.fecha AS Fecha,
                    j.hora_entrada AS 'Entrada',
                    j.hora_salida AS 'Salida',
                    j.horas_extra AS 'Horas Extra'
                FROM jornada j
                INNER JOIN contrato c ON j.id_contrato = c.id_contrato
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                ORDER BY j.fecha DESC, j.hora_entrada DESC";

            return Database.Consulta(sql);
        }

        // 3. Auditoría: Insertar una jornada manual
        public int InsertarJornada(int idContrato, DateTime fecha, DateTime horaEntrada, DateTime? horaSalida, decimal horasExtra)
        {
            string sql = @"
                INSERT INTO jornada (id_contrato, fecha, hora_entrada, hora_salida, horas_extra)
                VALUES (@idContrato, @fecha, @horaEntrada, @horaSalida, @horasExtra)";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idContrato", idContrato),
                new MySqlParameter("@fecha", fecha.ToString("yyyy-MM-dd")),
                new MySqlParameter("@horaEntrada", horaEntrada.ToString("yyyy-MM-dd HH:mm:ss")),
                new MySqlParameter("@horaSalida", horaSalida.HasValue ? (object)horaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") : DBNull.Value),
                new MySqlParameter("@horasExtra", horasExtra)
            };

            return Database.Modificacion(sql, parametros);
        }

        // 4. Auditoría: Modificar una jornada existente
        public int ActualizarJornada(int idJornada, int idContrato, DateTime fecha, DateTime horaEntrada, DateTime? horaSalida, decimal horasExtra)
        {
            string sql = @"
                UPDATE jornada 
                SET id_contrato = @idContrato,
                    fecha = @fecha, 
                    hora_entrada = @horaEntrada, 
                    hora_salida = @horaSalida, 
                    horas_extra = @horasExtra
                WHERE id_jornada = @idJornada";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idJornada", idJornada),
                new MySqlParameter("@idContrato", idContrato),
                new MySqlParameter("@fecha", fecha.ToString("yyyy-MM-dd")),
                new MySqlParameter("@horaEntrada", horaEntrada.ToString("yyyy-MM-dd HH:mm:ss")),
                new MySqlParameter("@horaSalida", horaSalida.HasValue ? (object)horaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") : DBNull.Value),
                new MySqlParameter("@horasExtra", horasExtra)
            };

            return Database.Modificacion(sql, parametros);
        }

        // 5. Auditoría: Eliminar una jornada
        public int EliminarJornada(int idJornada)
        {
            string sql = "DELETE FROM jornada WHERE id_jornada = @idJornada";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idJornada", idJornada)
            };

            return Database.Modificacion(sql, parametros);
        }

        // 6. Gestión Horas Extra: Resumen por empleado
        public DataTable ObtenerResumenHorasExtra(DateTime fechaInicio, DateTime fechaFin)
        {
            string sql = @"
                SELECT 
                    c.id_contrato AS 'ID Contrato',
                    e.nif AS NIF,
                    CONCAT(e.nombre, ' ', e.apellidos) AS Empleado,
                    emp.nombre AS Empresa,
                    c.tipo_contrato AS 'Tipo Contrato',
                    c.salario_bruto_anual AS 'Salario Anual',
                    COUNT(j.id_jornada) AS 'Días Fichados',
                    SUM(j.horas_extra) AS 'Total Horas Extra',
                    ROUND(AVG(j.horas_extra), 2) AS 'Media Horas Extra'
                FROM jornada j
                INNER JOIN contrato c ON j.id_contrato = c.id_contrato
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                INNER JOIN empresa emp ON c.id_empresa = emp.id_empresa
                WHERE j.fecha >= @fechaInicio AND j.fecha <= @fechaFin
                GROUP BY c.id_contrato, e.nif, e.nombre, e.apellidos, emp.nombre, c.tipo_contrato, c.salario_bruto_anual
                ORDER BY SUM(j.horas_extra) DESC";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd")),
                new MySqlParameter("@fechaFin", fechaFin.ToString("yyyy-MM-dd"))
            };

            return Database.Consulta(sql, parametros);
        }
    }
}
