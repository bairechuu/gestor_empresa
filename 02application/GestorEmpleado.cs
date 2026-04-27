using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_empresa
{
    class GestorEmpleado
    {
        // Lógica SQL que obtiene las nóminas totales de un empleado
        public DataTable ObtenerNominasPorEmpleado(int idEmpleado)
        {
            string sql = "SELECT n.id_nomina AS ID, n.mes AS Mes, n.anyo AS Año, n.salario_bruto AS Bruto, n.salario_neto AS Neto " +
                         "FROM nomina n " +
                         "INNER JOIN contrato c ON n.id_contrato = c.id_contrato " +
                         "WHERE c.id_empleado = @idEmpleado";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idEmpleado", idEmpleado)
            };

            DataTable tabla = Database.Consulta(sql, parametros);
            return tabla;
        }

        // Lógica SQL que obtiene las bajas totales de un empleado
        public DataTable ObtenerBajasPorEmpleado(int idEmpleado)
        {
            string sql = "SELECT b.id_baja AS ID, b.fecha_inicio AS Inicio, b.fecha_fin AS Final, b.motivo AS Motivo, b.prestacion AS Prestación " +
                         "FROM baja b " +
                         "INNER JOIN contrato c ON b.id_contrato = c.id_contrato " +
                         "WHERE c.id_empleado = @idEmpleado";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idEmpleado", idEmpleado)
            };

            DataTable tabla = Database.Consulta(sql, parametros);
            return tabla;
        }

        // Lógica para posteriormente verificar si existe una jornada activa del empleado
        public DataTable ObtenerRegistroAbierto(int empleadoId)
        {
            string fechaHoy = DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "SELECT j.* FROM jornada j " +
                      "INNER JOIN contrato c ON j.id_contrato = c.id_contrato " +
                      "WHERE c.id_empleado = @idEmpleado " +
                      "AND j.hora_salida IS NULL " +
                      "AND j.fecha = @fechaHoy";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idEmpleado", empleadoId),
                new MySqlParameter("@fechaHoy", fechaHoy)
            };

            return Database.Consulta(sql, parametros);
        }

        // Lógica SQL para cuando pulse el botón el usuario y no haya una jornada activa (fichar)
        public int InsertarEntrada(int empleadoId)
        {
            string fechaHoy = DateTime.Today.ToString("yyyy-MM-dd");
            string horaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO jornada (id_contrato, fecha, hora_entrada) " +
                     "SELECT id_contrato, @fechaHoy, @horaActual " +
                     "FROM contrato WHERE id_empleado = @idEmpleado " +
                     "AND estado = 'activo' LIMIT 1";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@fechaHoy", fechaHoy),
                new MySqlParameter("@horaActual", horaActual),
                new MySqlParameter("@idEmpleado", empleadoId)
            };

            return Database.Modificacion(sql, parametros);
        }

        // Lógica SQL para cuando pulse el botón el usuario y haya una jornada activa (terminar la jornada)
        public int ActualizarSalida(int jornadaId)
        {
            string horaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "UPDATE jornada SET hora_salida = @horaActual WHERE id_jornada = @idJornada";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@horaActual", horaActual),
                new MySqlParameter("@idJornada", jornadaId)
            };

            return Database.Modificacion(sql, parametros);
        }
    }
}