namespace gTontine
{
    partial class frmRemboursementsdettes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemboursementsdettes));
            this.txtreste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontantpercu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.txtdaterembourse = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontantapayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Enregistrement = new System.Windows.Forms.GroupBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.cbostatut = new System.Windows.Forms.ComboBox();
            this.cboAdhe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.code_adherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taux_interet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_percu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reste_remboursement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Enregistrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtreste
            // 
            this.txtreste.BackColor = System.Drawing.SystemColors.Info;
            this.txtreste.Enabled = false;
            this.txtreste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreste.Location = new System.Drawing.Point(97, 94);
            this.txtreste.Name = "txtreste";
            this.txtreste.Size = new System.Drawing.Size(176, 22);
            this.txtreste.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Reste:";
            // 
            // txtmontantpercu
            // 
            this.txtmontantpercu.BackColor = System.Drawing.SystemColors.Info;
            this.txtmontantpercu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontantpercu.Location = new System.Drawing.Point(453, 51);
            this.txtmontantpercu.Name = "txtmontantpercu";
            this.txtmontantpercu.Size = new System.Drawing.Size(226, 22);
            this.txtmontantpercu.TabIndex = 2;
            this.txtmontantpercu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontantpercu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Montant Perçu:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 46);
            this.panel2.TabIndex = 105;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(524, 37);
            this.button8.TabIndex = 0;
            this.button8.Text = "Formulaires de remboursement des emprunts";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // txtdaterembourse
            // 
            this.txtdaterembourse.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdaterembourse.Location = new System.Drawing.Point(453, 19);
            this.txtdaterembourse.Name = "txtdaterembourse";
            this.txtdaterembourse.Size = new System.Drawing.Size(226, 20);
            this.txtdaterembourse.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Date :";
            // 
            // txtmontantapayer
            // 
            this.txtmontantapayer.BackColor = System.Drawing.SystemColors.Info;
            this.txtmontantapayer.Enabled = false;
            this.txtmontantapayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontantapayer.Location = new System.Drawing.Point(97, 52);
            this.txtmontantapayer.Name = "txtmontantapayer";
            this.txtmontantapayer.Size = new System.Drawing.Size(250, 22);
            this.txtmontantapayer.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Montant a payer:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 58);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Silver;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(391, 16);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 36);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Silver;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(281, 16);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 36);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Silver;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Image = global::gTontine.Properties.Resources._new;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 15);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 36);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Silver;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Image = global::gTontine.Properties.Resources.delete;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(150, 15);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 36);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 97;
            this.label7.Text = "Adhérent :";
            // 
            // Enregistrement
            // 
            this.Enregistrement.BackColor = System.Drawing.SystemColors.Control;
            this.Enregistrement.Controls.Add(this.btnCalcul);
            this.Enregistrement.Controls.Add(this.cbostatut);
            this.Enregistrement.Controls.Add(this.cboAdhe);
            this.Enregistrement.Controls.Add(this.label5);
            this.Enregistrement.Controls.Add(this.textBox1);
            this.Enregistrement.Controls.Add(this.txtreste);
            this.Enregistrement.Controls.Add(this.label6);
            this.Enregistrement.Controls.Add(this.txtmontantpercu);
            this.Enregistrement.Controls.Add(this.label2);
            this.Enregistrement.Controls.Add(this.label4);
            this.Enregistrement.Controls.Add(this.label7);
            this.Enregistrement.Controls.Add(this.txtdaterembourse);
            this.Enregistrement.Controls.Add(this.label3);
            this.Enregistrement.Controls.Add(this.txtmontantapayer);
            this.Enregistrement.Controls.Add(this.label1);
            this.Enregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrement.Location = new System.Drawing.Point(3, 268);
            this.Enregistrement.Name = "Enregistrement";
            this.Enregistrement.Size = new System.Drawing.Size(685, 136);
            this.Enregistrement.TabIndex = 103;
            this.Enregistrement.TabStop = false;
            this.Enregistrement.Text = "Enregistrements";
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(279, 92);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(68, 23);
            this.btnCalcul.TabIndex = 3;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // cbostatut
            // 
            this.cbostatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatut.Enabled = false;
            this.cbostatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostatut.FormattingEnabled = true;
            this.cbostatut.Items.AddRange(new object[] {
            "Rembourser",
            "Non Rembourser",
            "Avancer"});
            this.cbostatut.Location = new System.Drawing.Point(453, 81);
            this.cbostatut.Name = "cbostatut";
            this.cbostatut.Size = new System.Drawing.Size(226, 24);
            this.cbostatut.TabIndex = 109;
            // 
            // cboAdhe
            // 
            this.cboAdhe.BackColor = System.Drawing.SystemColors.Info;
            this.cboAdhe.Enabled = false;
            this.cboAdhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdhe.Location = new System.Drawing.Point(96, 16);
            this.cboAdhe.Name = "cboAdhe";
            this.cboAdhe.Size = new System.Drawing.Size(251, 22);
            this.cboAdhe.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Total en caisse:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(452, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "Statut:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_adherent,
            this.nom,
            this.prenom,
            this.id_pret,
            this.montant,
            this.taux_interet,
            this.montant_percu,
            this.reste_remboursement,
            this.date_pret,
            this.statut});
            this.dataGridView2.Location = new System.Drawing.Point(5, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(694, 219);
            this.dataGridView2.TabIndex = 106;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // code_adherent
            // 
            this.code_adherent.DataPropertyName = "code_adherent";
            this.code_adherent.HeaderText = "code_adherent";
            this.code_adherent.Name = "code_adherent";
            this.code_adherent.Visible = false;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            // 
            // id_pret
            // 
            this.id_pret.DataPropertyName = "id_pret";
            this.id_pret.HeaderText = "id_pret";
            this.id_pret.Name = "id_pret";
            this.id_pret.Visible = false;
            // 
            // montant
            // 
            this.montant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant.DataPropertyName = "montant";
            this.montant.HeaderText = "Montant du prêt";
            this.montant.Name = "montant";
            // 
            // taux_interet
            // 
            this.taux_interet.DataPropertyName = "taux_interet";
            this.taux_interet.HeaderText = "Taux intérêt";
            this.taux_interet.Name = "taux_interet";
            this.taux_interet.Visible = false;
            // 
            // montant_percu
            // 
            this.montant_percu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant_percu.DataPropertyName = "montant_percu";
            this.montant_percu.HeaderText = "Montant percu";
            this.montant_percu.Name = "montant_percu";
            // 
            // reste_remboursement
            // 
            this.reste_remboursement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reste_remboursement.DataPropertyName = "reste_remboursement";
            this.reste_remboursement.HeaderText = "Reste";
            this.reste_remboursement.Name = "reste_remboursement";
            // 
            // date_pret
            // 
            this.date_pret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_pret.DataPropertyName = "date_pret";
            this.date_pret.HeaderText = "Date du pret";
            this.date_pret.Name = "date_pret";
            // 
            // statut
            // 
            this.statut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statut.DataPropertyName = "statut";
            this.statut.HeaderText = "statut";
            this.statut.Name = "statut";
            this.statut.Visible = false;
            // 
            // frmRemboursementsdettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 467);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Enregistrement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRemboursementsdettes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRemboursementsdettes";
            this.Load += new System.EventHandler(this.frmRemboursementsdettes_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Enregistrement.ResumeLayout(false);
            this.Enregistrement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtreste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmontantpercu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker txtdaterembourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontantapayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Enregistrement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox cboAdhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbostatut;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_adherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn taux_interet;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_percu;
        private System.Windows.Forms.DataGridViewTextBoxColumn reste_remboursement;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
    }
}