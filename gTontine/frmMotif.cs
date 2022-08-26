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
    public partial class frmMotif : Form
    {
        string requete= "";
        int lecode;
        AccesDonnees a = new AccesDonnees();
        public frmMotif()
        {
            InitializeComponent();
        }

        private void frmMotif_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            txtlibellemotif.Text = "";
            txtmontant.Text = "";
            requete = "select * from motif";
            a.ChargeTable1(dataGridView1, requete);

            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnfermer.Enabled = true;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            requete = "INSERT INTO motif(libelle, montant) VALUES('" + txtlibellemotif.Text + "','" + txtmontant.Text + "')";
            a.ExecuteRequette(requete);
            chargement();
            MessageBox.Show("enregistrement effectué");
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            requete = "delete from motif   WHERE id_motif = " + lecode + "";
            a.ResultatRequette(requete);

            chargement();
            MessageBox.Show("Suppresion effectué avec succes !");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Motif"].Value);
            txtlibellemotif.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["libelle"].Value);
            txtmontant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["montant"].Value);


            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnfermer.Enabled = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            //requete = "UPDATE motif SET libelle ='" + txtlibellemotif.Text + "', montant ='" + txtmontant.Text + "',  WHERE id_motif = " + lecode + "";
            requete = "UPDATE motif SET libelle = '" + txtlibellemotif.Text + "', montant = '" + txtmontant.Text + "' WHERE id_motif = " + lecode + "";
            a.ExecuteRequette(requete);

            chargement();
            MessageBox.Show("Modification effectué avec succes !");
        }
    }
    }

