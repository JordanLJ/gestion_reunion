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
    public partial class frmGestionfondasso : Form
    {
        public frmGestionfondasso()
        {
            InitializeComponent();
        }

        private void frmGestionfondasso_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            txtmontantperçu.Text = "";
            txtmontantapayer.Text = "";
            txtreste.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            /*int a;
            a = Convert.ToInt16(txtmontantapayer) - Convert.ToInt16(txtmontantperçu);
            txtreste.Text = a;*/
        }
    }
}
