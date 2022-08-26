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
    public partial class frmReglerTontitne : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette,requette_libelle, Nommembre = "";
        int u, u1, codetontine, codecycle, lecode;
        decimal m1;
        public frmReglerTontitne()
        {
            InitializeComponent();
        }

        private void frmReglerTontitne_Load(object sender, EventArgs e)
        {
            Chargement();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cboAdhe.Text= Nommembre = Convert.ToString(dataGridView2.CurrentRow.Cells["nom_membre"].Value);
            lecode= Convert.ToInt16(dataGridView2.CurrentRow.Cells["id_paye_tontine"].Value);
            txtmontantapayer.Text= Convert.ToString(dataGridView2.CurrentRow.Cells["montant_restant"].Value);
            
            string st = Convert.ToString(dataGridView2.CurrentRow.Cells["statut_paye"].Value);
            m1 = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["montant_percu"].Value);
            if (st == "Non payer")
            {
               txtmontantapayer.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["montant_payer"].Value);
            }
            else
            {
                txtmontantapayer.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["montant_restant"].Value);
            }


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Chargement();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCycle_SelectedIndexChanged(object sender, EventArgs e)
        {
            codecycle = a.ResultatRequette1("select code_cycle from cycle where lib_cycle='" + cboCycle.Text + "'");
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (txtmontantpercu.Text == "")
            {
                MessageBox.Show("Veuillez remplir le montant perçu s'il vous plait");
            }
            else
            {
                txtreste.Text = (Convert.ToDecimal(txtmontantapayer.Text) - Convert.ToDecimal(txtmontantpercu.Text)).ToString();
                cbostatut.Text = "Avancer";
                if (txtreste.Text == "0") cbostatut.Text = "Rembourser";
            }
        }

        private void txtmontantpercu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cbostatut.Text == "" || txtmontantpercu.Text == "" || txtreste.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs contenant les étoiles rouges!");
            }
            else
            {
                if (Convert.ToDecimal(txtmontantpercu.Text) > (Convert.ToDecimal(txtmontantapayer.Text)))
                {
                    MessageBox.Show("Le montant percu ne doit pas etre supérieur au montant a percevoir!");
                }
                else
                {
                    Decimal m2 = Convert.ToDecimal(txtmontantpercu.Text);
                    Decimal o = m2 + m1;
                    //requette = "INSERT INTO `paye_tontine`( `nom_membre`, `montant_payer`, `montant_restant`, `date_paye_tontine`, `id_association`, `code_cycle`,rang) VALUES ('" + cboAdhe.Text + "','" + txtmontantapayer.Text + "','" + txtmontantperçu.Text + "','" + a.date_vers_mysql(txtdaterembourse.Text) + "','" + codetontine + "','" + codecycle + "','" + txtrang.Text + "')";
                    requette = "UPDATE `paye_tontine` SET `montant_percu`='" + o + "', `montant_restant`='" + txtreste.Text + "',`date_paye_tontine`='" + a.date_vers_mysql(txtdaterembourse.Text) + "',`statut_paye`='"+cbostatut.Text+"' WHERE `id_paye_tontine`='" + lecode + "'";
                   
                    // requette = "INSERT INTO `paye_tontine`( `nom_membre`, `montant_payer`, `montant_percu`, `montant_restant`, `satut_paye`,`date_paye_tontine`, `code_tontine`, `code_cycle`, `id_association`, `rang`) VALUES ('" + Nommembre + "', '" + txtmontantapayer.Text + "', '" + txtmontantpercu.Text + "', '" + txtreste.Text + "', '" + cbostatut.Text + "','" + a.date_vers_mysql(txtdaterembourse.Text) + "', '" + ClasseGenerale.gIdTontine + "','" + codecycle + "', '" + ClasseGenerale.gIdAssociation + "', '" + txtrang.Text + "')";
                    a.ExecuteRequette(requette);
                    int idop = 1;
                    requette = "INSERT INTO `historique`(`id_operation`, `id_association`, `id_tontine`,`libelle`, `date_operation`, `montant`, `montant_percu`, `reste`, `statut_operation`, `code_adherent`, `code_utilisateur`) VALUES ('" + idop + "', '" + ClasseGenerale.gIdAssociation + "', '" + ClasseGenerale.gIdTontine + "', 'REbgler tontine', '" + a.date_vers_mysql(txtdaterembourse.Text) + "','" + txtmontantapayer.Text + "', '" + txtmontantpercu.Text + "', '" + txtreste.Text + "', '" + cbostatut.Text + "', '" + lecode + "',   '" + ClasseGenerale.gCodeUtilisateur + "')";
                    a.ExecuteRequette(requette);

                    MessageBox.Show(requette);

                    Chargement2();

                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbotontine_SelectedIndexChanged(object sender, EventArgs e)
        {
            codetontine = a.ResultatRequette1("select code_tontine from tontine where libelle='"+cbotontine.Text+"'");
            
           // txtmontantapayer.Text = (tap).ToString();
        }
        void Chargement2()
        {
            u = a.ResultatRequette1("select code_cycle from cycle where lib_cycle='" + cboCycle.Text + "'");
            u1 = a.ResultatRequette1("SELECT `code_tontine` FROM `tontine` WHERE `libelle`='" + cbotontine.Text + "'"); 
            requette = "Select * from paye_tontine where code_tontine='" + u1 + "' and code_cycle='" + u + "' and id_association='" + ClasseGenerale.gIdAssociation + "' and rang='" + txtrang.Text + "'";
            a.ChargeTable1(dataGridView2, requette);
            MessageBox.Show(requette);
            int y = a.ResultatRequette1("select montant from tontine where libelle='" + cbotontine.Text + "'");
            txtmontantapayer.Text = (y).ToString();
            txtdaterembourse.Text = "";
            txtmontantapayer.Text = "";
            txtmontantpercu.Text = "";
            txtreste.Text = "";
            


        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Chargement2();
        }
        void Chargement()
        {
            a.ChargeTable1(dataGridView2, "SELECT * FROM `paye_tontine` WHERE `id_association`='" + ClasseGenerale.gIdAssociation + "'");
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
           // tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            requette_libelle = "select lib_cycle from cycle where id_association='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeCombo(cboCycle, requette_libelle);
            requette_libelle = "SELECT `libelle` FROM `tontine` WHERE  `id_association`='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeCombo(cbotontine, requette_libelle);
            btnEnregistrer.Enabled = true;
            btnSupprimer.Enabled = false;

        }
    }
}
