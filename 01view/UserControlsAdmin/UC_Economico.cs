using System;
using System.Data;
using System.Windows.Forms;

namespace gestor_empresa.Views.Admin
{
    public partial class UC_Economico : UserControl
    {
        private GestorUCEconomico gestor;
        private int contratoSeleccionadoId = -1; // -1 == ninguno seleccionado
        private decimal salarioAnualSeleccionado = 0;
        private int numPagasSeleccionado = 12; // 12 o 14 según el número de pagas
        private decimal irpfFijoSeleccionado = 15.00m; // Porcentaje default del IRPF

        public UC_Economico()
        {
            InitializeComponent();
            gestor = new GestorUCEconomico();

            // Coloco por defecto el mes y año actuales para ahorrarle clics al administrativo.
            if (cmbMes.Items.Count > 0)
            {
                cmbMes.SelectedItem = DateTime.Now.Month.ToString();
            }
            txtAnyo.Text = DateTime.Now.Year.ToString();
            if (cmbFiltroMes.Items.Count > 0)
            {
                cmbFiltroMes.SelectedIndex = 0; // "Todos"
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
                // Oculto el sueldo anual en la tabla para mantener la privacidad de los datos en pantalla.
                dgvContratosActivos.Columns["salario_bruto_anual"].Visible = false;
            }
        }

        // Cargo el histórico de nóminas generadas aplicando los filtros seleccionados.
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

        // Guardo la nómina en la base de datos con los cálculos actuales.
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            // Valido que se haya seleccionado un empleado de la tabla.
            if (contratoSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, seleccione un contrato y calcule la nómina.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valido que los campos esenciales no estén vacíos.
            if (string.IsNullOrWhiteSpace(txtSalarioBruto.Text) || string.IsNullOrWhiteSpace(txtSalarioNeto.Text) ||
                cmbMes.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtAnyo.Text))
            {
                MessageBox.Show("Por favor, asegúrese de calcular la nómina y rellenar mes y año.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valido el formato numérico del mes y el año.
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
                    CargarHistorico(); // Actualizo mi tabla de histórico para ver los cambios de inmediato.
                    BtnLimpiar_Click(null, null); // Limpio el formulario tras guardar.
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

        // Ejecuto todos los cálculos matemáticos para desglosar la nómina mensual.
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (contratoSeleccionadoId == -1)
            {
                MessageBox.Show("Por favor, seleccione un contrato de la lista de activos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbMes.SelectedItem?.ToString(), out int mes) || !int.TryParse(txtAnyo.Text, out int anyo))
            {
                MessageBox.Show("Seleccione un mes y escriba un año válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Salario Base mensual: divido el bruto anual por las pagas y redondeo a 2 decimales.
            decimal salarioBaseMensual = Math.Round(salarioAnualSeleccionado / numPagasSeleccionado, 2);

            // 2. Horas extras: las consulto de la BBDD y calculo su valor basándome en 1800h anuales de convenio.
            decimal horasExtraMes = gestor.ObtenerHorasExtra(contratoSeleccionadoId, mes, anyo);
            decimal precioHoraExtra = Math.Round(salarioAnualSeleccionado / 1800, 2);
            decimal valorHorasExtras = horasExtraMes * precioHoraExtra;

            // 3. Bajas médicas: consulto y sumo las prestaciones de incapacidad temporal del mes.
            decimal prestacionesBaja = gestor.ObtenerPrestacionesBaja(contratoSeleccionadoId, mes, anyo);

            // Base de cotización: la suma de su salario mensual, horas extras y prestaciones por baja médica.
            decimal baseCotizacion = salarioBaseMensual + valorHorasExtras + prestacionesBaja;

            // 4. Extrasalariales: leo pluses como transporte o dietas (que están exentos de cotizaciones e IRPF).
            decimal extrasalariales = 0;
            if (txtExtrasalariales != null && !string.IsNullOrWhiteSpace(txtExtrasalariales.Text))
            {
                decimal.TryParse(txtExtrasalariales.Text, out extrasalariales);
            }

            // Total Devengado (Salario Bruto Total).
            decimal salarioBrutoTotal = baseCotizacion + extrasalariales;

            // 5. Retención IRPF: aplico el porcentaje del contrato sobre la base de cotización.
            decimal porcentajeIRPF = irpfFijoSeleccionado / 100m;
            decimal retencionIrpf = Math.Round(baseCotizacion * porcentajeIRPF, 2);

            // 6. Seguridad Social: aplico un 6.47% de retención general de cotización al trabajador.
            decimal porcentajeSS = 0.0647m;
            decimal cotizacionSs = Math.Round(baseCotizacion * porcentajeSS, 2);

            // 7. Salario Neto: el sueldo final libre de impuestos.
            decimal salarioNeto = salarioBrutoTotal - retencionIrpf - cotizacionSs;

            // Muestro los importes en las cajas de texto de la interfaz.
            txtSalarioBase.Text = salarioBaseMensual.ToString("0.00");
            txtSalarioBruto.Text = salarioBrutoTotal.ToString("0.00");
            txtRetencionIRPF.Text = retencionIrpf.ToString("0.00");
            txtCotizacionSS.Text = cotizacionSs.ToString("0.00");
            txtSalarioNeto.Text = salarioNeto.ToString("0.00");

            // Si hay algún extra, muestro un mensaje en pantalla detallando el desglose.
            if (valorHorasExtras > 0 || prestacionesBaja > 0 || extrasalariales > 0)
            {
                MessageBox.Show("Detalle Salarial:\n" +
                                "- Base Cotización: " + baseCotizacion + "€\n" +
                                "  (Incluye " + valorHorasExtras + "€ en H. Extra y " + prestacionesBaja + "€ en Bajas)\n" +
                                "- P. Extrasalariales: " + extrasalariales + "€\n" +
                                "- Bruto Total: " + salarioBrutoTotal + "€",
                                "Cálculo Realizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAnyo.Text = DateTime.Now.Year.ToString();
            if (cmbMes.Items.Count > 0) cmbMes.SelectedItem = DateTime.Now.Month.ToString();
            txtSalarioBase.Clear();
            txtSalarioBruto.Clear();
            txtRetencionIRPF.Clear();
            txtCotizacionSS.Clear();
            txtSalarioNeto.Clear();
            if (txtExtrasalariales != null) txtExtrasalariales.Text = "0";
            contratoSeleccionadoId = -1;
            salarioAnualSeleccionado = 0;
            dgvContratosActivos.ClearSelection();
        }

        // Filtro los contratos activos en la base de datos a medida que el usuario teclea en el buscador.
        private void TxtBuscarContratos_TextChanged(object sender, EventArgs e)
        {
            CargarContratosActivos();
        }

        // Guardo los datos de la fila del contrato activo sobre la que el usuario haga clic.
        private void DgvContratosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valido que se pulse sobre una fila de datos real y no sobre los títulos de las columnas.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContratosActivos.Rows[e.RowIndex];
                contratoSeleccionadoId = Convert.ToInt32(row.Cells["id_contrato"].Value);
                salarioAnualSeleccionado = Convert.ToDecimal(row.Cells["salario_bruto_anual"].Value);
                numPagasSeleccionado = row.Cells["num_pagas"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["num_pagas"].Value) : 12;
                irpfFijoSeleccionado = row.Cells["irpf_fijo"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["irpf_fijo"].Value) : 15.00m;
            }
        }

        // Recargo el histórico cuando se modifica cualquiera de los filtros.
        private void FiltrosHistorico_Changed(object sender, EventArgs e)
        {
            CargarHistorico();
        }
    }
}
