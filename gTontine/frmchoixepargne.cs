using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gTontine
{
    public partial class frmchoixepargne : Form
    {
        public frmchoixepargne()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            frmConsulterepargne f = new frmConsulterepargne();
            f.ShowDialog();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            frmEpargne f = new frmEpargne();
            f.ShowDialog();
        }
    }
}
