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
    public partial class frmPlanification_rotative_des_bénéficiaires : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        string requette_nom_prenom = "";
        string requette_libelle = "";
        string nom = "";
        int codeadherent, codeCycle,u,u1;
        public frmPlanification_rotative_des_bénéficiaires()
        {
            InitializeComponent();
        }

        private void frmPlanification_rotative_des_bénéficiaires_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            // a.ChargeTable1(dataGridView1, "SELECT code_pla,planification.code_adherent,  planification.code_cycle, concat(nom,'  ',prenom) NomComplet, lib_cycle,date,montant,rang FROM planification, cycle, adherent WHERE planification.code_cycle = cycle.code_cycle AND planification.code_adherent = adherent.code_adherent ");
            a.ChargeTable1(dataGridView1, "SELECT `code_adherent`, `nom_membre`, `rang`, `date_bouffe` FROM `membre_tontine` WHERE `code_tontine`='"+ClasseGenerale.gIdTontine+"'");
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            requette_libelle = "select lib_cycle from cycle where id_association='"+ClasseGenerale.gIdAssociation+"'";
            a.ChargeCombo(cboCycle, requette_libelle);
            requette_libelle = "SELECT `libelle` FROM `tontine` WHERE  `id_association`='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeCombo(cbotontine, requette_libelle);

            txtRang.Text = "";
            //txtMontant.Text = "";
            dtpDate.Text = "";
           


            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from planification  "));

            btnEnregistrer.Enabled = true;
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
            
        }


     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_adherent"].Value);
            cboAdhe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nom_membre"].Value);
            nom = Convert.ToString(dataGridView1.CurrentRow.Cells["nom_membre"].Value);
            // cboCycle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["rang"].Value);
            dtpDate.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_bouffe"].Value);
            //txtMontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);
            txtRang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["rang"].Value);



            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom)= '" + cboAdhe.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");


            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = false;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            /*Je commente son code je mets ma part
            codeadherent = a.ResultatRequette1("SELECT code_adherent FROM adherent WHERE concat(nom,'  ',prenom)  = '" + cboAdhe.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");
            requette = ("INSERT INTO planification VALUES (NULL," + codeadherent + "," + codeCycle + ",'" + dtpDate.Text + "','" + txtMontant.Text + "','" + txtRang.Text + "')");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
            */

        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            // requette = "UPDATE planification SET code_adherent=" + codeadherent + ",code_cycle=" + codeCycle + " ,date = '" + dtpDate.Text + "',montant='" + txtMontant.Text + "', rang = '" + txtRang.Text + "' WHERE code_pla =" + lecode + "";
             requette = "UPDATE membre_tontine SET date_bouffe = '" + dtpDate.Text + "', rang = '" + txtRang.Text + "' WHERE nom_membre ='" + cboAdhe.Text + "'";

            a.ExecuteRequette(requette);
            MessageBox.Show("Opération éffectuée avec succès !");
            charge_apres_modif();
        }
        void charge_apres_modif()
        {
            requette = "Select * from membre_tontine where code_tontine='" + u1 + "' and code_cycle='" + u + "'";
            a.ChargeTable1(dataGridView1, requette);
            txtRang.Text = "";
            //txtMontant.Text = "";
            dtpDate.Text = "";
            cboAdhe.Text = "";
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "DELETE FROM planification WHERE code_pla =" + lecode + "";
            a.ExecuteRequette(requette);

            Chargement();

            MessageBox.Show("Opération éffectuée avec succès !");
        }

        private void cboCycle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
             u = a.ResultatRequette1("select code_cycle from cycle where lib_cycle='" + cboCycle.Text + "'");
             u1 = a.ResultatRequette1("SELECT `code_tontine` FROM `tontine` WHERE `libelle`='" + cbotontine.Text + "'");
            requette = "Select * from membre_tontine where code_tontine='" + u1 + "' and code_cycle='" + u + "'";
            a.ChargeTable1(dataGridView1, requette);
            MessageBox.Show(requette);
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
