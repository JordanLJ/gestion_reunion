namespace gTontine
{
    partial class frmAmendes
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboadherent = new System.Windows.Forms.ComboBox();
            this.cbotontine = new System.Windows.Forms.ComboBox();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtidpret = new System.Windows.Forms.TextBox();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tontine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Image = global::gTontine.Properties.Resources.mod1;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(205, 411);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(99, 36);
            this.btnModifier.TabIndex = 99;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Image = global::gTontine.Properties.Resources.supp1;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(324, 411);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(99, 36);
            this.btnSupprimer.TabIndex = 100;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnfermer
            // 
            this.btnfermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfermer.Image = global::gTontine.Properties.Resources.exit;
            this.btnfermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfermer.Location = new System.Drawing.Point(442, 411);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(83, 36);
            this.btnfermer.TabIndex = 101;
            this.btnfermer.Text = "&Fermer";
            this.btnfermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfermer.UseVisualStyleBackColor = true;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboadherent);
            this.groupBox1.Controls.Add(this.cbotontine);
            this.groupBox1.Controls.Add(this.cboMotif);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtidpret);
            this.groupBox1.Controls.Add(this.txtmontant);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 123);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement";
            // 
            // cboadherent
            // 
            this.cboadherent.BackColor = System.Drawing.SystemColors.Info;
            this.cboadherent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboadherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboadherent.FormattingEnabled = true;
            this.cboadherent.Items.AddRange(new object[] {
            "Actif",
            "Bloqué"});
            this.cboadherent.Location = new System.Drawing.Point(90, 94);
            this.cboadherent.Name = "cboadherent";
            this.cboadherent.Size = new System.Drawing.Size(192, 21);
            this.cboadherent.TabIndex = 106;
            this.cboadherent.SelectedIndexChanged += new System.EventHandler(this.cboadherent_SelectedIndexChanged_1);
            // 
            // cbotontine
            // 
            this.cbotontine.BackColor = System.Drawing.SystemColors.Info;
            this.cbotontine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotontine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotontine.FormattingEnabled = true;
            this.cbotontine.Items.AddRange(new object[] {
            "Actif",
            "Bloqué"});
            this.cbotontine.Location = new System.Drawing.Point(90, 62);
            this.cbotontine.Name = "cbotontine";
            this.cbotontine.Size = new System.Drawing.Size(192, 21);
            this.cbotontine.TabIndex = 104;
            this.cbotontine.SelectedIndexChanged += new System.EventHandler(this.cboTontine_SelectedIndexChanged_1);
            // 
            // cboMotif
            // 
            this.cboMotif.BackColor = System.Drawing.SystemColors.Info;
            this.cboMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Items.AddRange(new object[] {
            "Actif",
            "Bloqué"});
            this.cboMotif.Location = new System.Drawing.Point(408, 94);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(192, 21);
            this.cboMotif.TabIndex = 104;
            this.cboMotif.SelectedIndexChanged += new System.EventHandler(this.cboMotif_SelectedIndexChanged);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(408, 54);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(192, 26);
            this.txtdate.TabIndex = 23;
            // 
            // txtidpret
            // 
            this.txtidpret.BackColor = System.Drawing.SystemColors.Info;
            this.txtidpret.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidpret.Location = new System.Drawing.Point(93, 19);
            this.txtidpret.Name = "txtidpret";
            this.txtidpret.Size = new System.Drawing.Size(193, 26);
            this.txtidpret.TabIndex = 3;
            // 
            // txtmontant
            // 
            this.txtmontant.BackColor = System.Drawing.SystemColors.Info;
            this.txtmontant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontant.Location = new System.Drawing.Point(408, 13);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(193, 26);
            this.txtmontant.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date epargne:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Motif:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Montant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tontine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adherent :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amende:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amende,
            this.Tontine,
            this.Adherent,
            this.montant,
            this.Date,
            this.motif});
            this.dataGridView1.Location = new System.Drawing.Point(3, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 229);
            this.dataGridView1.TabIndex = 97;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // amende
            // 
            this.amende.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amende.DataPropertyName = "id_amendes";
            this.amende.HeaderText = "id_amendes";
            this.amende.Name = "amende";
            this.amende.Visible = false;
            // 
            // Tontine
            // 
            this.Tontine.DataPropertyName = "id_tontine";
            this.Tontine.HeaderText = "id_tontine";
            this.Tontine.Name = "Tontine";
            // 
            // Adherent
            // 
            this.Adherent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adherent.DataPropertyName = "id_adherent";
            this.Adherent.HeaderText = "Adherent";
            this.Adherent.Name = "Adherent";
            // 
            // montant
            // 
            this.montant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant.DataPropertyName = "montant";
            this.montant.HeaderText = "Montant";
            this.montant.Name = "montant";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "date";
            this.Date.Name = "Date";
            // 
            // motif
            // 
            this.motif.DataPropertyName = "id_motif";
            this.motif.HeaderText = "id_motif";
            this.motif.Name = "motif";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Image = global::gTontine.Properties.Resources._new;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(78, 411);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(105, 36);
            this.btnEnregistrer.TabIndex = 102;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(510, 37);
            this.button8.TabIndex = 0;
            this.button8.Text = "Formulaire d\'enregistrement des amendes des adhérents";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 46);
            this.panel2.TabIndex = 103;
            // 
            // frmAmendes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 451);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.panel2);
            this.Name = "frmAmendes";
            this.Text = "frmAmendes";
            this.Load += new System.EventHandler(this.frmAmendes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtidpret;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cboMotif;
        internal System.Windows.Forms.ComboBox cbotontine;
        internal System.Windows.Forms.ComboBox cboadherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn amende;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tontine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn motif;
    }
}