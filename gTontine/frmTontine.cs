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
    public partial class frmTontine : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode, codecycle;
        public frmTontine()
        {
            InitializeComponent();
        }

        private void frmTontine_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            
            txtLibelle.Text = "";
            txtMontant.Text = "";
           
            if (txtNombre.Text == "1") {
                btnEnregistrer.Enabled = false;
            }
            else {
                btnEnregistrer.Enabled = true;   
            }
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;

            btnSuivant.Visible = true;
            groupBox2.Visible = false;

            txtNombre.Visible = false;
            label1.Visible = false;
            if (ClasseGenerale.gUtilisateurconnecte == "oui")
            {
                btnSuivant.Visible = false;
                groupBox2.Visible = true;

                txtNombre.Visible = true;
                label1.Visible = true;

                a.ChargeTable1(dataGridView1, "SELECT * FROM `tontine` WHERE id_association='" + ClasseGenerale.gIdAssociation + "'");

                txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from tontine WHERE id_association='" + ClasseGenerale.gIdAssociation + "'"));

            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGriview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_tontine"].Value);
            txtLibelle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["libelle"].Value);
            txtMontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);
            

            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            
            requette = ("INSERT INTO tontine VALUES (null,'" + txtLibelle.Text + "','" + txtMontant.Text + "','" + ClasseGenerale.gIdAssociation + "')");
            
            a.ExecuteRequette(requette);
            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            requette = ("Update tontine Set libelle = '" + txtLibelle.Text + "', montant = '" + txtMontant.Text + "' WHERE code_tontine = " + lecode + "");
            a.ExecuteRequette(requette);
            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "delete from tontine   WHERE code_tontine = " + lecode + "";
            a.ResultatRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (txtLibelle.Text == "" || txtMontant.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs vide svp!");
            }
            else
            {
                requette = ("INSERT INTO tontine VALUES (null,'" + txtLibelle.Text + "','" + txtMontant.Text + "','" + ClasseGenerale.gIdAssociation + "')");
                a.ExecuteRequette(requette);
                requette = " SELECT code_tontine  FROM tontine WHERE libelle='" + txtLibelle.Text + "' and montant='" + txtMontant.Text + "' and id_association='" + ClasseGenerale.gIdAssociation + "'";
                ClasseGenerale.gIdTontine = a.ResultatRequette1(requette);
                Chargement();
                MessageBox.Show("Operation effectué avec succes !");
                this.Visible = false;

                frmCycle f = new frmCycle();
                f.ShowDialog();
                this.Close();
            }
           
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
