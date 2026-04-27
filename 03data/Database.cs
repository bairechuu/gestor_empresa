using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace gestor_empresa
{
    /* 
        He copiado la conexión a la base de datos del proyecto academia, modificándola en gran medida.
        Principalmente he añadido unos parámetros opcionales para evitar la posibilidad de SQL injection
        y he eliminado los finally (ya que no terminaba de comprenderlos al 100%) cambiándolos por using.
     */
    internal class Database
    {
        static public string Error { get; set; }
        static public int NumRegModif { set; get; }

        // Conexión a la BD
        static private MySqlConnection Conectar()
        {
            string cad = "datasource=127.0.0.1; port=3306; username=root; password=; database=gestor_empresa;";
            MySqlConnection conexionBD = new MySqlConnection(cad);
            return conexionBD;
        }

        // Método de consulta con parámetros opcionales anti SQL injection
        static public DataTable Consulta(string sql, MySqlParameter[] parametros = null)
        {
            try
            {
                using (MySqlConnection conexionBD = Conectar())
                {
                    using (MySqlCommand comando = new MySqlCommand(sql, conexionBD))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            NumRegModif = 0;
                            Error = "";
                            return ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Error = e.Message;
                NumRegModif = -1;
                return null;
            }
        }

        // Método de modificación con parámetros opcionales anti SQL injection
        static public int Modificacion(string sql, MySqlParameter[] parametros = null)
        {
            try
            {
                using (MySqlConnection conexionBD = Conectar())
                {
                    using (MySqlCommand comando = new MySqlCommand(sql, conexionBD))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }

                        conexionBD.Open();
                        NumRegModif = comando.ExecuteNonQuery();
                        Error = "";
                        return NumRegModif;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Error = ex.Message;
                NumRegModif = -1;
                return NumRegModif;
            }
        }
    }
}