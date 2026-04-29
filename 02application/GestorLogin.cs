using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_empresa
{
    class GestorLogin
    {
        // Este método nos devuelve el error
        public string Error()
        {
            return Database.Error;
        }

        // Método que verificará si el Login es correcto y, en caso de que lo sea, obtendrá su rol
        public string ObtenerRol(string nifUsuario, string pwUsuario)
        {
            string sql = "SELECT rol FROM empleado WHERE nif = @nif AND password = @password";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@nif", nifUsuario),
                new MySqlParameter("@password", pwUsuario)
            };

            DataTable resultado = Database.Consulta(sql, parametros);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                return resultado.Rows[0]["rol"].ToString();
            }
            else if (resultado != null && resultado.Rows.Count == 0)
            {
                return "incorrecto";
            }
            else
            {
                return "error_bd";
            }
        }

        // Método que devuelve los datos del Empleado
        public Empleado ObtenerDatosEmpleado(string nifUsuario, string pwUsuario)
        {
            string sql = "SELECT id_empleado, nombre, apellidos, nif, rol FROM empleado WHERE nif = @nif AND password = @password";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@nif", nifUsuario),
                new MySqlParameter("@password", pwUsuario)
            };

            DataTable resultado = Database.Consulta(sql, parametros);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                Empleado empleadoEncontrado = new Empleado(
                    Convert.ToInt32(fila["id_empleado"]),
                    fila["nombre"].ToString(),
                    fila["apellidos"].ToString(),
                    fila["nif"].ToString(),
                    fila["rol"].ToString()
                );

                return empleadoEncontrado;
            }
            else
            {
                return null;
            }
        }

        // Obtiene los datos del contrato del empleado que se le pase
        public Contrato ObtenerContrato(Empleado emp)
        {
            string sql = "SELECT id_contrato, id_empleado, id_empresa, fecha_inicio, fecha_fin, salario_bruto_anual, tipo_contrato, estado " +
                         "FROM contrato WHERE id_empleado = @idEmpleado ORDER BY id_contrato DESC LIMIT 1";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idEmpleado", emp.Id)
            };

            DataTable resultado = Database.Consulta(sql, parametros);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                int idC = Convert.ToInt32(fila["id_contrato"]);
                int idE = Convert.ToInt32(fila["id_empleado"]);
                int idEm = Convert.ToInt32(fila["id_empresa"]);
                DateTime fInicio = Convert.ToDateTime(fila["fecha_inicio"]);

                DateTime? fFinal = null;
                if (fila["fecha_fin"] != DBNull.Value)
                {
                    fFinal = Convert.ToDateTime(fila["fecha_fin"]);
                }

                double bruto = Convert.ToDouble(fila["salario_bruto_anual"]);
                string tipo = fila["tipo_contrato"].ToString();
                bool esActivo = fila["estado"].ToString() == "activo";

                Contrato objetoContrato = new Contrato(idC, idE, idEm, fInicio, fFinal, bruto, tipo, esActivo);

                return objetoContrato;
            }

            return null;
        }

        // Función que obtiene la empresa del empleado que se le pase
        public Empresa ObtenerEmpresaPorEmpleado(Empleado emp)
        {
            string sql = "SELECT e.id_empresa, e.nombre, e.cif " +
                         "FROM empresa e " +
                         "INNER JOIN contrato c ON e.id_empresa = c.id_empresa " +
                         "WHERE c.id_empleado = @idEmpleado " +
                         "ORDER BY c.id_contrato DESC LIMIT 1";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@idEmpleado", emp.Id)
            };

            DataTable resultado = Database.Consulta(sql, parametros);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                int id = Convert.ToInt32(fila["id_empresa"]);
                string nombre = fila["nombre"].ToString();
                string cif = fila["cif"].ToString();

                Empresa objetoEmpresa = new Empresa(id, nombre, cif);
                return objetoEmpresa;
            }

            return null;
        }
    }
}