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
        GestorLogin gestor = new GestorLogin();
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

            string resultado = gestor.ObtenerRol(nifUsuario, passwordUsuario);

            if (resultado == "admin")
            {
                Empleado emp = null;
                emp = gestor.ObtenerDatosEmpleado(nifUsuario, passwordUsuario);
                FormAdmin admin = new FormAdmin();
                admin.ShowDialog();
            }
            else if (resultado == "empleado")
            {
                Empleado empl = null;
                empl = gestor.ObtenerDatosEmpleado(nifUsuario, passwordUsuario);
                Contrato cont = null;
                cont = gestor.ObtenerContrato(empl);
                Empresa empr = null;
                empr = gestor.ObtenerEmpresaPorEmpleado(empl);
                FormEmpleado empleado = new FormEmpleado(empl, cont, empr);
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
