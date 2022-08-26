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
    public partial class frmChoixFonddecaisse : Form
    {
        public frmChoixFonddecaisse()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            frmConsultationfondecaisse f = new frmConsultationfondecaisse();
            f.ShowDialog();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            frmFonddecaisse f = new frmFonddecaisse();
            f.ShowDialog();
        }
    }
}
