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
    public partial class frmConsulterRemboursement : Form
    {
        string requete = "";
        AccesDonnees a = new AccesDonnees();
        public frmConsulterRemboursement()
        {
            InitializeComponent();
        }

        private void frmConsulterRemboursement_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select a.code_adherent, nom, prenom, montant, e.date_pret, e.statut, r.montant_payer, r.montant_percu, r.reste_remboursement, r.date_remboursement from adherent a, prets e, remboursement r where a.code_adherent = e.code_adherent and e.id_pret=r.id_pret and e.id_association = '" + ClasseGenerale.gIdAssociation + "';";
            a.ChargeTable(dataGridView1, requete);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
