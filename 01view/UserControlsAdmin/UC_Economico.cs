using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_empresa.Views.Admin
{
    public partial class UC_Economico : UserControl
    {
        private GestorUCEconomico gestor;
        private int contratoSeleccionadoId = -1;
        private decimal salarioAnualSeleccionado = 0;

        public UC_Economico()
        {
            InitializeComponent();
            gestor = new GestorUCEconomico();

            if (cmbMes.Items.Count > 0)
            {
                cmbMes.SelectedItem = DateTime.Now.Month.ToString();
            }
            txtAnyo.Text = DateTime.Now.Year.ToString();
            if (cmbFiltroMes.Items.Count > 0)
            {
                cmbFiltroMes.SelectedIndex = 0; // "Todos"
            }

            // Para no cargar datos en tiempo de diseño y evitar errores
            if (!this.DesignMode)
            {
                CargarContratosActivos();
                CargarHistorico();
            }
        }

        private void CargarContratosActivos()
        {
            DataTable dt = gestor.ObtenerContratosActivos(txtBuscarContratos.Text.Trim());
            dgvContratosActivos.DataSource = dt;

            if (dgvContratosActivos.Columns.Count > 0 && dgvContratosActivos.Columns.Contains("id_contrato"))
            {
                dgvContratosActivos.Columns["id_contrato"].HeaderText = "ID Contrato";
                dgvContratosActivos.Columns["nombre"].HeaderText = "Nombre";
                dgvContratosActivos.Columns["apellidos"].HeaderText = "Apellidos";
                dgvContratosActivos.Columns["nif"].HeaderText = "NIF";
                dgvContratosActivos.Columns["salario_bruto_anual"].Visible = false;
            }
        }

        private void CargarHistorico()
        {
            string mesFiltro = cmbFiltroMes.SelectedItem?.ToString() ?? "Todos";
            DataTable dt = gestor.ObtenerHistoricoNominas(txtFiltroEmpleado.Text.Trim(), mesFiltro, txtFiltroAnyo.Text.Trim());
            dgvHistorico.DataSource = dt;

            if (dgvHistorico.Columns.Count > 0 && dgvHistorico.Columns.Contains("id_nomina"))
            {
                dgvHistorico.Columns["id_nomina"].HeaderText = "ID Nómina";
                dgvHistorico.Columns["id_contrato"].HeaderText = "ID Contrato";
                dgvHistorico.Columns["nombre"].HeaderText = "Nombre";
                dgvHistorico.Columns["apellidos"].HeaderText = "Apellidos";
                dgvHistorico.Columns["mes"].HeaderText = "Mes";
                dgvHistorico.Columns["anyo"].HeaderText = "Año";
                dgvHistorico.Columns["salario_bruto"].HeaderText = "S. Bruto";
                dgvHistorico.Columns["retencion_irpf"].HeaderText = "IRPF";
                dgvHistorico.Columns["cotizacion_ss"].HeaderText = "Cotización SS";
                dgvHistorico.Columns["salario_neto"].HeaderText = "S. Neto";
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (contratoSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, seleccione un contrato y calcule la nómina.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSalarioBruto.Text) || string.IsNullOrWhiteSpace(txtSalarioNeto.Text) ||
                cmbMes.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtAnyo.Text))
            {
                MessageBox.Show("Por favor, asegúrese de calcular la nómina y rellenar mes y año.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbMes.SelectedItem.ToString(), out int mes) || !int.TryParse(txtAnyo.Text, out int anyo))
            {
                MessageBox.Show("El mes o año no tienen un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                decimal bruto = Convert.ToDecimal(txtSalarioBruto.Text);
                decimal irpf = Convert.ToDecimal(txtRetencionIRPF.Text);
                decimal ss = Convert.ToDecimal(txtCotizacionSS.Text);
                decimal neto = Convert.ToDecimal(txtSalarioNeto.Text);

                int resultado = gestor.GenerarNomina(contratoSeleccionadoId, mes, anyo, bruto, irpf, ss, neto);

                if (resultado > 0)
                {
                    MessageBox.Show("Nómina generada y guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHistorico();
                    BtnLimpiar_Click(null, null);
                }
                else if (resultado == -1)
                {
                    MessageBox.Show("Ya existe una nómina generada para este empleado en ese mes y año.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar la nómina: " + gestor.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formato de los importes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (contratoSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, seleccione un contrato de la lista de activos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salarioBrutoMensual = Math.Round(salarioAnualSeleccionado / 12, 2);
            decimal retencionIrpf = Math.Round(salarioBrutoMensual * 0.15m, 2); // 15% IRPF genérico
            decimal cotizacionSs = Math.Round(salarioBrutoMensual * 0.0635m, 2); // 6.35% SS genérico
            decimal salarioNeto = salarioBrutoMensual - retencionIrpf - cotizacionSs;

            txtSalarioBruto.Text = salarioBrutoMensual.ToString("0.00");
            txtRetencionIRPF.Text = retencionIrpf.ToString("0.00");
            txtCotizacionSS.Text = cotizacionSs.ToString("0.00");
            txtSalarioNeto.Text = salarioNeto.ToString("0.00");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAnyo.Text = DateTime.Now.Year.ToString();
            if (cmbMes.Items.Count > 0) cmbMes.SelectedItem = DateTime.Now.Month.ToString();
            txtSalarioBruto.Clear();
            txtRetencionIRPF.Clear();
            txtCotizacionSS.Clear();
            txtSalarioNeto.Clear();
            contratoSeleccionadoId = -1;
            salarioAnualSeleccionado = 0;
            dgvContratosActivos.ClearSelection();
        }

        private void TxtBuscarContratos_TextChanged(object sender, EventArgs e)
        {
            CargarContratosActivos();
        }

        private void DgvContratosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContratosActivos.Rows[e.RowIndex];
                contratoSeleccionadoId = Convert.ToInt32(row.Cells["id_contrato"].Value);
                salarioAnualSeleccionado = Convert.ToDecimal(row.Cells["salario_bruto_anual"].Value);
            }
        }

        private void FiltrosHistorico_Changed(object sender, EventArgs e)
        {
            CargarHistorico();
        }
    }
}
