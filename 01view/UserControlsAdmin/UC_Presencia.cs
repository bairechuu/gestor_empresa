using System;
using System.Data;
using System.Windows.Forms;

namespace gestor_empresa.Views.Admin
{
    public partial class UC_Presencia : UserControl
    {
        private GestorUCPresencia gestor;

        public UC_Presencia()
        {
            InitializeComponent();
            gestor = new GestorUCPresencia();
        }

        private void UC_Presencia_Load(object sender, EventArgs e)
        {
            CargarMonitor();
            CargarAuditoria();
            LimpiarFormulario();
            // Para que se vea correctamente la fecha, voy al último día de este mes.
            dtpFiltroInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFiltroFin.Value = dtpFiltroInicio.Value.AddMonths(1).AddDays(-1);
            CargarHorasExtra();
        }

        // Cargo la tabla del monitor en tiempo real con las jornadas de los empleados que están trabajando ahora.
        private void CargarMonitor()
        {
            DataTable dt = gestor.ObtenerJornadasAbiertas();
            dgvMonitor.DataSource = dt;
        }

        // Botón para actualizar manualmente la tabla del monitor.
        private void btnRefrescarMonitor_Click(object sender, EventArgs e)
        {
            CargarMonitor();
        }

        // Cargo todas las jornadas registradas en la tabla de auditoría.
        private void CargarAuditoria()
        {
            DataTable dt = gestor.ObtenerTodasLasJornadas();
            dgvAuditoria.DataSource = dt;
        }

        private void LimpiarFormulario()
        {
            txtIdJornada.Text = "";
            txtIdContrato.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            chkSalidaNula.Checked = false;
            txtHorasExtra.Text = "0";
        }

        private void btnLimpiarJornada_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // Creo e inserto una jornada manual a partir de los datos que he rellenado en el formulario.
        private void btnCrearJornada_Click(object sender, EventArgs e)
        {
            try
            {
                int idContrato = int.Parse(txtIdContrato.Text);
                DateTime fecha = dtpFecha.Value;
                DateTime entrada = new DateTime(fecha.Year, fecha.Month, fecha.Day, dtpEntrada.Value.Hour, dtpEntrada.Value.Minute, 0);
                // Si marco "Sin salida" guardo un nulo; de lo contrario, construyo la fecha y hora completa de salida.
                DateTime? salida = chkSalidaNula.Checked ? (DateTime?)null : new DateTime(fecha.Year, fecha.Month, fecha.Day, dtpSalida.Value.Hour, dtpSalida.Value.Minute, 0);

                decimal horasExtra = 0;
                decimal.TryParse(txtHorasExtra.Text, out horasExtra);

                int result = gestor.InsertarJornada(idContrato, fecha, entrada, salida, horasExtra);
                if (result > 0)
                {
                    MessageBox.Show("Jornada creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAuditoria();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al crear jornada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifique los datos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Modifico los datos de la jornada que tengo seleccionada en la tabla usando el formulario lateral.
        private void btnModificarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdJornada.Text))
                {
                    MessageBox.Show("Seleccione una jornada para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idJornada = int.Parse(txtIdJornada.Text);
                int idContrato = int.Parse(txtIdContrato.Text);
                DateTime fecha = dtpFecha.Value;
                DateTime entrada = new DateTime(fecha.Year, fecha.Month, fecha.Day, dtpEntrada.Value.Hour, dtpEntrada.Value.Minute, 0);
                DateTime? salida = chkSalidaNula.Checked ? (DateTime?)null : new DateTime(fecha.Year, fecha.Month, fecha.Day, dtpSalida.Value.Hour, dtpSalida.Value.Minute, 0);

                decimal horasExtra = 0;
                decimal.TryParse(txtHorasExtra.Text, out horasExtra);

                int result = gestor.ActualizarJornada(idJornada, idContrato, fecha, entrada, salida, horasExtra);
                if (result > 0)
                {
                    MessageBox.Show("Jornada modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAuditoria();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al modificar jornada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, verifique los datos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Elimino la jornada seleccionada en la base de datos tras la confirmación del usuario.
        private void btnEliminarJornada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdJornada.Text))
            {
                MessageBox.Show("Seleccione una jornada para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar esta jornada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int idJornada = int.Parse(txtIdJornada.Text);
                int result = gestor.EliminarJornada(idJornada);
                if (result > 0)
                {
                    MessageBox.Show("Jornada eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAuditoria();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al eliminar jornada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Al cambiar de fila en la tabla de auditoría, cargo toda su información en el panel lateral para poder editarla.
        private void dgvAuditoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAuditoria.CurrentRow != null && dgvAuditoria.CurrentRow.Index > -1)
            {
                DataGridViewRow row = dgvAuditoria.CurrentRow;
                txtIdJornada.Text = row.Cells["ID"].Value.ToString();
                txtIdContrato.Text = row.Cells["ID Contrato"].Value.ToString();

                if (DateTime.TryParse(row.Cells["Fecha"].Value.ToString(), out DateTime fecha))
                    dtpFecha.Value = fecha;

                if (DateTime.TryParse(row.Cells["Entrada"].Value.ToString(), out DateTime entrada))
                    dtpEntrada.Value = entrada;

                if (row.Cells["Salida"].Value != DBNull.Value && row.Cells["Salida"].Value != null && row.Cells["Salida"].Value.ToString() != "")
                {
                    if (DateTime.TryParse(row.Cells["Salida"].Value.ToString(), out DateTime salida))
                        dtpSalida.Value = salida;
                    chkSalidaNula.Checked = false;
                }
                else
                {
                    // Si todavía no ha salido (salida nula), activo el check y pongo la hora actual en el datetimepicker.
                    chkSalidaNula.Checked = true;
                    dtpSalida.Value = DateTime.Now;
                }

                txtHorasExtra.Text = row.Cells["Horas Extra"].Value.ToString();
            }
        }

        // Botón para recargar el resumen de horas extra aplicando el filtro de fechas.
        private void btnBuscarHoras_Click(object sender, EventArgs e)
        {
            CargarHorasExtra();
        }

        // Cargo el resumen de horas extra desde la BBDD filtrando por las fechas de inicio y fin seleccionadas.
        private void CargarHorasExtra()
        {
            DateTime inicio = dtpFiltroInicio.Value;
            DateTime fin = dtpFiltroFin.Value;
            DataTable dt = gestor.ObtenerResumenHorasExtra(inicio, fin);
            dgvHorasExtra.DataSource = dt;
        }

        // Activo o desactivo el selector de fecha/hora de salida en base a si la jornada no tiene salida registrada.
        private void chkSalidaNula_CheckedChanged(object sender, EventArgs e)
        {
            dtpSalida.Enabled = !chkSalidaNula.Checked;
        }
    }
}
