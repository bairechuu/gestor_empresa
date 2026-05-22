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
        private int idBajaSeleccionada = -1;

        public UC_Contratos()
        {
            InitializeComponent();
            gestorContratos = new GestorUCContratos();
        }

        private void UC_Contratos_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarEmpresas();
            CargarContratosInfo();
            CargarBajas();
            CargarFiniquitos();
            CargarContratosActivos();
            LimpiarFormularioContrato();
        }

        private void CargarContratosActivos()
        {
            DataTable dt = gestorContratos.ObtenerContratosActivos();
            if (dt != null)
            {
                dgvContratosActivos.DataSource = dt;
            }
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

        private void CargarBajas()
        {
            DataTable dt = gestorContratos.ObtenerBajas();
            if (dt != null) dgvBajas.DataSource = dt;
        }

        private void CargarFiniquitos()
        {
            DataTable dt = gestorContratos.ObtenerFiniquitos();
            if (dt != null) dgvFiniquitos.DataSource = dt;
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
            // e.RowIndex obliga al usuario a hacer click sobre una fila de datos y no en una cabecera
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                int idEmpleado = Convert.ToInt32(row.Cells["id_empleado"].Value);
                txtEmpleado.Text = idEmpleado.ToString();
            }
        }

        private void DgvContratosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridRow = dgvContratosActivos.Rows[e.RowIndex];
                int idContrato = Convert.ToInt32(gridRow.Cells["id_contrato"].Value);

                DataTable dt = gestorContratos.ObtenerContratoPorId(idContrato);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    idContratoSeleccionado = Convert.ToInt32(r["id_contrato"]);
                    txtEmpleado.Text = r["id_empleado"].ToString();
                    txtEmpresa.Text = r["id_empresa"].ToString();

                    if (r["fecha_inicio"] != DBNull.Value)
                        dtpFechaInicio.Value = Convert.ToDateTime(r["fecha_inicio"]);
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
                    // DBNull necesario para que el programa no de error con la fecha
                    txtNumPagas.Text = r["num_pagas"] != DBNull.Value ? r["num_pagas"].ToString() : "12";
                    txtIrpfFijo.Text = r["irpf_fijo"] != DBNull.Value ? r["irpf_fijo"].ToString() : "15.00";
                    txtTipoContrato.Text = r["tipo_contrato"].ToString();
                    cmbEstado.SelectedItem = r["estado"].ToString();
                }
            }
        }

        private void TxtBuscarContratosActivos_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = gestorContratos.BuscarContratosActivos(txtBuscarContratosActivos.Text);
            if (dt != null)
            {
                dgvContratosActivos.DataSource = dt;
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
                DateTime? fechaFin = dtpFechaFin.Checked ? (DateTime?)dtpFechaFin.Value : null; // Nullable en caso de indefinido
                double salarioBrutoAnual = double.Parse(txtSalario.Text);
                int numPagas = int.Parse(txtNumPagas.Text);
                double irpfFijo = double.Parse(txtIrpfFijo.Text);
                string tipoContrato = txtTipoContrato.Text;
                string estado = cmbEstado.SelectedItem.ToString();

                int result = gestorContratos.CrearContrato(idEmpleado, idEmpresa, fechaInicio, fechaFin, salarioBrutoAnual, numPagas, irpfFijo, tipoContrato, estado);

                if (result > 0)
                {
                    MessageBox.Show("Contrato creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarContratosInfo(); // Recargar los dgvs de contratos en otras pestañas
                    CargarContratosActivos();
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
            // Verifica que se haya seleccionado un contrato y que los campos no esten vacios
            {
                int idEmpleado = int.Parse(txtEmpleado.Text);
                int idEmpresa = int.Parse(txtEmpresa.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime? fechaFin = dtpFechaFin.Checked ? (DateTime?)dtpFechaFin.Value : null; // Nullable en caso de indefinido
                double salarioBrutoAnual = double.Parse(txtSalario.Text);
                int numPagas = int.Parse(txtNumPagas.Text);
                double irpfFijo = double.Parse(txtIrpfFijo.Text);
                string tipoContrato = txtTipoContrato.Text;
                string estado = cmbEstado.SelectedItem.ToString();

                int result = gestorContratos.ModificarContrato(idContratoSeleccionado, idEmpleado, idEmpresa, fechaInicio, fechaFin, salarioBrutoAnual, numPagas, irpfFijo, tipoContrato, estado);

                if (result > 0)
                {
                    MessageBox.Show("Contrato modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarContratosInfo();
                    CargarContratosActivos();
                    LimpiarFormularioContrato();
                }
                else
                {
                    MessageBox.Show("Error al modificar contrato: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (idContratoSeleccionado == -1) // En caso de que no haya seleccionado un empleado (Para dar el error concreto)
            {
                MessageBox.Show("Seleccione un contrato para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLimpiarContrato_Click(object sender, EventArgs e)
        {
            LimpiarFormularioContrato();
        }

        private void BtnCrearBaja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdContratoBaja.Text) || !int.TryParse(txtIdContratoBaja.Text, out int idContrato))
            {
                MessageBox.Show("ID de contrato inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime fechaInicio = dtpBajaInicio.Value;
            DateTime? fechaFin = dtpBajaFin.Checked ? (DateTime?)dtpBajaFin.Value : null;
            string motivo = txtMotivo.Text;
            double? prestacion = string.IsNullOrWhiteSpace(txtPrestacion.Text) ? null : (double?)double.Parse(txtPrestacion.Text);

            int result = gestorContratos.CrearBaja(idContrato, fechaInicio, fechaFin, motivo, prestacion);
            if (result > 0)
            {
                MessageBox.Show("Baja registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarBajas();
                BtnLimpiarBaja_Click(null, null);
            }
            else
            {
                MessageBox.Show("Error al registrar baja: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarBaja_Click(object sender, EventArgs e)
        {
            if (idBajaSeleccionada != -1 && !string.IsNullOrWhiteSpace(txtIdContratoBaja.Text))
            {
                int idContrato = int.Parse(txtIdContratoBaja.Text);
                DateTime fechaInicio = dtpBajaInicio.Value;
                DateTime? fechaFin = dtpBajaFin.Checked ? (DateTime?)dtpBajaFin.Value : null;
                string motivo = txtMotivo.Text;
                double? prestacion = string.IsNullOrWhiteSpace(txtPrestacion.Text) ? null : (double?)double.Parse(txtPrestacion.Text);

                int result = gestorContratos.ModificarBaja(idBajaSeleccionada, idContrato, fechaInicio, fechaFin, motivo, prestacion);
                if (result > 0)
                {
                    MessageBox.Show("Baja modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarBajas();
                    BtnLimpiarBaja_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Error al modificar baja: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una baja para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Calculo la prestación económica por baja médica usando los porcentajes legales actuales
        private void CalcularPrestacionBaja(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdContratoBaja.Text) || !int.TryParse(txtIdContratoBaja.Text, out int idContrato))
            {
                txtPrestacion.Text = "0.00";
                return;
            }

            if (!dtpBajaFin.Checked)
            {
                txtPrestacion.Text = "0.00"; // Si la baja sigue abierta no calculamos el acumulado.
                return;
            }

            DateTime inicio = dtpBajaInicio.Value.Date;
            DateTime fin = dtpBajaFin.Value.Date;

            if (fin < inicio)
            {
                txtPrestacion.Text = "0.00"; 
                return;
            }

            // Del día 1 al 3 cobra 0%; del 4 al 20 cobra el 60%; y a partir del 21 cobra el 75%.
            DataTable dt = gestorContratos.ObtenerContratoPorId(idContrato);
            if (dt != null && dt.Rows.Count > 0)
            {
                double salarioBrutoAnual = Convert.ToDouble(dt.Rows[0]["salario_bruto_anual"]);
                double baseReguladoraDiaria = salarioBrutoAnual / 365.0; // base diaria

                int diasBaja = (fin - inicio).Days + 1;
                double prestacionTotal = 0;

                for (int dia = 1; dia <= diasBaja; dia++)
                {
                    if (dia <= 3)
                    {
                        // 0%
                    }
                    else if (dia <= 20)
                    {
                        prestacionTotal += baseReguladoraDiaria * 0.60;
                    }
                    else
                    {
                        prestacionTotal += baseReguladoraDiaria * 0.75;
                    }
                }

                txtPrestacion.Text = prestacionTotal.ToString("0.00");
            }
            else
            {
                txtPrestacion.Text = "0.00";
            }
        }

        private void DgvBajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBajas.Rows[e.RowIndex];
                idBajaSeleccionada = Convert.ToInt32(row.Cells["id_baja"].Value);
                txtIdContratoBaja.Text = row.Cells["id_contrato"].Value.ToString();
                if (row.Cells["fecha_inicio"].Value != DBNull.Value) dtpBajaInicio.Value = Convert.ToDateTime(row.Cells["fecha_inicio"].Value);
                if (row.Cells["fecha_fin"].Value != DBNull.Value)
                {
                    dtpBajaFin.Checked = true;
                    dtpBajaFin.Value = Convert.ToDateTime(row.Cells["fecha_fin"].Value);
                }
                else
                {
                    dtpBajaFin.Checked = false; // La baja sigue en curso.
                }
                txtMotivo.Text = row.Cells["motivo"].Value.ToString();
                txtPrestacion.Text = row.Cells["prestacion"].Value.ToString();
            }
        }

        // Sumo vacaciones e indemnización en el cálculo de finiquito.
        private void BtnCalcularFiniquito_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVacaciones.Text, out double vac) && double.TryParse(txtIndemnizacion.Text, out double ind))
            {
                double total = vac + ind;
                txtTotalNeto.Text = total.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para vacaciones e indemnización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuardarFiniquito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdContratoFiniquito.Text) || !int.TryParse(txtIdContratoFiniquito.Text, out int idContrato))
            {
                MessageBox.Show("ID de contrato inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTotalNeto.Text))
            {
                MessageBox.Show("Calcule el total neto primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaDespido = dtpFechaDespido.Value;
            double vacaciones = double.Parse(txtVacaciones.Text);
            double indemnizacion = double.Parse(txtIndemnizacion.Text);
            double totalNeto = double.Parse(txtTotalNeto.Text);

            int result = gestorContratos.CrearFiniquito(idContrato, fechaDespido, vacaciones, indemnizacion, totalNeto);
            if (result > 0)
            {
                MessageBox.Show("Finiquito guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarFiniquitos();
                BtnLimpiarFiniquito_Click(null, null);
            }
            else
            {
                MessageBox.Show("Error al guardar finiquito: " + gestorContratos.ObtenerError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------- Botones de limpieza y validación de formulario -------
        private void LimpiarFormularioContrato()
        {
            idContratoSeleccionado = -1;
            txtEmpleado.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Checked = false;
            dtpFechaFin.Value = DateTime.Now;
            txtSalario.Text = string.Empty;
            txtNumPagas.Text = "12";
            txtIrpfFijo.Text = "15.00";
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
            if (string.IsNullOrWhiteSpace(txtNumPagas.Text) || !int.TryParse(txtNumPagas.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un número de pagas válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIrpfFijo.Text) || !double.TryParse(txtIrpfFijo.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un valor de IRPF Fijo válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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