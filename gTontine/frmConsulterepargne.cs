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
    public partial class frmConsulterepargne : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete = "";
        public frmConsulterepargne()
        {
            InitializeComponent();
        }

        private void frmConsulterepargne_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select a.code_adherent, nom, prenom, montant, e.date_epargne from adherent a, epargne e where a.code_adherent = e.code_adherent and e.id_association = '"+ClasseGenerale.gIdAssociation+"';";
            a.ChargeTable(dataGridView1, requete);
            requete = "select nom from adherent where id_association='" + ClasseGenerale.gIdAssociation + "'";
            //a.ChargeCombo(cbomembre, requete);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            requete = "select a.code_adherent, nom, prenom, montant, e.date_epargne from adherent a, epargne e where a.code_adherent = e.code_adherent and e.id_association = '" + ClasseGenerale.gIdAssociation + "' and date='"+a.date_vers_mysql(txtdate.Text)+"';";
            a.ChargeTable(dataGridView1, requete);
        }
    }
}
