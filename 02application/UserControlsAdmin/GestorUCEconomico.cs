using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace gestor_empresa
{
    class GestorUCEconomico
    {
        public DataTable ObtenerContratosActivos(string filtro = "")
        {
            string sql = @"
                SELECT c.id_contrato, e.nombre, e.apellidos, e.nif, c.salario_bruto_anual 
                FROM contrato c
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                WHERE c.estado = 'activo' AND (e.nombre LIKE @filtro OR e.apellidos LIKE @filtro OR e.nif LIKE @filtro OR c.id_contrato LIKE @filtro)";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@filtro", "%" + filtro + "%")
            };

            return Database.Consulta(sql, parametros);
        }

        public int GenerarNomina(int idContrato, int mes, int anyo, decimal salarioBruto, decimal retencionIrpf, decimal cotizacionSs, decimal salarioNeto)
        {
            string sqlCheck = "SELECT COUNT(*) FROM nomina WHERE id_contrato = @id_contrato AND mes = @mes AND anyo = @anyo";
            MySqlParameter[] parametrosCheck = new MySqlParameter[]
            {
                new MySqlParameter("@id_contrato", idContrato),
                new MySqlParameter("@mes", mes),
                new MySqlParameter("@anyo", anyo)
            };

            DataTable dtCheck = Database.Consulta(sqlCheck, parametrosCheck);
            if (dtCheck != null && dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
            {
                return -1; // Ya existe una nómina para este contrato en ese mes y año
            }

            string sql = @"
                INSERT INTO nomina (id_contrato, mes, anyo, salario_bruto, retencion_irpf, cotizacion_ss, salario_neto) 
                VALUES (@id_contrato, @mes, @anyo, @salario_bruto, @retencion_irpf, @cotizacion_ss, @salario_neto)";

            MySqlParameter[] parametros = new MySqlParameter[]
            {
                new MySqlParameter("@id_contrato", idContrato),
                new MySqlParameter("@mes", mes),
                new MySqlParameter("@anyo", anyo),
                new MySqlParameter("@salario_bruto", salarioBruto),
                new MySqlParameter("@retencion_irpf", retencionIrpf),
                new MySqlParameter("@cotizacion_ss", cotizacionSs),
                new MySqlParameter("@salario_neto", salarioNeto)
            };

            return Database.Modificacion(sql, parametros);
        }

        public DataTable ObtenerHistoricoNominas(string empleadoFiltro = "", string mesFiltro = "Todos", string anyoFiltro = "")
        {
            string sql = @"
                SELECT n.id_nomina, c.id_contrato, e.nombre, e.apellidos, n.mes, n.anyo, n.salario_bruto, n.retencion_irpf, n.cotizacion_ss, n.salario_neto
                FROM nomina n
                INNER JOIN contrato c ON n.id_contrato = c.id_contrato
                INNER JOIN empleado e ON c.id_empleado = e.id_empleado
                WHERE (e.nombre LIKE @empleado OR e.apellidos LIKE @empleado OR e.nif LIKE @empleado)";

            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@empleado", "%" + empleadoFiltro + "%"));

            if (mesFiltro != "Todos" && int.TryParse(mesFiltro, out int mes))
            {
                sql += " AND n.mes = @mes";
                parametros.Add(new MySqlParameter("@mes", mes));
            }

            if (!string.IsNullOrEmpty(anyoFiltro) && int.TryParse(anyoFiltro, out int anyo))
            {
                sql += " AND n.anyo = @anyo";
                parametros.Add(new MySqlParameter("@anyo", anyo));
            }

            sql += " ORDER BY n.anyo DESC, n.mes DESC";

            return Database.Consulta(sql, parametros.ToArray());
        }

        public string ObtenerError()
        {
            return Database.Error;
        }
    }
}
