using gestor_empresa._01view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_empresa
{
    class GestorLogin
    {
        // Este método nos devuelve el error
        public string Error()
        {
            return Database.Error;
        }

        public string ObtenerRol(string nifUsuario, string pwUsuario) 
        {
            string sql = "SELECT rol FROM empleado WHERE nif = '" + nifUsuario + "' AND password = '" + pwUsuario + "'";
            DataTable resultado = Database.Consulta(sql);

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
    }
}
