using gestorempresa.Views.Admin;
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        /* 
        Lógica de botones
        Creo el UC para que no se mueva el panel lateral.
        Borro el anterior UC (si había).
        Ajusto la posición y lo añado al panel central para que se muestre.
        */
        private void btnGestPersonal_Click(object sender, EventArgs e)
        {
            UCPersonal UCPersonal = new UCPersonal();
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
    }
}
