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
    public partial class frmCycle : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
      

        public frmCycle()
        {
            InitializeComponent();
        }
        void Chargement()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            //requete =                     "select *  from prets";


            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from cycle"));

            txtLibelle.Text = "";
            dtpDateDebut.Text = "";
            dtpDateFin.Text = "";
            txtnombrepart.Text = "";
            txtdateprecise.Visible = false;
            label7.Visible = false;

            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;

            btnSuivant.Visible = true;
            groupBox1.Visible = false;

            txtNombre.Visible = false;
            label1.Visible = false;
            if (ClasseGenerale.gUtilisateurconnecte == "oui")
            {
                btnSuivant.Visible = false;
                groupBox1.Visible = true;

                txtNombre.Visible = true;
                label1.Visible = true;
                a.ChargeTable1(dataGridView1, "select *  from cycle where id_association='" + ClasseGenerale.gIdAssociation + "'");

            }
        }


      
        
        private void dataGriview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        

        private void frmCycle_Load(object sender, EventArgs e)
        {
            Chargement();
        }

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            int i = a.ResultatRequette1("SELECT count(*) FROM cycle WHERE lib_cycle= '" + txtLibelle.Text + "' and id_association='" + ClasseGenerale.gIdAssociation + "'");
            if (i == 1)
            {
                MessageBox.Show("Ce cycle existe deja!");
            }
            else
            { 
                requette = ("INSERT INTO cycle VALUES (null,'" + txtLibelle.Text + "','" + ClasseGenerale.gIdAssociation + "','" + txtnombrepart.Text + "','" + dtpDateDebut.Text + "','" + dtpDateFin.Text + "','" + cbofrequencebouffe.Text + "')");

                a.ExecuteRequette(requette);
                Chargement();
                MessageBox.Show("Operation effectué avec succes !");
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            requette = ("Update cycle Set lib_cycle = '" + txtLibelle.Text + "', Nombre_de_part = '" + txtnombrepart.Text + "', date_debut = '" + dtpDateDebut.Text + "', date_fin = '" + dtpDateFin.Text + "', frequence_bouffe = '" + cbofrequencebouffe.Text + "' WHERE code_cycle = " + lecode + "");
            
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "delete from cycle   WHERE code_cycle = " + lecode + "";
            a.ResultatRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_cycle"].Value);
            txtLibelle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["lib_cycle"].Value);
            dtpDateDebut.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_debut"].Value);
            dtpDateFin.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_fin"].Value);
            cbofrequencebouffe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["frequencebouffe"].Value);
            txtnombrepart.Text= Convert.ToString(dataGridView1.CurrentRow.Cells["Nombrepart"].Value);

            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            int j;
            /* verifier si la date de fin est supérieur à la date de début
            if(dtpDateFin.Text <= dtpDateDebut.Text) { }
            */
        }

        private void cbofrequencebouffe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbofrequencebouffe.Text == "Date précise du mois(à préciser)") {
                txtdateprecise.Visible = true;
                label7.Visible = true;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (txtLibelle.Text == "" || txtNombre.Text == "" || txtnombrepart.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs SVP!");
            }
            else
            {
                requette = ("INSERT INTO cycle VALUES (null,'" + txtLibelle.Text + "','" + ClasseGenerale.gIdAssociation + "','" + txtnombrepart.Text + "','" + dtpDateDebut.Text + "','" + dtpDateFin.Text + "','" + cbofrequencebouffe.Text + "')");
                a.ExecuteRequette(requette);
                Chargement();
                MessageBox.Show("Operation effectué avec succes !");
                this.Visible = false;

                frmutilisateur f = new frmutilisateur();
                f.ShowDialog();
                this.Close();
            }

            
        }

        private void txtnombrepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }
    }
}
