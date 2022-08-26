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
    public partial class frmChoixRemboursement : Form
    {
        public frmChoixRemboursement()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            frmRemboursementsdettes f = new frmRemboursementsdettes();
            f.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            frmConsulterRemboursement f = new frmConsulterRemboursement();
            f.ShowDialog();
        }
    }
}
