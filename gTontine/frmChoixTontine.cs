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
    public partial class frmChoixTontine : Form
    {
        public frmChoixTontine()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            frmReglerTontitne f = new frmReglerTontitne();
            f.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            frmConsultertontine f = new frmConsultertontine();
            f.ShowDialog();
        }
    }
}
