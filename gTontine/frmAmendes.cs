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
    public partial class frmAmendes : Form
    {
        string requette, requete = "";
        int lecode, codemotif, codeadherent, codetontine;
        string b = "'";
        AccesDonnees a = new AccesDonnees();
        public frmAmendes()
        {
            InitializeComponent();
        }

        private void frmAmendes_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            txtmontant.Text = "";
            txtidpret.Text = "";
            //txttauxinteret.Text = "";
            //requete = "select * from amendes";
            a.ChargeTable1(dataGridView1, "select * from amendes");

            requete = "select libelle from tontine";
            //requette_datedebut_datefin = "select concat(date_debut,' - ',date_fin) from cycle";
            a.ChargeCombo(cbotontine, requete);

            requete = "select libelle from motif";
            a.ChargeCombo(cboMotif, requete);


            btnfermer.Enabled = true;
            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;             
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTontine_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            requette = "SELECT nom, prenom,'" + cbotontine.Text + "'";
            requette = requette + " FROM adherent, cycle, appartenir, tontine WHERE adherent.code_adherent=appartenir.code_adherent AND cycle.code_cycle= appartenir.code_cycle AND tontine.code_tontine = appartenir.code_tontine ";

            a.ChargeCombo(cboadherent, requette);
            string requette1 = "";
           

            requette = "SELECT code_tontine FROM tontine WHERE libelle=" + b + "" + cbotontine.Text + "" + b + ";";
            
            codemotif = a.ResultatRequette1(requette);
            MessageBox.Show(requette);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            requette = "DELETE FROM  amendes  WHERE id_amendes = " + lecode + "";
            a.ExecuteRequette(requette);

            chargement();
            MessageBox.Show("Suppresion effectué avec succes !");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            //requete = ("UPDATE amendes SET libelle ='" + txtlibellemotif.Text + "', montant ='" + txtmontant.Text + "',  WHERE id_motif = " + lecode + "");
            requete = ("UPDATE amendes SET id_tontine = '" + cbotontine.Text + "', id_adherent = '" + cboadherent.Text + "', montant= '" + txtmontant.Text + "', date= '" + txtdate.Text + "',`id_motif`= '" + cboMotif.Text + "' WHERE id_amendes=" + lecode + "");

            a.ExecuteRequette(requete);

            chargement();
            MessageBox.Show("Modification effectué avec succes !");

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            requete = "select id_motif from motif where libelle=" + b + "" + cboMotif.Text + "" + b + ";";
            codemotif = a.ResultatRequette1(requete);

        }

        private void cboadherent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            requete = "select code_adherent from motif where nom=" + b + "" + cboadherent.Text + "" + b + ";";
            codeadherent = a.ResultatRequette1(requete);
        }

        private void cboadherent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["amende"].Value);
            cbotontine.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tontine"].Value);
            cboadherent .Text = Convert.ToString(dataGridView1.CurrentRow.Cells["adherent"].Value);
            cboMotif.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["motif"].Value);
            txtmontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);
            
            

            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;

            btnSupprimer.Enabled = true;
            btnfermer.Enabled = true;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            

            requete = "INSERT INTO amendes(id_tontine, id_adherent, montant, date, motif) VALUES ('" + codetontine + "','" + codeadherent + "','" + txtmontant.Text + "','" + txtdate.Text + "','" + codemotif + "')";
            a.ExecuteRequette(requete);
            chargement();
            MessageBox.Show("enregistrement effectué");
        }

        private void cbotontine_SelectedIndexChanged(object sender, EventArgs e)
        {

            requette = "SELECT nom, prenom,'" + cbotontine.Text + "'";
            requette = requette + " FROM adherent, cycle, appartenir, tontine WHERE adherent.code_adherent=appartenir.code_adherent AND cycle.code_cycle= appartenir.code_cycle AND tontine.code_tontine = appartenir.code_tontine ";

            a.ChargeCombo(cboadherent, requette);
            string requette1 = "";
            string b = "'";

            requette1 = "SELECT code_tontine FROM tontine WHERE libelle=" + b + "" + cbotontine.Text + "" + b + ";";
            MessageBox.Show(requette1);

        }
    }
}
