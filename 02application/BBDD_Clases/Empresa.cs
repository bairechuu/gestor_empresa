namespace gestor_empresa
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cif { get; set; }

        public Empresa (int id, string nombre, string cif)
        {
            Id = id;
            Nombre = nombre;
            Cif = cif;
        }
    }
}
