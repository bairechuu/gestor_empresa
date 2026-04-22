using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_empresa
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public double Bruto { get; set; }
        public string TipoContrato { get; set; }
        public bool Estado { get; set; }

        public Contrato(int idContrato, int idEmpleado, int idEmpresa, DateTime fechaInicio,
            DateTime? fechaFinal, double bruto, string tipoContrato, bool estado)
        {
            IdContrato = idContrato;
            IdEmpleado = idEmpleado;
            IdEmpresa = idEmpresa;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            Bruto = bruto;
            TipoContrato = tipoContrato;
            Estado = estado;
        }
    }
}