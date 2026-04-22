using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_empresa
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nif { get; set; }
        public string Rol { get; set; }
        public Empleado(int id, string nombre, string apellidos, string nif, string rol)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Nif = nif;
            Rol = rol;
        }
    }
}
