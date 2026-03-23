using gestor_empresa._01view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_empresa
{
    public partial class MainForm : Form
    {
        GestorLogin gest = new GestorLogin();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nifUsuario = txtUser.Text;
            string passwordUsuario = txtContrasenya.Text;

            GestorLogin gestor = new GestorLogin();
            string resultado = gestor.ObtenerRol(nifUsuario, passwordUsuario);

            if (resultado == "admin")
            {
                FormAdmin admin = new FormAdmin();
                admin.ShowDialog();
            }
            else if (resultado == "empleado")
            {
                FormEmpleado empleado = new FormEmpleado();
                empleado.ShowDialog();
            }
            else if (resultado == "incorrecto")
            {
                lblError.Text = "NIF o contraseña incorrectos.";
            }
            else if (resultado == "error_bd")
            {
                lblError.Text = "Error en la base de datos: " + gestor.Error();
            }
            else
            {
                lblError.Text = "Rol no autorizado para acceder.";
            }
        }
    }
}
