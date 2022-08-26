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
    public partial class frmConsultationfondecaisse : Form
    {
        AccesDonnees a = new AccesDonnees();

        string requete = "";
        public frmConsultationfondecaisse()
        {
            InitializeComponent();
        }

        private void frmConsultationfondecaisse_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {

            requete = "select a.code_adherent, nom, prenom, montant, f.date_fond from adherent a, fonddecaisse f where a.code_adherent = f.code_adherent and f.id_association = '" + ClasseGenerale.gIdAssociation + "';";
            a.ChargeTable(dataGridView1, requete);

            
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            requete = "select a.code_adherent, nom, prenom, montant, f.date_fond from adherent a, fonddecaisse f where a.code_adherent = f.code_adherent and f.id_association = '" + ClasseGenerale.gIdAssociation + "' and date_fond='" + a.date_vers_mysql(txtdate.Text) + "';";
            a.ChargeTable(dataGridView1, requete);

        }
    }
}
