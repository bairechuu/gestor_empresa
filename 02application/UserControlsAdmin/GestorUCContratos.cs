using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace gestor_empresa
{
    class GestorUCContratos
    {
        public DataTable ObtenerContratos()
        {
            string sql = "SELECT id_contrato, id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, num_pagas, irpf_fijo, tipo_contrato, estado FROM contrato";
            return Database.Consulta(sql);
        }

        public DataTable ObtenerEmpresas()
        {
            string sql = "SELECT id_empresa, cif, nombre FROM empresa";
            return Database.Consulta(sql);
        }

        public DataTable ObtenerEmpleados()
        {
            string sql = "SELECT id_empleado, nombre, apellidos, nif FROM empleado";
            return Database.Consulta(sql);
        }

        public DataTable BuscarEmpleados(string filtro)
        {
            string sql = "SELECT id_empleado, nombre, apellidos, nif FROM empleado WHERE id_empleado LIKE @filtro OR nombre LIKE @filtro OR apellidos LIKE @filtro OR nif LIKE @filtro";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public DataTable ObtenerContratosInfo()
        {
            string sql = @"
                SELECT c.id_contrato, e.nombre, e.apellidos, c.fecha_inicio, c.estado 
                FROM contrato c
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado";
            return Database.Consulta(sql);
        }

        public DataTable BuscarContratosInfo(string filtro)
        {
            string sql = @"
                SELECT c.id_contrato, e.nombre, e.apellidos, c.fecha_inicio, c.estado 
                FROM contrato c
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                WHERE c.id_contrato LIKE @filtro OR e.nombre LIKE @filtro OR e.apellidos LIKE @filtro OR c.estado LIKE @filtro";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public DataTable ObtenerContratoActivoPorEmpleado(int idEmpleado)
        {
            string sql = "SELECT * FROM contrato WHERE id_empleado = @id_empleado ORDER BY fecha_inicio DESC LIMIT 1";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_empleado", idEmpleado)
            };
            return Database.Consulta(sql, parametros);
        }

        public DataTable ObtenerContratosActivos()
        {
            string sql = @"
                SELECT c.id_contrato, e.nombre AS 'Nombre Empleado', e.apellidos AS 'Apellidos', em.nombre AS 'Empresa', c.fecha_inicio AS 'Fecha Inicio'
                FROM contrato c
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                INNER JOIN empresa em ON c.id_empresa = em.id_empresa
                WHERE c.estado = 'activo'";
            return Database.Consulta(sql);
        }

        public DataTable BuscarContratosActivos(string filtro)
        {
            string sql = @"
                SELECT c.id_contrato, e.nombre AS 'Nombre Empleado', e.apellidos AS 'Apellidos', em.nombre AS 'Empresa', c.fecha_inicio AS 'Fecha Inicio'
                FROM contrato c
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                INNER JOIN empresa em ON c.id_empresa = em.id_empresa
                WHERE c.estado = 'activo' AND (c.id_contrato LIKE @filtro OR e.nombre LIKE @filtro OR e.apellidos LIKE @filtro OR em.nombre LIKE @filtro)";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public DataTable ObtenerContratoPorId(int idContrato)
        {
            string sql = "SELECT * FROM contrato WHERE id_contrato = @id_contrato";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_contrato", idContrato)
            };
            return Database.Consulta(sql, parametros);
        }


        public DataTable BuscarEmpresas(string filtro)
        {
            string sql = "SELECT id_empresa, cif, nombre FROM empresa WHERE id_empresa LIKE @filtro OR cif LIKE @filtro OR nombre LIKE @filtro";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public DataTable BuscarContratos(string filtro)
        {
            string sql = "SELECT id_contrato, id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, num_pagas, irpf_fijo, tipo_contrato, estado FROM contrato WHERE id_contrato LIKE @filtro OR id_empleado LIKE @filtro OR id_empresa LIKE @filtro OR tipo_contrato LIKE @filtro";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public int CrearContrato(int idEmpleado, int idEmpresa, DateTime fechaInicio, DateTime? fechaFin, double salarioBrutoAnual, int numPagas, double irpfFijo, string tipoContrato, string estado)
        {
            string sql = "INSERT INTO contrato (id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, num_pagas, irpf_fijo, tipo_contrato, estado) VALUES (@id_empleado, @id_empresa, @fecha_inicio, @fecha_fin, @salario_bruto_anual, @num_pagas, @irpf_fijo, @tipo_contrato, @estado)";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_empleado", idEmpleado),
                new MySqlParameter("@id_empresa", idEmpresa),
                new MySqlParameter("@fecha_inicio", fechaInicio),
                new MySqlParameter("@fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value), 
                new MySqlParameter("@salario_bruto_anual", salarioBrutoAnual),
                new MySqlParameter("@num_pagas", numPagas),
                new MySqlParameter("@irpf_fijo", irpfFijo),
                new MySqlParameter("@tipo_contrato", tipoContrato),
                new MySqlParameter("@estado", estado)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ModificarContrato(int idContrato, int idEmpleado, int idEmpresa, DateTime fechaInicio, DateTime? fechaFin, double salarioBrutoAnual, int numPagas, double irpfFijo, string tipoContrato, string estado)
        {
            string sql = "UPDATE contrato SET id_empleado = @id_empleado, id_empresa = @id_empresa, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, salario_bruto_anual = @salario_bruto_anual, num_pagas = @num_pagas, irpf_fijo = @irpf_fijo, tipo_contrato = @tipo_contrato, estado = @estado WHERE id_contrato = @id_contrato";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_empleado", idEmpleado),
                new MySqlParameter("@id_empresa", idEmpresa),
                new MySqlParameter("@fecha_inicio", fechaInicio),
                new MySqlParameter("@fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value),
                new MySqlParameter("@salario_bruto_anual", salarioBrutoAnual),
                new MySqlParameter("@num_pagas", numPagas),
                new MySqlParameter("@irpf_fijo", irpfFijo),
                new MySqlParameter("@tipo_contrato", tipoContrato),
                new MySqlParameter("@estado", estado),
                new MySqlParameter("@id_contrato", idContrato)
            };
            return Database.Modificacion(sql, parametros);
        }

        public string ObtenerError()
        {
            return Database.Error;
        }

        public DataTable ObtenerBajas()
        {
            string sql = "SELECT id_baja, id_contrato, fecha_inicio, fecha_fin, motivo, prestacion FROM baja";
            return Database.Consulta(sql);
        }

        public int CrearBaja(int idContrato, DateTime fechaInicio, DateTime? fechaFin, string motivo, double? prestacion)
        {
            string sql = "INSERT INTO baja (id_contrato, fecha_inicio, fecha_fin, motivo, prestacion) VALUES (@id_contrato, @fecha_inicio, @fecha_fin, @motivo, @prestacion)";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_contrato", idContrato),
                new MySqlParameter("@fecha_inicio", fechaInicio),
                new MySqlParameter("@fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value),
                new MySqlParameter("@motivo", motivo),
                new MySqlParameter("@prestacion", prestacion.HasValue ? (object)prestacion.Value : DBNull.Value)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ModificarBaja(int idBaja, int idContrato, DateTime fechaInicio, DateTime? fechaFin, string motivo, double? prestacion)
        {
            string sql = "UPDATE baja SET id_contrato = @id_contrato, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, motivo = @motivo, prestacion = @prestacion WHERE id_baja = @id_baja";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_contrato", idContrato),
                new MySqlParameter("@fecha_inicio", fechaInicio),
                new MySqlParameter("@fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value),
                new MySqlParameter("@motivo", motivo),
                new MySqlParameter("@prestacion", prestacion.HasValue ? (object)prestacion.Value : DBNull.Value),
                new MySqlParameter("@id_baja", idBaja)
            };
            return Database.Modificacion(sql, parametros);
        }

        public DataTable ObtenerFiniquitos()
        {
            string sql = "SELECT id_finiquito, id_contrato, fecha_despido, vacaciones_no_disfrutadas, indemnizacion, total_neto FROM finiquito";
            return Database.Consulta(sql);
        }

        public int CrearFiniquito(int idContrato, DateTime fechaDespido, double vacaciones, double indemnizacion, double totalNeto)
        {
            string sql = "INSERT INTO finiquito (id_contrato, fecha_despido, vacaciones_no_disfrutadas, indemnizacion, total_neto) VALUES (@id_contrato, @fecha_despido, @vacaciones_no_disfrutadas, @indemnizacion, @total_neto)";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_contrato", idContrato),
                new MySqlParameter("@fecha_despido", fechaDespido),
                new MySqlParameter("@vacaciones_no_disfrutadas", vacaciones),
                new MySqlParameter("@indemnizacion", indemnizacion),
                new MySqlParameter("@total_neto", totalNeto)
            };
            return Database.Modificacion(sql, parametros);
        }
    }
}