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
    public partial class frmFonddecaisse : Form
    {
        string requette = "";
        int lecode;
        string tontine, montant1, date = "";
        AccesDonnees a = new AccesDonnees();
        public frmFonddecaisse()
        {
            InitializeComponent();
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            requette = "DELETE FROM  fonddecaisse  WHERE id_fonddecaisse = " + lecode + "";
            a.ExecuteRequette(requette);

            chargement();
            MessageBox.Show("Suppresion effectué avec succes !");
        }

        void chargement()
        {
            txtadherent.Text = "";
            //cbotontine.Text = "";
            txtmontant.Text = "";
            txtdatefond.Text = "";
            //cboadherent.Text = "";
            
            //a.ChargeTable1(dataGridView1, "select a.code_adherent, nom, prenom, montant, f.date_fond from adherent a, fonddecaisse f where a.code_adherent=f.code_adherent and f.id_association='"+ClasseGenerale.gIdAssociation+"';");
            a.ChargeTable1(dataGridView1, "select code_adherent, nom, prenom from adherent  where id_association = '" + ClasseGenerale.gIdAssociation + "'");

            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;

            btnSupprimer.Enabled = false;
            btnfermer.Enabled = true;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //requette = ("INSERT INTO fonddecaisse VALUES ('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtTel.Text + "','" + txtAdresse.Text + "','" + cboSituMat.Text + "','" + cboPays.Text + "','" + dtpDateNaiss.Text + "','" + txtEmail.Text + "','" + cboSexe.Text + "','" + dtpDateAdhesion.Text + "','" + txtNoCNI.Text + "','" + btnPhoto.Text + "')");
            requette = ("INSERT INTO fonddecaisse(id_association, code_adherent, montant, date_fond) VALUES('" + ClasseGenerale.gIdAssociation + "', '" + lecode + "', '" + txtmontant.Text + "', '" + a.date_vers_mysql(txtdatefond.Text) + "')");
            a.ExecuteRequette(requette);

            int idop = 1;
            //requette = "INSERT INTO `historique`(`id_operation`, `id_association`, `libelle`, `date_operation`, `montant`, `statut_operation`,  `code_adherent`, `code_utilisateur`) VALUES ('" + idop + "', '" + ClasseGenerale.gIdAssociation + "', '" + ClasseGenerale.gIdTontine + "', 'L adherent prêt de l'argent', '" + a.date_vers_mysql(datepret.Text) + "','" + txtmontant.Text + "', 'Pret non rembouser',  '" + txtgarantie.Text + "', '" + cboavaliste.Text + "','" + lecode + "',   '" + ClasseGenerale.gCodeUtilisateur + "')";
            requette = "INSERT INTO `historique`( `id_operation`, `id_association`, `libelle`, `date_operation`, `montant`, `statut_operation`,  `code_adherent`, `code_utilisateur`) VALUES ('" + idop + "','" + ClasseGenerale.gIdAssociation + "','Fond de caisse : ladherent paye son fond de caisse', '" + a.date_vers_mysql(txtdatefond.Text) + "', '" + txtmontant.Text + "', 'payer fond de caisse','" + lecode + "','" + ClasseGenerale.gCodeUtilisateur + "')";
            a.ExecuteRequette(requette);
            MessageBox.Show(requette);

           // requette = "INSERT INTO `historique`(`id_operation`, `id_association`, `id_tontine`,`libelle`, `date_operation`, `montant`, `montant_percu`, `reste`, `statut_operation`, `code_adherent`, `code_utilisateur`) VALUES ('" + idop + "', '" + ClasseGenerale.gIdAssociation + "', '" + ClasseGenerale.gIdTontine + "', 'Rembousement dette', '" + a.date_vers_mysql(txtdaterembourse.Text) + "','" + txtmontantapayer.Text + "', '" + txtmontantpercu.Text + "', '" + txtreste.Text + "', '" + cbostatut.Text + "', '" + lecode + "',   '" + ClasseGenerale.gCodeUtilisateur + "')";
            //a.ExecuteRequette(requette);

            chargement();
            
        }

        private void cbotontine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFonddecaisse_Load(object sender, EventArgs e)
        {
            chargement();
        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            //requette = ("UPDATE fonddecaisse SET id_tontine='" + cbotontine.Text + "', id_adherent='" + cboadherent.Text + "', montant='" + txtmontant.Text + "',`date`='" + txtdatefond.Text + "' WHERE id_fonddecaisse=" + txtidfond.Text + "");
            a.ExecuteRequette(requette);


            chargement();
            MessageBox.Show("Modification effectué avec succes !");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_adherent"].Value);
            /*cbotontine.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tontine"].Value);
            */
            string n = Convert.ToString(dataGridView1.CurrentRow.Cells["nom"].Value);
            string p = Convert.ToString(dataGridView1.CurrentRow.Cells["prenom"].Value);
            txtadherent.Text = n + " " + p;
           // txtdatefond.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_fond"].Value);
           // txtmontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);



            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;

            btnSupprimer.Enabled = false;
            btnfermer.Enabled = true;
        }
    }
}
