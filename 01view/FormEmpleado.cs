using System;
using System.Data;
using System.Windows.Forms;

namespace gestor_empresa
{
    public partial class FormEmpleado : Form
    {
        GestorEmpleado gestor = new GestorEmpleado();
        private Empleado usuario;
        private Contrato contrato;
        private Empresa empresa;
        
        // Método que le pasa al form datos del empleado, del contrato y de la empresa
        public FormEmpleado(Empleado empl, Contrato cont, Empresa empres)
        {
            InitializeComponent();
            usuario = empl;
            contrato = cont;
            empresa = empres;
        }
        public void CargarDatos()
        {
            // Hora precargada
            lblHora.Text = DateTime.Now.ToString("HH:mm");

            // DGVs
            DataTable tablaNominas = gestor.ObtenerNominasPorEmpleado(usuario.Id);
            dgvNominas.DataSource = tablaNominas;
            DataTable tablaBajas = gestor.ObtenerBajasPorEmpleado(usuario.Id);
            dgvBajas.DataSource = tablaBajas;

            // Labels centro
            lblEmpresa.Text = "Empresa: " + empresa.Nombre;
            lblEstado.Text = contrato.Estado ? "Estado: Activo" : "Estado: Inactivo";
            lblTipoContrato.Text = "Tipo: " + contrato.TipoContrato;
            lblSalario.Text = "Salario anual: " + contrato.Bruto;
            lblInfoEmpMedio.Text = "Portal del empleado: " + usuario.Nombre + " " + usuario.Apellidos;
            //Labels izq + foto
            lblInfoEmpIzq.Text = usuario.Nombre + " " + usuario.Apellidos + "\n" + usuario.Nif;
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Restart();
            }
        }

        //Muestra las horas para el fichaje
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        // Lógica del botón para fichar
        public void btnFichar_Click(object sender, EventArgs e)
        {
            Jornada servicio = new Jornada();
            DataTable dtJornada = gestor.ObtenerRegistroAbierto(usuario.Id);

            if (dtJornada.Rows.Count == 0)
            {
                int resultado = gestor.InsertarEntrada(usuario.Id);

                if (resultado > 0)
                {
                    MessageBox.Show("Entrada registrada con éxito.");
                    lblEstadoFichaje.Text = "Hora de entrada: " + DateTime.Now.ToString("t");
                    btnFichar.Text = "Terminar jornada";
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el registro: " + Database.Error);
                }
            }
            else
            {
                int idJornada = Convert.ToInt32(dtJornada.Rows[0]["id_jornada"]);

                int resultado = gestor.ActualizarSalida(idJornada);
                if (resultado > 0)
                {
                    MessageBox.Show("Salida registrada con éxito.");
                    lblEstadoFichaje.Text = "Salida registrada correctamente.";
                    btnFichar.Text = "Fichar";
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro: " + Database.Error);
                }
            }
        }
    }
}
