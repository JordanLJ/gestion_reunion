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
    public partial class frmConsulterpret : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete = "";
        public frmConsulterpret()
        {
            InitializeComponent();
        }

        private void frmConsulterpret_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select a.code_adherent, nom, prenom, montant, e.date_pret, e.statut from adherent a, prets e where a.code_adherent = e.code_adherent and e.id_association = '" + ClasseGenerale.gIdAssociation + "';";
           a.ChargeTable(dataGridView1, requete);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            requete = "select a.code_adherent, nom, prenom, montant, e.date_pret, e.statut from adherent a, prets e where a.code_adherent = e.code_adherent and e.id_association = '" + ClasseGenerale.gIdAssociation + "' and montant='" + txtmontant.Text + "';";
            a.ChargeTable(dataGridView1, requete);
        }
    }
}
