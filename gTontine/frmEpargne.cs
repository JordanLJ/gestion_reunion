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
    public partial class frmEpargne : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete, requete1 = "";
        int lecode;
        public frmEpargne()
        {
            InitializeComponent();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //requette = ("INSERT INTO fonddecaisse VALUES ('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtTel.Text + "','" + txtAdresse.Text + "','" + cboSituMat.Text + "','" + cboPays.Text + "','" + dtpDateNaiss.Text + "','" + txtEmail.Text + "','" + cboSexe.Text + "','" + dtpDateAdhesion.Text + "','" + txtNoCNI.Text + "','" + btnPhoto.Text + "')");
            requete = "INSERT INTO epargne(id_epargne, code_adherent, id_association, montant, date_epargne) VALUES('null', '" + lecode + "', '" + ClasseGenerale.gIdAssociation + "', '" + txtmontant.Text + "', '" + a.date_vers_mysql(txtdateepargne.Text) + "')";
            a.ExecuteRequette(requete);
            requete1 = "INSERT INTO `historique`(`id_operation`, `id_association`,  `libelle`, `date_operation`, `montant`,  `code_adherent`, `code_utilisateur`) VALUES('1', '" + ClasseGenerale.gIdAssociation + "', 'Epargne: ladherent epargne un montant', '" + a.date_vers_mysql(txtdateepargne.Text) + "','" + txtmontant.Text + "', '" + lecode + "', '" + ClasseGenerale.gCodeUtilisateur + "')";
            a.ExecuteRequette(requete1);
            MessageBox.Show(requete1);
            chargement();

        }
        void chargement()
        {
           /* cbotontine.Text = "";
            cboadherent.Text = "";
            txtidepargne.Text = "";*/
            txtmontant.Text = "";
            txtadherent.Text = "";

            a.ChargeTable1(dataGridView1, "select code_adherent, nom, prenom from adherent  where id_association = '" + ClasseGenerale.gIdAssociation + "'");

            btnajouter.Enabled = true;
            btnfermer.Enabled = true;
            btnmodifier.Enabled = false;
            btnsupprimer.Enabled = false;
      
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            requete = "DELETE FROM  epargne  WHERE id_epargne = " + lecode + "";
            a.ExecuteRequette(requete);

            chargement();
            MessageBox.Show("Suppresion effectué avec succes !");
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            //requete = "UPDATE epargne SET id_adherent='" + cboadherent.Text + "',id_tontine='" + cbotontine.Text + "',montant='" + txtmontant.Text + "',date='" + txtdateepargne.Text + "' WHERE id_epargne='" + txtidepargne.Text + "'";
            a.ExecuteRequette(requete);

            chargement();
            MessageBox.Show("Modification effectué avec succès !");

        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEpargne_Load(object sender, EventArgs e)
        {
            chargement();
        }

        private void cbotontine_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            requette = "SELECT nom, prenom,'" + cbotontine.Text + "'";
            requette = requette + " FROM adherent, cycle, appartenir, tontine WHERE adherent.code_adherent=appartenir.code_adherent AND cycle.code_cycle= appartenir.code_cycle AND tontine.code_tontine = appartenir.code_tontine ";

            a.ChargeCombo(cboadherent, requette);
            a.ChargeCombo(cboavaliste, requette);
            //string requette1 = "";


            requette = "SELECT code_tontine FROM tontine WHERE libelle=" + b + "" + cbotontine.Text + "" + b + ";";

            codetontine = a.ResultatRequette1(requette);
            MessageBox.Show(requette);*/
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_adherent"].Value);
            /*cbotontine.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tontine"].Value);
            */
            string n = Convert.ToString(dataGridView1.CurrentRow.Cells["nom"].Value);
            string p = Convert.ToString(dataGridView1.CurrentRow.Cells["prenom"].Value);
            txtadherent.Text = n + " " + p;
           /* txtdateepargne.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_epargne"].Value);
            txtmontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);*/
            
            btnajouter.Enabled = true;
            btnmodifier.Enabled = false;

            btnsupprimer.Enabled = false;
            btnfermer.Enabled = true;
        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
