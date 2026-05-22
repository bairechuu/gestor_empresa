using System;
using System.Data;
using System.Windows.Forms;

namespace gestor_empresa.Views.Admin
{
    public partial class UC_Personal : UserControl
    {
        private GestorUCPersonal gestor = new GestorUCPersonal();
        private string nifSeleccionado = "";
        private string cifSeleccionado = "";

        public UC_Personal()
        {
            InitializeComponent();
        }

        private void UCPersonal_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarEmpresas();
        }

        // ----------------- Empleados -----------------
        private void CargarEmpleados()
        {
            DataTable dtEmpleados = gestor.ObtenerEmpleados();
            dgvEmpleados.DataSource = dtEmpleados;
            dgvEmpleados.ClearSelection();
            btnLimpiarEmpleado_Click(null, null);
        }

        private void CargarEmpresas()
        {
            DataTable dtEmpresas = gestor.ObtenerEmpresas();
            dgvEmpresas.DataSource = dtEmpresas;
            dgvEmpresas.ClearSelection();
            btnLimpiarEmpresa_Click(null, null);
        }

        // Filtro los empleados en tiempo real según lo que el usuario va escribiendo.
        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarEmpleado.Text;
            if (string.IsNullOrEmpty(filtro))
            {
                CargarEmpleados(); // Si está vacío, vuelvo a mostrar todos.
            }
            else
            {
                DataTable dtBusqueda = gestor.BuscarEmpleados(filtro);
                dgvEmpleados.DataSource = dtBusqueda;
            }
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvEmpleados.SelectedRows[0];
                nifSeleccionado = fila.Cells["nif"].Value.ToString();
                txtNif.Text = nifSeleccionado;
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellidos.Text = fila.Cells["apellidos"].Value.ToString();
                cmbRol.SelectedItem = fila.Cells["rol"].Value.ToString();
            }
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {
            txtNif.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtBuscarEmpleado.Text = "";
            txtPassword.Text = "";
            cmbRol.SelectedIndex = -1;
            nifSeleccionado = "";
            dgvEmpleados.ClearSelection();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNif.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Rellene los campos obligatorios.");
                return;
            }

            int resultado = gestor.CrearEmpleado(txtNif.Text, txtNombre.Text, txtApellidos.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Empleado creado.");
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Error: " + gestor.ObtenerError());
            }
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nifSeleccionado))
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            int resultado = gestor.ModificarEmpleado(nifSeleccionado, txtNif.Text, txtNombre.Text, txtApellidos.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Empleado modificado.");
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Error: " + gestor.ObtenerError());
            }
        }

        private void btnDarBajaEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nifSeleccionado))
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar al empleado?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                int resultado = gestor.DarBajaEmpleado(nifSeleccionado);
                if (resultado > 0)
                {
                    MessageBox.Show("Empleado eliminado.");
                    CargarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + gestor.ObtenerError());
                }
            }
        }

        // Actualizo el rol (administrador/empleado) del usuario seleccionado.
        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nifSeleccionado) || cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado y un rol.");
                return;
            }

            int resultado = gestor.ActualizarRol(nifSeleccionado, cmbRol.SelectedItem.ToString());
            if (resultado > 0)
            {
                MessageBox.Show("Rol actualizado.");
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Error: " + gestor.ObtenerError());
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nifSeleccionado) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Seleccione un empleado y escriba una contraseña.");
                return;
            }

            int resultado = gestor.ResetearPassword(nifSeleccionado, txtPassword.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Contraseña actualizada.");
                txtPassword.Text = ""; // Limpio la caja de contraseña por seguridad.
            }
            else
            {
                MessageBox.Show("Error: " + gestor.ObtenerError());
            }
        }

        // ----------------- Empresas -----------------

        private void dgvEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvEmpresas.SelectedRows[0];
                cifSeleccionado = fila.Cells["cif"].Value.ToString();
                txtCif.Text = cifSeleccionado;
                txtNombreEmpresa.Text = fila.Cells["nombre"].Value.ToString();
            }
        }

        private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
        {
            txtCif.Text = "";
            txtNombreEmpresa.Text = "";
            cifSeleccionado = "";
            dgvEmpresas.ClearSelection();
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCif.Text) || string.IsNullOrEmpty(txtNombreEmpresa.Text))
            {
                MessageBox.Show("Rellene los campos obligatorios.");
                return;
            }

            int resultado = gestor.CrearEmpresa(txtCif.Text, txtNombreEmpresa.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Empresa creada.");
                CargarEmpresas();
            }
            else
            {
                MessageBox.Show("Error: " + gestor.ObtenerError());
            }
        }

        private void btnModificarEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cifSeleccionado))
            {
                MessageBox.Show("Seleccione una empresa.");
                return;
            }

            int resultado = gestor.ModificarEmpresa(cifSeleccionado, txtCif.Text, txtNombreEmpresa.Text);
            if (resultado > 0)
            {
                MessageBox.Show("Empresa modificada.");
                CargarEmpresas();
            }
            else
            {
                MessageBox.Show("Error: " + gestor.ObtenerError());
            }
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cifSeleccionado))
            {
                MessageBox.Show("Seleccione una empresa.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la empresa?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                int resultado = gestor.EliminarEmpresa(cifSeleccionado);
                if (resultado > 0)
                {
                    MessageBox.Show("Empresa eliminada.");
                    CargarEmpresas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + gestor.ObtenerError());
                }
            }
        }
    }
}