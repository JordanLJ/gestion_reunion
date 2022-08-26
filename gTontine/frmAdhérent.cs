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
    public partial class frmAdhérent : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requette = "";
        int lecode;
        int lecode1;
        string requette_libelle = "";
        string requette_tontine = "";
        string imglocation = "";
        int codeTontine, codeCycle, codeadherent;
        int codecyle1, codeTontine1, partrestantes;
        //int txtNbrePart;

        public frmAdhérent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chargement();
        }

        void Chargement()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEnregistrer, "Enregistrer");
            tooltip.SetToolTip(btnEnregistrer1, "Enregistrer");
            tooltip.SetToolTip(btnModifier, "Modifier");
            tooltip.SetToolTip(btnSupprimer, "Supprimer");
            tooltip.SetToolTip(btnFermer, "Fermer");

            requette_libelle = "select lib_cycle from cycle where id_association='" + ClasseGenerale.gIdAssociation + "'";
            //requette_datedebut_datefin = "select concat(date_debut,' - ',date_fin) from cycle";
            a.ChargeCombo(cboCycle, requette_libelle);
            requette_tontine = "select libelle from tontine where id_association='" + ClasseGenerale.gIdAssociation + "'";
            a.ChargeCombo(cboTontine, requette_tontine);

            ChargementTontineCycleAdherent(0);
            // a.ChargeTable1(dataGridView1, "select code_adherent,adherent.numero_compte, nom, prenom, tel, adresse, sit_mat, pays, date_naiss, email, sexe, date_adh, numCNI from adherent,compte WHERE adherent.numero_compte=compte.numero_compte ");
            a.ChargeTable1(dataGridView1, "SELECT * FROM adherent where id_association='" + ClasseGenerale.gIdAssociation + "'");
            // a.ChargeTable1(dataGridView1, "select code_appartenir, appartenir.code_tontine, appartenir.code_cycle,appartenir.code_adherent, lib_cycle, nom, prenom, tel, adresse, sit_mat, pays, date_naiss, email, sexe, date_adh, numCNI, nbre_part FROM adherent,appartenir, tontine, cycle WHERE appartenir.code_tontine = tontine.code_tontine AND appartenir.code_cycle = cycle.code_cycle AND appartenir.code_adherent = adherent.code_adherent AND tontine.libelle = '" + cboTontine + "'");

            txtNombre.Text = Convert.ToString(a.ResultatRequette1("select count(*) from adherent where id_association='" + ClasseGenerale.gIdAssociation + "'"));
              

            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtAdresse.Text = "";
            cboSituMat.Text = "";
            cboPays.Text = "";
            dtpDateNaiss.Text = "";
            txtEmail.Text = "";
            cboSexe.Text = "";
            dtpDateAdhesion.Text = "";
            txtNoCNI.Text = "";



            btnEnregistrer1.Enabled = true;
            btnEnregistrer.Enabled = true;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnSupprimer1.Enabled = false;


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGriview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["code_adherent"].Value);
            txtNom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nom"].Value);
            txtPrenom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["prenom"].Value);
            dtpDateNaiss.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_naiss"].Value);
            txtTel.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tel"].Value);
            cboPays.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["pays"].Value);
            txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["email"].Value);
            dtpDateAdhesion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["date_adh"].Value);
            txtAdresse.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["adresse"].Value);
            cboSexe.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["sexe"].Value);
            cboSituMat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["sit_mat"].Value);
            txtNoCNI.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["numCNI"].Value);


            btnEnregistrer.Enabled = false;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;

            ChargementTontineCycleAdherent(lecode);

        }

        void ChargementTontineCycleAdherent(int codea)
        {
            a.ChargeTable1(dataGridView2, "SELECT code_appartenir,lib_cycle,libelle,nbre_part FROM appartenir,cycle,tontine WHERE appartenir.code_cycle=cycle.code_cycle AND appartenir.code_tontine=tontine.code_tontine and code_adherent=" + codea + "");

        }


        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSupprimer1_Click(object sender, EventArgs e)
        {
            requette = "delete from  appartenir  WHERE code_appartenir = " + lecode1 + "";
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbpAppartenir_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGriview2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lecode1 = Convert.ToInt16(dataGridView2.CurrentRow.Cells["code_appartenir"].Value);
            cboCycle.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["lib_cycle"].Value);
            cboTontine.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["libelle"].Value);
            txtNbrePart.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["nbre_part"].Value);
            //txtRang.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["rang"].Value);

            codeTontine = a.ResultatRequette1("SELECT code_tontine FROM tontine WHERE libelle = '" + cboTontine.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");

            btnEnregistrer1.Enabled = false;
            btnSupprimer1.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
                openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                {
                    imglocation = openFileDialog1.FileName.ToString();
                    ptbPhoto.ImageLocation = imglocation;
                }


                {
                    try
                    {
                        //if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            // using (myStream)
                            {
                                // Insert code to read the stream here.

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            
            if (txtNom.Text == "" || dtpDateNaiss.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs contenant les étoiles rouges!");
            }
            else
            {
                //codeadherent = a.ResultatRequette1 ("SELECT code_adherent FROM adherent WHERE code_adherent = null");
                int L = a.ResultatRequette1("select lpad(count(*) + 1, 5, '0') from adherent;");
                int L1 = a.ResultatRequette1("select code_tontine from tontine where libelle= '" + cboTontine.Text + "';");
                // string code_en = "CA" + L;
                requette = ("INSERT INTO adherent VALUES ('" + L + "','" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtTel.Text + "','" + txtAdresse.Text + "','" + cboSituMat.Text + "','" + cboPays.Text + "','" + dtpDateNaiss.Text + "','" + txtEmail.Text + "','" + cboSexe.Text + "','" + dtpDateAdhesion.Text + "','" + txtNoCNI.Text + "','" + btnPhoto.Text + "','" + ClasseGenerale.gIdAssociation + "')");
                a.ExecuteRequette(requette);
                //requette =("CALL creation_numero_compte ('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtTel.Text + "','" + txtAdresse.Text + "','" + cboSituMat.Text + "','" + cboPays.Text + "','" + dtpDateNaiss.Text + "','" + txtEmail.Text + "','" + cboSexe.Text + "','" + dtpDateAdhesion.Text + "','" + txtNoCNI.Text + "','" + btnPhoto.Text + "')");


                int p = a.ResultatRequette1("select code_cycle from cycle where lib_cycle='" + cboCycle.Text + "'");
                int nombrepart = a.ResultatRequette1("SELECT nombre_de_part FROM cycle WHERE code_cycle='" + p + "'");
                int nombremembrepartcipe = a.ResultatRequette1("SELECT count(nom_membre) FROM membre_tontine WHERE code_cycle='" + p + "'");
                partrestantes = nombrepart - nombremembrepartcipe;
                
                int v = 0;
                if (txtNbrePart.Text == "1") v = 1;
                if (txtNbrePart.Text == "2") v = 2;
                if (txtNbrePart.Text == "3") v = 3;
                if (txtNbrePart.Text == "4") v = 4;
                if (txtNbrePart.Text == "5") v = 5;
                if (v > 8)
                {
                    MessageBox.Show("le Nombre de part restantes dans cette tontine est!");
                }
                else
                {
                    for (int i = 1; i <= v; i++)
                    {
                        string nommenbre = txtNom.Text + " " + txtPrenom.Text + i;
                        int coder = a.ResultatRequette1("SELECT `code_adherent` FROM `adherent` WHERE `nom`='" + txtNom.Text + "' AND `prenom`='" + txtPrenom.Text + "' AND `tel`='" + txtTel.Text + "' and `id_association`='" + ClasseGenerale.gIdAssociation + "'");
                        requette = "INSERT INTO membre_tontine(code_adherent, nom_membre, code_tontine, code_cycle) VALUES('" + L + "', '" + nommenbre + "', '" + codeTontine1 + "', '" + codecyle1 + "')";
                        a.ExecuteRequette(requette);
                        for (int j = 1; j <= nombrepart; j++)
                        {
                            int montantcoti = a.ResultatRequette1("select montant from tontine where libelle='" + cboTontine.Text + "'");
                            requette = "INSERT INTO `paye_tontine`( `nom_membre`, `montant_payer`, `statut_paye`, `date_paye_tontine`, `code_tontine`, `code_cycle`, `id_association`, `rang`) VALUES ('" + nommenbre + "','" + montantcoti + "','Non payer','" + a.date_vers_mysql(dtpDateAdhesion.Text) + "', '" + codeTontine1 + "', '" + codecyle1 + "','" + ClasseGenerale.gIdAssociation + "','" + j + "')";
                            a.ExecuteRequette(requette);
                        }
                        MessageBox.Show(requette);
                    }
                }
                Chargement();
                MessageBox.Show("Operation effectué avec succes !");
                a.Mouchard(ClasseGenerale.gCodeUtilisateur, "Ajout du client " + txtNom.Text);
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {

            requette = ("UPDATE adherent SET nom ='" + txtNom.Text + "', prenom ='" + txtPrenom.Text + "', photo ='', tel='" + txtTel.Text + "', adresse ='" + txtAdresse.Text + "', sit_mat  ='" + cboSituMat.Text + "', pays ='" + cboPays.Text + "', date_naiss ='" + dtpDateNaiss.Text + "', email ='" + txtEmail.Text + "', sexe ='" + cboSexe.Text + "', date_adh ='" + dtpDateAdhesion.Text + "', numCNI ='" + txtNoCNI.Text + "'  WHERE code_adherent = " + lecode + "");
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            requette = "DELETE FROM  adherent  WHERE code_adherent = " + lecode + "";
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCycle_SelectedIndexChanged(object sender, EventArgs e)
        {
            codecyle1 = a.ResultatRequette1("SELECT code_cycle FROM cycle WHERE lib_cycle='" + cboCycle.Text + "';");
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            DataSet Ds = new DataSet();

            requette = "SELECT  nom, prenom, tel, adresse FROM adherent WHERE id_association='" + ClasseGenerale.gIdAssociation + "'";
            Ds = a.RecuperationTable(requette);
            ClasseGenerale.gNomEtatImpression = "liste_adherent2";

            ClasseGenerale.dsPrint = Ds.Copy();
            frmImpressionlistemembre f = new frmImpressionlistemembre();
            f.ShowDialog();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseGenerale.uniquement_entier(e);
        }

        private void cboTontine_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeTontine1 = a.ResultatRequette1("SELECT code_tontine FROM tontine WHERE libelle='" + cboTontine.Text + "'");
        }

        private void btnEnregistrer1_Click_1(object sender, EventArgs e)
        {

            codeTontine = a.ResultatRequette1("SELECT code_tontine FROM tontine WHERE libelle = '" + cboTontine.Text + "'");
            codeCycle = a.ResultatRequette1(" SELECT code_cycle FROM cycle WHERE lib_cycle = '" + cboCycle.Text + "'");
            requette = ("INSERT INTO appartenir VALUES (NULL," + codeCycle + "," + codeTontine + ",'" + txtNbrePart.Text + "', " + lecode + ")");
            a.ExecuteRequette(requette);



            ChargementTontineCycleAdherent(lecode);
            MessageBox.Show(requette);
            MessageBox.Show("Operation effectué avec succes !");
        }

        private void btnSupprimer1_Click_1(object sender, EventArgs e)
        {
            requette = "delete from  appartenir  WHERE code_appartenir = " + lecode1 + "";
            a.ExecuteRequette(requette);

            Chargement();
            MessageBox.Show("Operation effectué avec succes !");
        }
    }
}
