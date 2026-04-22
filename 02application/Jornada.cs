using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_empresa
{
    class Jornada
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public int HorasExtra { get; set; }
        public Jornada(int id, DateTime fecha, DateTime horaEntrada, DateTime horaSalida, int horasExtra)
        {
            Id = id;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            HorasExtra = horasExtra;
        }
        public Jornada()
        {

        }
    }
}
