using gestor_empresa.Views.Admin;
using System;
using System.Windows.Forms;

namespace gestor_empresa
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            CargarControlBienvenida();
        }

        /* 
        Lógica de botones
        Creo el UC para que no se mueva el panel lateral.
        Borro el anterior UC (si había).
        Ajusto la posición y lo añado al panel central para que se muestre.
        */

        private void CargarControlBienvenida()
        {
            UC_Bienvenida UCBienvenida = new UC_Bienvenida();
            pnlCentral.Controls.Clear();
            UCBienvenida.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(UCBienvenida);
        }
        private void btnGestPersonal_Click(object sender, EventArgs e)
        {
            UC_Personal UCPersonal = new UC_Personal();
            pnlCentral.Controls.Clear();
            UCPersonal.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(UCPersonal);
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            UC_Contratos UCContratos = new UC_Contratos();
            pnlCentral.Controls.Clear();
            UCContratos.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(UCContratos);
        }

        private void btnEconomico_Click(object sender, EventArgs e)
        {
            UC_Economico UCEconomico = new UC_Economico();
            pnlCentral.Controls.Clear();
            UCEconomico.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(UCEconomico);
        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            UC_Presencia UCPresencia = new UC_Presencia();
            pnlCentral.Controls.Clear();
            UCPresencia.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(UCPresencia);
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación",
                MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
