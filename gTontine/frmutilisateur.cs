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
    public partial class frmutilisateur : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        public frmutilisateur()
        {
            InitializeComponent();
        }

        private void frmutilisateur_Load(object sender, EventArgs e)
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

            a.ChargeTable1(dataGridView1, "select *  from utilisateur where id_association='" + ClasseGenerale.gIdAssociation + "'");


            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from utilisateur where id_association='" + ClasseGenerale.gIdAssociation + "'"));


            txtNom.Text = "";
            txtPrenom.Text = "";
            txtCompte.Text = "";
            txtMotpasse.Text = "";
           
            txtreponse.Text = "";
            cboquestion.Text = "";


            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;

            btnSuivant.Visible = true;
            groupBox2.Visible = false;
            if (ClasseGenerale.gUtilisateurconnecte == "oui")
            {
                btnSuivant.Visible = false;
                groupBox2.Visible = true;
            }
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["id_utilisateur"].Value);
            txtNom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nom"].Value);
            txtPrenom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["prenom"].Value);
            txtCompte.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["compte"].Value);

            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {

            int i = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "' and id_association='" + ClasseGenerale.gIdAssociation + "'");
            while (i == 1)
            {
                MessageBox.Show("Ce Login existe déjà");
                Chargement();
                i = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "'");
            }
            if (txtNom.Text == "" || txtCompte.Text == "" || txtMotpasse.Text == "" || txtreponse.Text == "" || cboquestion.Text == "")
               {
                  MessageBox.Show("Veuillez remplir tout les champs contenant les étoiles rouges!");
               }
             else{
                  requette = ("INSERT INTO utilisateur VALUES (null,'" + ClasseGenerale.gIdAssociation + "','" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtCompte.Text + "','" + a.CryptageMD5(txtMotpasse.Text) + "','" + cboquestion.Text + "','" + a.CryptageMD5(txtreponse.Text) + "')");
                  a.ExecuteRequette(requette);
                  Chargement();
                  MessageBox.Show("Operation effectué avec succes !");
                }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {

            requette = ("Update utilisateur Set nom = '" + txtNom.Text + "', prenom = '" + txtPrenom.Text + "', compte = '" + txtCompte.Text + "'WHERE id_utilisateur = " + lecode + "");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "delete from utilisateur   WHERE id_utilisateur  = " + lecode + "";
            a.ResultatRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            int i = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "' and id_association='" + ClasseGenerale.gIdAssociation + "'");
            while (i == 1)
            {
                MessageBox.Show("Ce Login existe déjà");
                Chargement();
                i = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "' and id_association='" + ClasseGenerale.gIdAssociation + "'");
            }
            if (txtNom.Text == "" || txtCompte.Text == "" || txtMotpasse.Text == "" || txtreponse.Text == "" || cboquestion.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs contenant les étoiles rouges!");
            }
            else
            {
                requette = ("INSERT INTO utilisateur VALUES (null,'" + ClasseGenerale.gIdAssociation + "','" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtCompte.Text + "','" + a.CryptageMD5(txtMotpasse.Text) + "','" + cboquestion.Text + "','" + a.CryptageMD5(txtreponse.Text) + "')");
                a.ExecuteRequette(requette);
                Chargement();
                MessageBox.Show("Operation effectué avec succes !");
            }
            MessageBox.Show("Félicitation vous pouvez dès à présent vous connectez et gérer votre Association!");
            this.Visible = false;
            this.Close();

        }
    }
}
