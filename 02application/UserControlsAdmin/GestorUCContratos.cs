using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace gestor_empresa
{
    class GestorUCContratos
    {
        public DataTable ObtenerContratos()
        {
            string sql = "SELECT id_contrato, id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, tipo_contrato, estado FROM contrato";
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
            string sql = "SELECT id_contrato, id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, tipo_contrato, estado FROM contrato WHERE id_contrato LIKE @filtro OR id_empleado LIKE @filtro OR id_empresa LIKE @filtro OR tipo_contrato LIKE @filtro";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public int CrearContrato(int idEmpleado, int idEmpresa, DateTime fechaInicio, DateTime? fechaFin, double salarioBrutoAnual, string tipoContrato, string estado)
        {
            string sql = "INSERT INTO contrato (id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, tipo_contrato, estado) VALUES (@id_empleado, @id_empresa, @fecha_inicio, @fecha_fin, @salario_bruto_anual, @tipo_contrato, @estado)";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_empleado", idEmpleado),
                new MySqlParameter("@id_empresa", idEmpresa),
                new MySqlParameter("@fecha_inicio", fechaInicio),
                new MySqlParameter("@fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value),
                new MySqlParameter("@salario_bruto_anual", salarioBrutoAnual),
                new MySqlParameter("@tipo_contrato", tipoContrato),
                new MySqlParameter("@estado", estado)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ModificarContrato(int idContrato, int idEmpleado, int idEmpresa, DateTime fechaInicio, DateTime? fechaFin, double salarioBrutoAnual, string tipoContrato, string estado)
        {
            string sql = "UPDATE contrato SET id_empleado = @id_empleado, id_empresa = @id_empresa, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, salario_bruto_anual = @salario_bruto_anual, tipo_contrato = @tipo_contrato, estado = @estado WHERE id_contrato = @id_contrato";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_empleado", idEmpleado),
                new MySqlParameter("@id_empresa", idEmpresa),
                new MySqlParameter("@fecha_inicio", fechaInicio),
                new MySqlParameter("@fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value),
                new MySqlParameter("@salario_bruto_anual", salarioBrutoAnual),
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
    }
}