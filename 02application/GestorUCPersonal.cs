using MySql.Data.MySqlClient;
using System.Data;

namespace gestor_empresa
{
    class GestorUCPersonal
    {
        // ── EMPLEADOS ────────────────────────────────────────────────

        public DataTable ObtenerTodosEmpleados()
        {
            string sql = "SELECT id_empleado, nif, nombre, apellidos, rol FROM empleado ORDER BY apellidos, nombre";
            return Database.Consulta(sql);
        }

        public DataTable BuscarEmpleados(string filtro)
        {
            string sql = @"SELECT id_empleado, nif, nombre, apellidos, rol 
                           FROM empleado 
                           WHERE nif LIKE @filtro OR nombre LIKE @filtro OR apellidos LIKE @filtro
                           ORDER BY apellidos, nombre";
            var p = new MySqlParameter[] {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };
            return Database.Consulta(sql, p);
        }

        public int InsertarEmpleado(string nif, string nombre, string apellidos, string password, string rol)
        {
            string sql = @"INSERT INTO empleado (nif, nombre, apellidos, password, rol) 
                           VALUES (@nif, @nombre, @apellidos, @password, @rol)";
            var p = new MySqlParameter[] {
                new MySqlParameter("@nif", nif),
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@apellidos", apellidos),
                new MySqlParameter("@password", password),
                new MySqlParameter("@rol", rol)
            };
            return Database.Modificacion(sql, p);
        }

        public int ModificarEmpleado(int idEmpleado, string nif, string nombre, string apellidos, string rol)
        {
            string sql = @"UPDATE empleado SET nif=@nif, nombre=@nombre, apellidos=@apellidos, rol=@rol
                           WHERE id_empleado=@id";
            var p = new MySqlParameter[] {
                new MySqlParameter("@id", idEmpleado),
                new MySqlParameter("@nif", nif),
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@apellidos", apellidos),
                new MySqlParameter("@rol", rol)
            };
            return Database.Modificacion(sql, p);
        }

        /// <summary>Da de baja lógica: pone a inactivo todos los contratos del empleado.</summary>
        public int DarDeBajaEmpleado(int idEmpleado)
        {
            string sql = "UPDATE contrato SET estado='inactivo' WHERE id_empleado=@id";
            var p = new MySqlParameter[] { new MySqlParameter("@id", idEmpleado) };
            return Database.Modificacion(sql, p);
        }

        // ── ACCESOS ──────────────────────────────────────────────────

        public int CambiarRol(int idEmpleado, string nuevoRol)
        {
            string sql = "UPDATE empleado SET rol=@rol WHERE id_empleado=@id";
            var p = new MySqlParameter[] {
                new MySqlParameter("@rol", nuevoRol),
                new MySqlParameter("@id",  idEmpleado)
            };
            return Database.Modificacion(sql, p);
        }

        public int ResetearPassword(int idEmpleado, string nuevaPassword)
        {
            string sql = "UPDATE empleado SET password=@pw WHERE id_empleado=@id";
            var p = new MySqlParameter[] {
                new MySqlParameter("@pw", nuevaPassword),
                new MySqlParameter("@id", idEmpleado)
            };
            return Database.Modificacion(sql, p);
        }

        // ── EMPRESAS ─────────────────────────────────────────────────

        public DataTable ObtenerTodasEmpresas()
        {
            string sql = "SELECT id_empresa, nombre, cif FROM empresa ORDER BY nombre";
            return Database.Consulta(sql);
        }

        public int InsertarEmpresa(string nombre, string cif)
        {
            string sql = "INSERT INTO empresa (nombre, cif) VALUES (@nombre, @cif)";
            var p = new MySqlParameter[] {
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@cif",    cif)
            };
            return Database.Modificacion(sql, p);
        }

        public int ModificarEmpresa(int idEmpresa, string nombre, string cif)
        {
            string sql = "UPDATE empresa SET nombre=@nombre, cif=@cif WHERE id_empresa=@id";
            var p = new MySqlParameter[] {
                new MySqlParameter("@nombre", nombre),
                new MySqlParameter("@cif",    cif),
                new MySqlParameter("@id",     idEmpresa)
            };
            return Database.Modificacion(sql, p);
        }

        public int EliminarEmpresa(int idEmpresa)
        {
            // Solo elimina si no tiene contratos asociados
            string sql = @"DELETE FROM empresa WHERE id_empresa=@id 
                           AND id_empresa NOT IN (SELECT id_empresa FROM contrato)";
            var p = new MySqlParameter[] { new MySqlParameter("@id", idEmpresa) };
            return Database.Modificacion(sql, p);
        }
    }
}