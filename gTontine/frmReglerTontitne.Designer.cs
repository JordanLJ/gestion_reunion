namespace gTontine
{
    partial class frmReglerTontitne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReglerTontitne));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_paye_tontine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_membre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_percu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_restant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_paye_tontine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_association = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut_paye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_tontine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbostatut = new System.Windows.Forms.ComboBox();
            this.cboAdhe = new System.Windows.Forms.TextBox();
            this.Enregistrement = new System.Windows.Forms.GroupBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.txtreste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontantpercu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdaterembourse = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontantapayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbotontine = new System.Windows.Forms.ComboBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCycle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Enregistrement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_paye_tontine,
            this.nom_membre,
            this.montant_payer,
            this.montant_percu,
            this.montant_restant,
            this.date_paye_tontine,
            this.id_association,
            this.rang,
            this.statut_paye,
            this.code_tontine,
            this.code_cycle});
            this.dataGridView2.Location = new System.Drawing.Point(3, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(862, 231);
            this.dataGridView2.TabIndex = 110;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // id_paye_tontine
            // 
            this.id_paye_tontine.DataPropertyName = "id_paye_tontine";
            this.id_paye_tontine.HeaderText = "id_paye_tontine";
            this.id_paye_tontine.Name = "id_paye_tontine";
            this.id_paye_tontine.Visible = false;
            // 
            // nom_membre
            // 
            this.nom_membre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_membre.DataPropertyName = "nom_membre";
            this.nom_membre.HeaderText = "Nom du membre";
            this.nom_membre.Name = "nom_membre";
            // 
            // montant_payer
            // 
            this.montant_payer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant_payer.DataPropertyName = "montant_payer";
            this.montant_payer.HeaderText = "Montant a payer";
            this.montant_payer.Name = "montant_payer";
            // 
            // montant_percu
            // 
            this.montant_percu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant_percu.DataPropertyName = "montant_percu";
            this.montant_percu.HeaderText = "Montant Percu";
            this.montant_percu.Name = "montant_percu";
            // 
            // montant_restant
            // 
            this.montant_restant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant_restant.DataPropertyName = "montant_restant";
            this.montant_restant.HeaderText = "Montant restant";
            this.montant_restant.Name = "montant_restant";
            // 
            // date_paye_tontine
            // 
            this.date_paye_tontine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_paye_tontine.DataPropertyName = "date_paye_tontine";
            this.date_paye_tontine.HeaderText = "Date";
            this.date_paye_tontine.Name = "date_paye_tontine";
            // 
            // id_association
            // 
            this.id_association.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_association.DataPropertyName = "id_association";
            this.id_association.HeaderText = "id_association";
            this.id_association.Name = "id_association";
            this.id_association.Visible = false;
            // 
            // rang
            // 
            this.rang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rang.DataPropertyName = "rang";
            this.rang.HeaderText = "rang";
            this.rang.Name = "rang";
            // 
            // statut_paye
            // 
            this.statut_paye.DataPropertyName = "statut_paye";
            this.statut_paye.HeaderText = "statut_paye";
            this.statut_paye.Name = "statut_paye";
            this.statut_paye.Visible = false;
            // 
            // code_tontine
            // 
            this.code_tontine.DataPropertyName = "code_tontine";
            this.code_tontine.HeaderText = "code_tontine";
            this.code_tontine.Name = "code_tontine";
            this.code_tontine.Visible = false;
            // 
            // code_cycle
            // 
            this.code_cycle.DataPropertyName = "code_cycle";
            this.code_cycle.HeaderText = "code_cycle";
            this.code_cycle.Name = "code_cycle";
            this.code_cycle.Visible = false;
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
            this.cbostatut.Location = new System.Drawing.Point(398, 90);
            this.cbostatut.Name = "cbostatut";
            this.cbostatut.Size = new System.Drawing.Size(178, 24);
            this.cbostatut.TabIndex = 109;
            // 
            // cboAdhe
            // 
            this.cboAdhe.BackColor = System.Drawing.SystemColors.Info;
            this.cboAdhe.Enabled = false;
            this.cboAdhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdhe.Location = new System.Drawing.Point(101, 16);
            this.cboAdhe.Name = "cboAdhe";
            this.cboAdhe.Size = new System.Drawing.Size(175, 22);
            this.cboAdhe.TabIndex = 108;
            // 
            // Enregistrement
            // 
            this.Enregistrement.BackColor = System.Drawing.SystemColors.Control;
            this.Enregistrement.Controls.Add(this.btnCalcul);
            this.Enregistrement.Controls.Add(this.cbostatut);
            this.Enregistrement.Controls.Add(this.cboAdhe);
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
            this.Enregistrement.Location = new System.Drawing.Point(4, 273);
            this.Enregistrement.Name = "Enregistrement";
            this.Enregistrement.Size = new System.Drawing.Size(586, 128);
            this.Enregistrement.TabIndex = 107;
            this.Enregistrement.TabStop = false;
            this.Enregistrement.Text = "Enregistrements";
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(222, 92);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(55, 23);
            this.btnCalcul.TabIndex = 7;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // txtreste
            // 
            this.txtreste.BackColor = System.Drawing.SystemColors.Info;
            this.txtreste.Enabled = false;
            this.txtreste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreste.Location = new System.Drawing.Point(102, 94);
            this.txtreste.Name = "txtreste";
            this.txtreste.Size = new System.Drawing.Size(116, 22);
            this.txtreste.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Reste:";
            // 
            // txtmontantpercu
            // 
            this.txtmontantpercu.BackColor = System.Drawing.SystemColors.Info;
            this.txtmontantpercu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontantpercu.Location = new System.Drawing.Point(398, 53);
            this.txtmontantpercu.Name = "txtmontantpercu";
            this.txtmontantpercu.Size = new System.Drawing.Size(178, 22);
            this.txtmontantpercu.TabIndex = 6;
            this.txtmontantpercu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontantpercu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "Statut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Montant Perçu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 97;
            this.label7.Text = "Adhérent :";
            // 
            // txtdaterembourse
            // 
            this.txtdaterembourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdaterembourse.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdaterembourse.Location = new System.Drawing.Point(398, 18);
            this.txtdaterembourse.Name = "txtdaterembourse";
            this.txtdaterembourse.Size = new System.Drawing.Size(178, 22);
            this.txtdaterembourse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 18);
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
            this.txtmontantapayer.Location = new System.Drawing.Point(102, 52);
            this.txtmontantapayer.Name = "txtmontantapayer";
            this.txtmontantapayer.Size = new System.Drawing.Size(175, 22);
            this.txtmontantapayer.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Montant a payer:";
            // 
            // txtrang
            // 
            this.txtrang.BackColor = System.Drawing.SystemColors.Info;
            this.txtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrang.Location = new System.Drawing.Point(56, 74);
            this.txtrang.Name = "txtrang";
            this.txtrang.Size = new System.Drawing.Size(203, 22);
            this.txtrang.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "Rang:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(139, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 58);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Silver;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(400, 16);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 36);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Silver;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(290, 16);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 36);
            this.btnFermer.TabIndex = 10;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(21, 15);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 36);
            this.btnEnregistrer.TabIndex = 8;
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
            this.btnSupprimer.Location = new System.Drawing.Point(159, 15);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 36);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(524, 37);
            this.button8.TabIndex = 0;
            this.button8.Text = "Formulaire pour cotiser";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 35);
            this.panel2.TabIndex = 109;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbotontine);
            this.groupBox2.Controls.Add(this.txtrang);
            this.groupBox2.Controls.Add(this.BtnAjouter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboCycle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(595, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 128);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sélectionner le cycle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 123;
            this.label8.Text = "Tontine :";
            // 
            // cbotontine
            // 
            this.cbotontine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotontine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotontine.FormattingEnabled = true;
            this.cbotontine.Location = new System.Drawing.Point(56, 15);
            this.cbotontine.Name = "cbotontine";
            this.cbotontine.Size = new System.Drawing.Size(203, 24);
            this.cbotontine.TabIndex = 1;
            this.cbotontine.SelectedIndexChanged += new System.EventHandler(this.cbotontine_SelectedIndexChanged);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.Silver;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Image = global::gTontine.Properties.Resources.Btn_Std_ok1;
            this.BtnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjouter.Location = new System.Drawing.Point(56, 96);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(84, 31);
            this.BtnAjouter.TabIndex = 4;
            this.BtnAjouter.Text = "&Afficher";
            this.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 92;
            this.label9.Text = "Cycle :";
            // 
            // cboCycle
            // 
            this.cboCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCycle.FormattingEnabled = true;
            this.cboCycle.Location = new System.Drawing.Point(56, 45);
            this.cboCycle.Name = "cboCycle";
            this.cboCycle.Size = new System.Drawing.Size(203, 24);
            this.cboCycle.TabIndex = 2;
            this.cboCycle.SelectedIndexChanged += new System.EventHandler(this.cboCycle_SelectedIndexChanged);
            // 
            // frmReglerTontitne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(865, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Enregistrement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReglerTontitne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReglerTontitne";
            this.Load += new System.EventHandler(this.frmReglerTontitne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Enregistrement.ResumeLayout(false);
            this.Enregistrement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbostatut;
        private System.Windows.Forms.TextBox cboAdhe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox Enregistrement;
        private System.Windows.Forms.TextBox txtreste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmontantpercu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtdaterembourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontantapayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbotontine;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCycle;
        private System.Windows.Forms.TextBox txtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_paye_tontine;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_percu;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_restant;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_paye_tontine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_association;
        private System.Windows.Forms.DataGridViewTextBoxColumn rang;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut_paye;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_tontine;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_cycle;
    }
}