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
    public partial class frmAssociation : Form
    {
        string requette, lecode= "";
        AccesDonnees a = new AccesDonnees();
        public frmAssociation()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            requette = "SELECT count(*) FROM association";
            int z = a.ResultatRequette1(requette);
            if (z == 1)
            {
                MessageBox.Show("Désolé vous ne pouvez que gérer une seule association");
            }
            else { 
            requette = "INSERT INTO association(id_association, `nom`, `siege_social`, `caracteristique`) VALUES ('null','"+txtnomasso.Text+"','"+txtsiegesocial.Text+"','"+txtcaracteristique.Text+"')";
            a.ExecuteRequette(requette);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Désolé vous n'avez pas le droit d'effectuer cette opération!");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            requette = "UPDATE association SET Nom='"+txtnomasso.Text+"', siege_social='"+txtsiegesocial.Text+"', caracteristique='"+txtcaracteristique.Text+"' WHERE id_association='"+lecode+"'";
            a.ExecuteRequette(requette);
            chargement();

        }
        void chargement()
        {
            

            txtcaracteristique.Text = "";
            txtnomasso.Text = "";
            txtsiegesocial.Text = "";
            
            btnEnregistrer.Enabled =false;
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
                requette = "select * from association where id_association='" + ClasseGenerale.gIdAssociation + "'";
                a.ChargeTable(dataGridView1, requette);
            }
        }
        private void frmAssociation_Load(object sender, EventArgs e)
        {
            chargement();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            
            if (txtnomasso.Text=="" || txtcaracteristique.Text=="" || txtsiegesocial.Text=="")
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                requette = "INSERT INTO association(id_association, `nom`, `siege_social`, `caracteristique`) VALUES ('null','" + txtnomasso.Text + "','" + txtsiegesocial.Text + "','" + txtcaracteristique.Text + "')";
                a.ExecuteRequette(requette);
                requette = "SELECT id_association FROM association WHERE  nom='" + txtnomasso.Text + "' and siege_social='" + txtsiegesocial.Text + "' and caracteristique='" + txtcaracteristique.Text + "'";
                ClasseGenerale.gIdAssociation = a.ResultatRequette1(requette);
                this.Visible = false;

                frmTontine f = new frmTontine();
                f.ShowDialog();
                this.Close();
            }
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          lecode = Convert.ToString(dataGridView1.CurrentRow.Cells["id_association"].Value);
          txtcaracteristique.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["caracteristique"].Value);
          txtnomasso.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nom"].Value);
          txtsiegesocial.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["siege_social"].Value);
        }
    }
}
