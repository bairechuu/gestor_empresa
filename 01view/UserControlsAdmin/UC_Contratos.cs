using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace gestor_empresa.Views.Admin
{
    public partial class UC_Contratos : UserControl
    {
        private GestorUCContratos gestorContratos;
        private int idContratoSeleccionado = -1;

        public UC_Contratos()
        {
            InitializeComponent();
            gestorContratos = new GestorUCContratos();
        }

        private void MostrarMensajeDesarrollo(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void UC_Contratos_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarEmpresas();
            CargarContratosInfo();
            LimpiarFormularioContrato();
        }

        private void CargarEmpleados()
        {
            DataTable dt = gestorContratos.ObtenerEmpleados();
            if (dt != null)
            {
                dgvEmpleados.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar empleados: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarContratosInfo()
        {
            DataTable dt = gestorContratos.ObtenerContratosInfo();
            if (dt != null)
            {
                dgvContratosBaja.DataSource = dt;
                dgvContratosFiniquito.DataSource = dt;
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

        private void TxtBuscarEmpleados_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarEmpleados(txtBuscarEmpleados.Text);
            if (dt != null)
            {
                dgvEmpleados.DataSource = dt;
            }
        }

        private void TxtBuscarContratosParaBaja_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarContratosInfo(txtBuscarContratosParaBaja.Text);
            if (dt != null) dgvContratosBaja.DataSource = dt;
        }

        private void TxtBuscarContratosParaFiniquito_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarContratosInfo(txtBuscarContratosParaFiniquito.Text);
            if (dt != null) dgvContratosFiniquito.DataSource = dt;
        }

        private void TxtBuscarEmpresas_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarEmpresas(txtBuscarEmpresas.Text);
            if (dt != null)
            {
                dgvEmpresas.DataSource = dt;
            }
        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                int idEmpleado = Convert.ToInt32(row.Cells["id_empleado"].Value);
                txtEmpleado.Text = idEmpleado.ToString();

                DataTable dt = gestorContratos.ObtenerContratoActivoPorEmpleado(idEmpleado);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    idContratoSeleccionado = Convert.ToInt32(r["id_contrato"]);
                    txtEmpresa.Text = r["id_empresa"].ToString();
                    if (r["fecha_inicio"] != DBNull.Value) dtpFechaInicio.Value = Convert.ToDateTime(r["fecha_inicio"]);
                    if (r["fecha_fin"] != DBNull.Value)
                    {
                        dtpFechaFin.Checked = true;
                        dtpFechaFin.Value = Convert.ToDateTime(r["fecha_fin"]);
                    }
                    else
                    {
                        dtpFechaFin.Checked = false;
                    }
                    txtSalario.Text = r["salario_bruto_anual"].ToString();
                    txtTipoContrato.Text = r["tipo_contrato"].ToString();
                    cmbEstado.SelectedItem = r["estado"].ToString();
                }
                else
                {
                    idContratoSeleccionado = -1;
                    txtEmpresa.Text = string.Empty;
                    dtpFechaInicio.Value = DateTime.Now;
                    dtpFechaFin.Checked = false;
                    txtSalario.Text = string.Empty;
                    txtTipoContrato.Text = string.Empty;
                    if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;
                }
            }
        }

        private void DgvContratosBaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContratosBaja.Rows[e.RowIndex];
                txtIdContratoBaja.Text = row.Cells["id_contrato"].Value.ToString();
            }
        }

        private void DgvContratosFiniquito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContratosFiniquito.Rows[e.RowIndex];
                txtIdContratoFiniquito.Text = row.Cells["id_contrato"].Value.ToString();
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
                    CargarContratosInfo(); // Recargar los dgvs de contratos en otras pestañas
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
                    CargarContratosInfo();
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

        private void BtnLimpiarBaja_Click(object sender, EventArgs e)
        {
            txtIdContratoBaja.Text = string.Empty;
            dtpBajaInicio.Value = DateTime.Now;
            dtpBajaFin.Checked = false;
            dtpBajaFin.Value = DateTime.Now;
            txtMotivo.Text = string.Empty;
            txtPrestacion.Text = string.Empty;
        }

        private void BtnLimpiarFiniquito_Click(object sender, EventArgs e)
        {
            txtIdContratoFiniquito.Text = string.Empty;
            dtpFechaDespido.Value = DateTime.Now;
            txtVacaciones.Text = string.Empty;
            txtIndemnizacion.Text = string.Empty;
            txtTotalNeto.Text = string.Empty;
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