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
    public partial class frmPlanification : Form
    {


        AccesDonnees a = new AccesDonnees();
        string requette = "";

        public frmPlanification()
        {
            InitializeComponent();
        }

        private void frmPlanification_Load(object sender, EventArgs e)
        {

            a.ChargeCombo(cboTontine, "SELECT libelle FROM tontine");
            a.ChargeCombo(cboCycle, "SELECT lib_cycle FROM cycle");


            cboTontine.Items.Add("");
            cboCycle.Items.Add("");

            //mon code
            //je charge le dat    grid view avec les noms des adherents et
            /*requette = "select";
            a.ChargeTable1(dataGridView1, requette);*/
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            //je met sa requete en commentaire pour écrire la mienne
            requette = "SELECT nom, prenom, rang,date,planification.montant,'" + cboTontine.Text + "','" + cboCycle.Text + "'";
            requette = requette + " FROM adherent, cycle, appartenir, tontine,planification WHERE adherent.code_adherent=appartenir.code_adherent AND cycle.code_cycle= appartenir.code_cycle AND tontine.code_tontine = appartenir.code_tontine AND adherent.code_adherent= planification.code_adherent";

            if (cboTontine.Text != "") requette = requette + " and  libelle = '" + cboTontine.Text + "'";
            if (cboCycle.Text != "") requette = requette + " and lib_cycle = '" + cboCycle.Text + "' ";
            // if (cboDated.Text != "") requette = requette + " and date_debut = '" + cboDated.Text + "' ";
            // if (cboDateF.Text != "") requette = requette + " and date_fin = '" + cboDateF.Text + "' ";
            requette = requette + " order by 2,3 ";
            //



            a.ChargeTable1(dataGridView1, requette);
            lblEffectif.Text = Convert.ToString(dataGridView1.RowCount - 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DataSet sDs;

            ClasseGenerale.gNomEtatImpression = "etat_planification";

            sDs = a.RecuperationTable(requette);
            ClasseGenerale.dsPrint = sDs.Copy();
            frmImpression f = new frmImpression();
            f.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
