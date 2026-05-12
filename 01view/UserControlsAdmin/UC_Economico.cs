using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorempresa.Views.Admin
{
    public partial class UC_Economico : UserControl
    {
        public UC_Economico()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función en desarrollo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función en desarrollo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAnyo.Clear();
            txtSalarioBruto.Clear();
            txtRetencionIRPF.Clear();
            txtCotizacionSS.Clear();
            txtSalarioNeto.Clear();
        }

        private void TxtBuscarContratos_TextChanged(object sender, EventArgs e)
        {
            // Lógica para filtrar los contratos activos
        }

        private void DgvContratosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica al seleccionar un contrato
        }

        private void FiltrosHistorico_Changed(object sender, EventArgs e)
        {
            // Lógica para filtrar el histórico
        }
    }
}
