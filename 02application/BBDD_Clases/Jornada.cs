using System;

namespace gestor_empresa
{
    class Jornada
    {
        public int Id { get; set; }
        public int IdContrato { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public decimal HorasExtra { get; set; }

        public Jornada(int id, int idContrato, DateTime fecha, DateTime horaEntrada, DateTime? horaSalida, decimal horasExtra)
        {
            Id = id;
            IdContrato = idContrato;
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
