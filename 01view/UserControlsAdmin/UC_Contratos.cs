using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace gestorempresa.Views.Admin
{
    public partial class UC_Contratos : UserControl
    {
        private GestorUCContratos gestorContratos;
        private int idContratoSeleccionado = -1;

        public UC_Contratos()
        {
            InitializeComponent();
            gestorContratos = new GestorUCContratos();

            // Asignar eventos a los botones y dgv
            btnCrearContrato.Click += BtnCrearContrato_Click;
            btnModificarContrato.Click += BtnModificarContrato_Click;
            btnLimpiarContrato.Click += BtnLimpiarContrato_Click;
            dgvContratos.CellClick += DgvContratos_CellClick;
            txtBuscarContratos.TextChanged += TxtBuscarContratos_TextChanged;

            // Asignar eventos para empresas
            dgvEmpresas.CellClick += DgvEmpresas_CellClick;
            txtBuscarEmpresas.TextChanged += TxtBuscarEmpresas_TextChanged;
        }

        private void UC_Contratos_Load(object sender, EventArgs e)
        {
            CargarContratos();
            CargarEmpresas();
            LimpiarFormularioContrato();
        }

        private void CargarContratos()
        {
            DataTable dt = gestorContratos.ObtenerContratos();
            if (dt != null)
            {
                dgvContratos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar contratos: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEmpresas()
        {
            DataTable dt = gestorContratos.ObtenerEmpresas();
            if (dt != null)
            {
                dgvEmpresas.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar empresas: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscarContratos_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarContratos(txtBuscarContratos.Text);
            if (dt != null)
            {
                dgvContratos.DataSource = dt;
            }
        }

        private void TxtBuscarEmpresas_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarEmpresas(txtBuscarEmpresas.Text);
            if (dt != null)
            {
                dgvEmpresas.DataSource = dt;
            }
        }

        private void DgvContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContratos.Rows[e.RowIndex];
                idContratoSeleccionado = Convert.ToInt32(row.Cells["id_contrato"].Value);
                txtEmpleado.Text = row.Cells["id_empleado"].Value.ToString();
                txtEmpresa.Text = row.Cells["id_empresa"].Value.ToString();

                if (row.Cells["fecha_inicio"].Value != DBNull.Value)
                    dtpFechaInicio.Value = Convert.ToDateTime(row.Cells["fecha_inicio"].Value);

                if (row.Cells["fecha_fin"].Value != DBNull.Value)
                {
                    dtpFechaFin.Checked = true;
                    dtpFechaFin.Value = Convert.ToDateTime(row.Cells["fecha_fin"].Value);
                }
                else
                {
                    dtpFechaFin.Checked = false;
                }

                txtSalario.Text = row.Cells["salario_bruto_anual"].Value.ToString();
                txtTipoContrato.Text = row.Cells["tipo_contrato"].Value.ToString();

                string estado = row.Cells["estado"].Value.ToString();
                cmbEstado.SelectedItem = estado;
            }
        }

        private void DgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpresas.Rows[e.RowIndex];
                txtEmpresa.Text = row.Cells["id_empresa"].Value.ToString();
            }
        }

        private void BtnCrearContrato_Click(object sender, EventArgs e)
        {
            if (ValidarFormularioContrato())
            {
                int idEmpleado = int.Parse(txtEmpleado.Text);
                int idEmpresa = int.Parse(txtEmpresa.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime? fechaFin = dtpFechaFin.Checked ? (DateTime?)dtpFechaFin.Value : null;
                double salarioBrutoAnual = double.Parse(txtSalario.Text);
                string tipoContrato = txtTipoContrato.Text;
                string estado = cmbEstado.SelectedItem.ToString();

                int result = gestorContratos.CrearContrato(idEmpleado, idEmpresa, fechaInicio, fechaFin, salarioBrutoAnual, tipoContrato, estado);

                if (result > 0)
                {
                    MessageBox.Show("Contrato creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarContratos();
                    LimpiarFormularioContrato();
                }
                else
                {
                    MessageBox.Show("Error al crear contrato: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnModificarContrato_Click(object sender, EventArgs e)
        {
            if (idContratoSeleccionado != -1 && ValidarFormularioContrato())
            {
                int idEmpleado = int.Parse(txtEmpleado.Text);
                int idEmpresa = int.Parse(txtEmpresa.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime? fechaFin = dtpFechaFin.Checked ? (DateTime?)dtpFechaFin.Value : null;
                double salarioBrutoAnual = double.Parse(txtSalario.Text);
                string tipoContrato = txtTipoContrato.Text;
                string estado = cmbEstado.SelectedItem.ToString();

                int result = gestorContratos.ModificarContrato(idContratoSeleccionado, idEmpleado, idEmpresa, fechaInicio, fechaFin, salarioBrutoAnual, tipoContrato, estado);

                if (result > 0)
                {
                    MessageBox.Show("Contrato modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarContratos();
                    LimpiarFormularioContrato();
                }
                else
                {
                    MessageBox.Show("Error al modificar contrato: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (idContratoSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un contrato para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLimpiarContrato_Click(object sender, EventArgs e)
        {
            LimpiarFormularioContrato();
        }

        private void LimpiarFormularioContrato()
        {
            idContratoSeleccionado = -1;
            txtEmpleado.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Checked = false;
            dtpFechaFin.Value = DateTime.Now;
            txtSalario.Text = string.Empty;
            txtTipoContrato.Text = string.Empty;
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0; // activo por defecto
        }

        private bool ValidarFormularioContrato()
        {
            if (string.IsNullOrWhiteSpace(txtEmpleado.Text) || !int.TryParse(txtEmpleado.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un ID de empleado válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmpresa.Text) || !int.TryParse(txtEmpresa.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un ID de empresa válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSalario.Text) || !double.TryParse(txtSalario.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un salario válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTipoContrato.Text))
            {
                MessageBox.Show("Por favor, ingrese el tipo de contrato.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el estado del contrato.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}