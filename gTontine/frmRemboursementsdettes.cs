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
    public partial class frmRemboursementsdettes : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette,  codepret = "";
        int lecode, codeadherent;
        Decimal m1;
        public frmRemboursementsdettes()
        {
            InitializeComponent();
        }

        private void frmRemboursementsdettes_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {  
            txtmontantapayer.Text = "";
            txtmontantpercu.Text = "";
            txtdaterembourse.Text = "";
            txtreste.Text = "";
            cboAdhe.Text = "";
            cbostatut.Text = "";

            //string requete = "select a.code_adherent, nom, prenom,  e.id_pret, montant,e.taux_interet, e.date_pret, e.statut from adherent a, prets e where a.code_adherent = e.code_adherent and e.id_association = '" + ClasseGenerale.gIdAssociation + "' and e.statut='Non rembourser';";
            //string requete = "1select a.code_adherent, nom, prenom, e.id_pret, montant,e.taux_interet, e.date_pret, e.statut, r.montant_percu, r.reste_remboursement from adherent a, prets e, remboursement r where a.code_adherent = e.code_adherent and e.id_association = '" + ClasseGenerale.gIdAssociation + "' AND e.id_pret=r.id_pret and (e.statut='Non rembourser' or e.statut='Avancer');";
            string requete = "select a.code_adherent, nom, prenom, e.id_pret, montant,e.taux_interet, e.date_pret, e.statut, r.montant_percu, r.reste_remboursement , r.date_remboursement from adherent a, prets e, remboursement r where a.code_adherent = e.code_adherent and e.id_pret=r.id_pret and e.id_association = '"+ClasseGenerale.gIdAssociation+"' and (e.statut='Non rembourser' or e.statut='Avancer');";
            a.ChargeTable(dataGridView2, requete);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //requette = "INSERT INTO remboursement VALUES('null', '" + cboAdhe.Text + "', '" + txtmontantapayer.Text + "', '" + txtmontantperçu.Text + "', '" + txtreste.Text + "', '" + txtdaterembourse.Text + "')";
            //requette = "INSERT INTO `remboursement`(`id_rembousement`, `code_adherent`, `id_pret`, `montant_payer`, `montant_percu`, `reste_remboursement`, `date_remboursement`)  VALUES('null', '" + codeadherent + "', '" + codepret + "', '" + txtmontantapayer.Text + "', '" + txtmontantpercu.Text + "', '" + txtreste.Text + "', '" + a.date_vers_mysql(txtdaterembourse.Text) + "')";
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
                else { 
                Decimal m2 = Convert.ToDecimal(txtmontantpercu.Text);
                Decimal o = m2 + m1;
                requette = "UPDATE `remboursement` SET `montant_payer`='" + txtmontantapayer.Text + "',`montant_percu`='" + o + "',`reste_remboursement`='" + txtreste.Text + "',`date_remboursement`='" + a.date_vers_mysql(txtdaterembourse.Text) + "' WHERE `id_pret`='" + codepret + "'";
                a.ExecuteRequette(requette);

                requette = "UPDATE `prets` SET `statut`='" + cbostatut.Text + "' WHERE `id_pret`='" + codepret + "'";
                a.ExecuteRequette(requette);
                //int idop = a.ResultatRequette1("");
                int idop = 1;
                requette = "INSERT INTO `historique`(`id_operation`, `id_association`, `id_tontine`,`libelle`, `date_operation`, `montant`, `montant_percu`, `reste`, `statut_operation`, `code_adherent`, `code_utilisateur`) VALUES ('" + idop + "', '" + ClasseGenerale.gIdAssociation + "', '" + ClasseGenerale.gIdTontine + "', 'Rembousement dette', '" + a.date_vers_mysql(txtdaterembourse.Text) + "','" + txtmontantapayer.Text + "', '" + txtmontantpercu.Text + "', '" + txtreste.Text + "', '" + cbostatut.Text + "', '" + lecode + "',   '" + ClasseGenerale.gCodeUtilisateur + "')";
                a.ExecuteRequette(requette);
                MessageBox.Show("Opération effectué avec succès!");
                chargement();
                }
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (txtmontantpercu.Text=="")
            {
                MessageBox.Show("Veuillez remplir le montant perçu s'il vous plait");
            }
            else { 
                txtreste.Text = (Convert.ToDecimal(txtmontantapayer.Text) - Convert.ToDecimal(txtmontantpercu.Text)).ToString();
                cbostatut.Text = "Avancer";
                if (txtreste.Text == "0") cbostatut.Text = "Rembourser";
            }

        }

        private void txtmontantpercu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Désolé vous ne pouvez pas effctué cette opération");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //lecode = Convert.ToInt16(dataGridView2.CurrentRow.Cells["id_pret"].Value);
            codeadherent = Convert.ToInt16(dataGridView2.CurrentRow.Cells["code_adherent"].Value);
            string a= Convert.ToString(dataGridView2.CurrentRow.Cells["nom"].Value);
            string b=Convert.ToString(dataGridView2.CurrentRow.Cells["prenom"].Value);
            cboAdhe.Text = a + " " + b;
            string st= Convert.ToString(dataGridView2.CurrentRow.Cells["statut"].Value);
             m1 = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["montant_percu"].Value);
            if (st =="Non rembourser") { 
                Decimal m= Convert.ToDecimal(dataGridView2.CurrentRow.Cells["montant"].Value);
                Decimal T = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["taux_interet"].Value);
                Decimal tap =m+m*(T/100);
                txtmontantapayer.Text = (tap).ToString();
            }
            else
            {
                Decimal m = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["reste_remboursement"].Value);
             /*   Decimal T = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["taux_interet"].Value);
                Decimal tap = m + m * (T / 100);*/
                txtmontantapayer.Text = (m).ToString();
            }
            codepret = Convert.ToString(dataGridView2.CurrentRow.Cells["id_pret"].Value);
            MessageBox.Show(codepret);
            
        }
    }
}
