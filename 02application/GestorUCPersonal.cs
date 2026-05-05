using gestor_empresa;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace gestorempresa
{
    class GestorUCPersonal
    {
        // ----------------- Empleados -----------------
        public DataTable ObtenerEmpleados()
        {
            string sql = "SELECT nif, nombre, apellidos, rol FROM empleado";
            return Database.Consulta(sql);
        }

        public DataTable BuscarEmpleados(string filtro)
        {
            string sql = "SELECT nif, nombre, apellidos, rol FROM empleado WHERE nif LIKE @filtro OR nombre LIKE @filtro OR apellidos LIKE @filtro";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, parametros);
        }

        public int CrearEmpleado(string nif, string nombre, string apellidos)
        {
            string sql = "INSERT INTO empleado (nif, nombre, apellidos, password, rol) VALUES (@nif, @nombre, @apellidos, @password, 'empleado')";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@nif", nif),
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@apellidos", apellidos),
                new MySqlParameter("@password", nif)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ModificarEmpleado(string nifAnterior, string nif, string nombre, string apellidos)
        {
            string sql = "UPDATE empleado SET nif = @nif, nombre = @nombre, apellidos = @apellidos WHERE nif = @nifAnterior";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@nif", nif),
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@apellidos", apellidos),
                new MySqlParameter("@nifAnterior", nifAnterior)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int DarBajaEmpleado(string nif)
        {
            string sql = "DELETE FROM empleado WHERE nif = @nif";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@nif", nif)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ActualizarRol(string nif, string rol)
        {
            string sql = "UPDATE empleado SET rol = @rol WHERE nif = @nif";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@rol", rol),
                new MySqlParameter("@nif", nif)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ResetearPassword(string nif, string nuevaPassword)
        {
            string sql = "UPDATE empleado SET password = @password WHERE nif = @nif";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@password", nuevaPassword),
                new MySqlParameter("@nif", nif)
            };
            return Database.Modificacion(sql, parametros);
        }

        // ----------------- Empresas -----------------
        public DataTable ObtenerEmpresas()
        {
            string sql = "SELECT cif, nombre FROM empresa";
            return Database.Consulta(sql);
        }

        public int CrearEmpresa(string cif, string nombre)
        {
            string sql = "INSERT INTO empresa (cif, nombre) VALUES (@cif, @nombre)";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@cif", cif),
                new MySqlParameter("@nombre", nombre)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int ModificarEmpresa(string cifAnterior, string cif, string nombre)
        {
            string sql = "UPDATE empresa SET cif = @cif, nombre = @nombre WHERE cif = @cifAnterior";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@cif", cif),
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@cifAnterior", cifAnterior)
            };
            return Database.Modificacion(sql, parametros);
        }

        public int EliminarEmpresa(string cif)
        {
            string sql = "DELETE FROM empresa WHERE cif = @cif";
            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@cif", cif)
            };
            return Database.Modificacion(sql, parametros);
        }

        public string ObtenerError()
        {
            return Database.Error;
        }
    }
}