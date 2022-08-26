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
    public partial class frmPret : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete = "";
        string requette= "";
        string b = "'";
        int lecode;
        int codeadherent, codetontine;
        public frmPret()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPret_Load(object sender, EventArgs e)
        {
            chargement();
        }

        void chargement()
        {
            txtmontant.Text = "";
           
            txttauxinteret.Text = "";
            txtmontant.Text = "";
            txtgarantie.Text = "";
            txtadherent.Text = "";
            cboavaliste.Text = "";
            //requete = "select * from prets";
            /*  a.ChargeTable1(dataGridView1, "select * from prets;");
              //a.ChargeTable1(dataGridView1, "select * from prets");*/
            requete = "SELECT code_adherent, nom, prenom FROM adherent WHERE  id_association='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeTable1(dataGridView1, requete);
            charge_montant();

        }

        private void txtarr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            // requete = "insert into prets values('" + cbotontine.Text + "','" + cboadherent.Text + "','"+txtmontant.Text+"','" + txttauxinteret.Text + "')";
            requete = "INSERT INTO prets(id_association, code_adherent, montant, date_pret, taux_interet, garantie, id_avaliste, statut) VALUES ('" + ClasseGenerale.gIdAssociation + "','" + lecode + "','" + txtmontant.Text + "','" + a.date_vers_mysql(datepret.Text) + "','" + txttauxinteret.Text + "','" + txtgarantie.Text + "','" + cboavaliste.Text + "','Non rembourser')";
            a.ExecuteRequette(requete);
            int idop = a.ResultatRequette1("SELECT `id_pret` FROM `prets` WHERE `id_association`= '"+ClasseGenerale.gIdAssociation+"' and  `code_adherent`= '"+lecode+"' and `montant`= '"+txtmontant.Text+"' and `date_pret`= '"+a.date_vers_mysql(datepret.Text)+"' and `taux_interet`= '"+txttauxinteret.Text+"' and `garantie`= '"+txtgarantie.Text+"' and `id_avaliste`= '"+cboavaliste.Text+ "' and `statut`= 'Non rembourser'");
            a.ExecuteRequette(requete);
            MessageBox.Show(requete);

            requete = "INSERT INTO `remboursement`(`code_adherent`, `id_pret`, `id_association`, `montant_payer`, `montant_percu`, `reste_remboursement`, `date_remboursement`) VALUES('" + lecode + "', '" + idop + "', '" + ClasseGenerale.gIdAssociation + "', '" + txtmontant.Text + "', '0', '0', '" + a.date_vers_mysql(datepret.Text) + "')";
            a.ExecuteRequette(requete);
            requette = "INSERT INTO `historique`(`id_operation`, `id_association`, `id_tontine`,`libelle`, `date_operation`, `montant`, `statut_operation`, `garantie`, `avaliste`, `code_adherent`, `code_utilisateur`) VALUES ('" + idop + "', '" + ClasseGenerale.gIdAssociation + "', '" + ClasseGenerale.gIdTontine + "', 'L adherent emprunte de largent', '" + a.date_vers_mysql(datepret.Text) + "','" + txtmontant.Text + "', 'Pret non rembouser',  '" + txtgarantie.Text + "', '" + cboavaliste.Text + "','" + lecode + "',   '" + ClasseGenerale.gCodeUtilisateur + "')";
            a.ExecuteRequette(requette);
            MessageBox.Show(requete);
            chargement();
            MessageBox.Show("enregistrement effectué");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotontine_SelectedIndexChanged_1(object sender, EventArgs e)
        {


           // requette = "SELECT nom, prenom,'" + cbotontine.Text + "'";
            requette = requette + " FROM adherent, cycle, appartenir, tontine WHERE adherent.code_adherent=appartenir.code_adherent AND cycle.code_cycle= appartenir.code_cycle AND tontine.code_tontine = appartenir.code_tontine ";

            //a.ChargeCombo(cboadherent, requette);
           // a.ChargeCombo(cboavaliste, requette);
            //string requette1 = "";


            //requette = "SELECT code_tontine FROM tontine WHERE libelle=" + b + "" + cbotontine.Text + "" + b + ";";

            codetontine = a.ResultatRequette1(requette);
            MessageBox.Show(requette);
        }

        private void cboMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requette1 = "";
            string b = "'";
            //requette1 = "SELECT code_adherent FROM adherent WHERE nom=" + b + "" + cboadherent.Text + "" + b + ";";
            MessageBox.Show(requette1);
            //codeadherent = a.ResultatRequette(requette1);
        }

        private void cboadherent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string requette1 = "";
            string b = "'";
           // requette1 = "SELECT code_adherent FROM adherent WHERE nom=" + b + "" + cboadherent.Text + "" + b + ";";
            MessageBox.Show(requette1);
            codeadherent = a.ResultatRequette1(requette1);
        }

        private void cbotontine_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            //idtontine = a.ResultatRequette(requette1);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_adherent"].Value);
            string n = Convert.ToString(dataGridView1.CurrentRow.Cells["nom"].Value);
            string p = Convert.ToString(dataGridView1.CurrentRow.Cells["prenom"].Value);
            txtadherent.Text = n + " " + p;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboadherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requette1 = "";
            string b = "'";
            //requette1 = "SELECT code_adherent FROM adherent WHERE nom=" + b + "" + cboadherent.Text + "" + b + ";";
            MessageBox.Show(requette1);
            //idadherent = a.ResultatRequette(requette1);
        }

        private void txtmontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void txttauxinteret_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        void charge_montant()
        {/*
            requete = "select * from prets where id_association='" + ClasseGenerale.gIdAssociation + "'";
            if (a.ExecuteRequette(requete) == true)
            {

            }
                requete = "SELECT SUM(montant) FROM prets WHERE id_association='" + ClasseGenerale.gIdAssociation + "'";
            Decimal pret14 = a.ResultatRequette2(requete);
            if (pret14 == 0)
            {
                textBox3.Text = "0";
                requete = "SELECT  SUM(montant) FROM `epargne` WHERE id_association='" + ClasseGenerale.gIdAssociation + "'";
                Decimal pret11 = a.ResultatRequette2(requete);
                textBox2.Text = (pret11).ToString();
            }
            else
            {
                textBox3.Text = (pret14).ToString();
                requete = "SELECT sum(reste_remboursement) FROM remboursement WHERE id_association='" + ClasseGenerale.gIdAssociation + "'";
                decimal oioi = a.ResultatRequette2(requete);

                requete = "SELECT  SUM(montant) FROM `epargne` WHERE id_association='" + ClasseGenerale.gIdAssociation + "'";
                Decimal pret11 = a.ResultatRequette2(requete);
                textBox2.Text = (pret11 - oioi).ToString();
            }*/
        }
    }
}
