using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gTontine
{
    public partial class frmConnexion : Form
    {
        AccesDonnees a = new AccesDonnees();
        ClasseGenerale b = new ClasseGenerale();
        
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
           // Process.Start(@"C:\xampp\apache_start1.bat");
         //  Process.Start(@"C:\xampp\apache_start.bat");

          // Process.Start(@"C:\xampp\mysql_start.bat");
          
            //Environment.Exit(0);

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            int i = a.ResultatRequette1("SELECT count(*) FROM utilisateur WHERE compte= '" + txtCompte.Text + "' AND mot_de_passe = '" + a.CryptageMD5(txtMotpasse.Text) + "'");
            if (i == 0)
            {
                txtCompte.Text = "";
                txtMotpasse.Text = "";
                MessageBox.Show("Compte ou mot de passe incorrect !");
            }
            else
            {
                int j = a.ResultatRequette1("select count(*) from utilisateur where compte='" + txtCompte.Text + "' and mot_de_passe ='" + a.CryptageMD5(txtMotpasse.Text) + "'");
                if (j == 0)
                {
                    MessageBox.Show("Votre compte est bloqué; contacter l'administrateur !");
                }
                else
                {
                   int idasso = a.ResultatRequette1("select id_association from utilisateur where compte='" + txtCompte.Text + "'");
                   string nomasso= a.ResultatRequette("select nom from association where id_association='" + idasso + "'");
                    // select libelle from tontine where code_tontine = '5';
                    ClasseGenerale.gNomAssociation = nomasso;
                    ClasseGenerale.gIdAssociation = idasso;

                    int idtontine = a.ResultatRequette1("select code_tontine from tontine where id_association='" + idasso + "'");
                    string nomtontine = a.ResultatRequette("select libelle from tontine where code_tontine='" + idtontine + "'");
                    ClasseGenerale.gNomTontine = nomtontine;
                    ClasseGenerale.gIdTontine = idtontine;
                    ClasseGenerale.gUtilisateurconnecte = "oui";

                    // MessageBox.Show(c,"le nom de l'association est:");
                    this.Visible = false;
                    
                    frmPrincipal f = new frmPrincipal();
                    f.ShowDialog();

                    this.Close();
                    //this.Visible = false;
                 
                }

            }         
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmMdpoublie f = new frmMdpoublie();
            f.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClasseGenerale.gUtilisateurconnecte = "non";
            frmAssociation fd = new frmAssociation();
            fd.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
