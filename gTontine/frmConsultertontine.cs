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
    public partial class frmConsultertontine : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int u, u1;
        public frmConsultertontine()
        {
            InitializeComponent();
        }

        private void frmenregistrertontine_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            string requette_libelle = "";
            requette_libelle = "select lib_cycle from cycle where id_association='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeCombo(cboCycle, requette_libelle);
            requette_libelle = "SELECT `libelle` FROM `tontine` WHERE  `id_association`='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeCombo(cbotontine, requette_libelle);
            a.ChargeTable1(dataGridView1, "SELECT * FROM `paye_tontine` WHERE `id_association`='" + ClasseGenerale.gIdAssociation + "'");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            /*requette = "INSERT INTO paye_tontine VALUES('null','" + cboAdhe.Text + "','" + txtmontantapayer + "','" + txtreste + "','" + dtpDate + "')";
            a.ExecuteRequette(requette);
            chargement();
            MessageBox.Show("operation effectue avec succes!");
    */    
    }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cette opération n'est pas possible mon petit!");
        }

        private void txtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {

            u = a.ResultatRequette1("select code_cycle from cycle where lib_cycle='" + cboCycle.Text + "'");
            u1 = a.ResultatRequette1("SELECT `code_tontine` FROM `tontine` WHERE `libelle`='" + cbotontine.Text + "'");
            requette = "Select * from paye_tontine where code_tontine='" + u1 + "' and code_cycle='" + u + "' and id_association='" + ClasseGenerale.gIdAssociation + "' and rang='" + txtrang.Text + "'";
            a.ChargeTable1(dataGridView1, requette);
        }
    }
}
