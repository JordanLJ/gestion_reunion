namespace gTontine
{
    partial class frmGestionfondasso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionfondasso));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.cboAdhe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontantapayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLib = new System.Windows.Forms.ComboBox();
            this.Enregistrement = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontantperçu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code_operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montanperçu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Enregistrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 46);
            this.panel2.TabIndex = 99;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(6, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(268, 37);
            this.button8.TabIndex = 0;
            this.button8.Text = "Liste des opérations";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // cboAdhe
            // 
            this.cboAdhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdhe.FormattingEnabled = true;
            this.cboAdhe.Location = new System.Drawing.Point(76, 18);
            this.cboAdhe.Name = "cboAdhe";
            this.cboAdhe.Size = new System.Drawing.Size(196, 21);
            this.cboAdhe.TabIndex = 96;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnFermer);
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 58);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
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
            this.btnFermer.TabIndex = 131;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFermer.UseVisualStyleBackColor = false;
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
            this.btnEnregistrer.TabIndex = 129;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = false;
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
            this.btnSupprimer.TabIndex = 130;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(387, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(143, 20);
            this.dtpDate.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Date :";
            // 
            // txtmontantapayer
            // 
            this.txtmontantapayer.BackColor = System.Drawing.Color.Snow;
            this.txtmontantapayer.Location = new System.Drawing.Point(97, 93);
            this.txtmontantapayer.Name = "txtmontantapayer";
            this.txtmontantapayer.Size = new System.Drawing.Size(175, 20);
            this.txtmontantapayer.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Montant a payer:";
            // 
            // cboLib
            // 
            this.cboLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLib.FormattingEnabled = true;
            this.cboLib.Items.AddRange(new object[] {
            "epargne",
            "fond de caisse"});
            this.cboLib.Location = new System.Drawing.Point(76, 52);
            this.cboLib.Name = "cboLib";
            this.cboLib.Size = new System.Drawing.Size(196, 21);
            this.cboLib.TabIndex = 85;
            // 
            // Enregistrement
            // 
            this.Enregistrement.BackColor = System.Drawing.SystemColors.Control;
            this.Enregistrement.Controls.Add(this.label5);
            this.Enregistrement.Controls.Add(this.txtreste);
            this.Enregistrement.Controls.Add(this.label6);
            this.Enregistrement.Controls.Add(this.txtmontantperçu);
            this.Enregistrement.Controls.Add(this.label4);
            this.Enregistrement.Controls.Add(this.cboAdhe);
            this.Enregistrement.Controls.Add(this.label7);
            this.Enregistrement.Controls.Add(this.dtpDate);
            this.Enregistrement.Controls.Add(this.label3);
            this.Enregistrement.Controls.Add(this.txtmontantapayer);
            this.Enregistrement.Controls.Add(this.label1);
            this.Enregistrement.Controls.Add(this.cboLib);
            this.Enregistrement.Controls.Add(this.label2);
            this.Enregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrement.Location = new System.Drawing.Point(6, 259);
            this.Enregistrement.Name = "Enregistrement";
            this.Enregistrement.Size = new System.Drawing.Size(647, 136);
            this.Enregistrement.TabIndex = 95;
            this.Enregistrement.TabStop = false;
            this.Enregistrement.Text = "Enregistrements";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Total en caisse:";
            // 
            // txtreste
            // 
            this.txtreste.BackColor = System.Drawing.Color.Snow;
            this.txtreste.Location = new System.Drawing.Point(387, 91);
            this.txtreste.Name = "txtreste";
            this.txtreste.Size = new System.Drawing.Size(143, 20);
            this.txtreste.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Reste:";
            // 
            // txtmontantperçu
            // 
            this.txtmontantperçu.BackColor = System.Drawing.Color.Snow;
            this.txtmontantperçu.Location = new System.Drawing.Point(387, 53);
            this.txtmontantperçu.Name = "txtmontantperçu";
            this.txtmontantperçu.Size = new System.Drawing.Size(143, 20);
            this.txtmontantperçu.TabIndex = 99;
            this.txtmontantperçu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Montant Perçu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "Libelle :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_operation,
            this.NomComplet,
            this.libelle,
            this.date_op,
            this.montant_payer,
            this.montanperçu,
            this.Reste});
            this.dataGridView1.Location = new System.Drawing.Point(2, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 203);
            this.dataGridView1.TabIndex = 94;
            // 
            // code_operation
            // 
            this.code_operation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code_operation.DataPropertyName = "code_operation";
            this.code_operation.FillWeight = 200F;
            this.code_operation.HeaderText = "code_operation";
            this.code_operation.Name = "code_operation";
            this.code_operation.Visible = false;
            // 
            // NomComplet
            // 
            this.NomComplet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomComplet.DataPropertyName = "NomComplet";
            this.NomComplet.HeaderText = "Adhérent";
            this.NomComplet.Name = "NomComplet";
            // 
            // libelle
            // 
            this.libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Libelle";
            this.libelle.Name = "libelle";
            // 
            // date_op
            // 
            this.date_op.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_op.DataPropertyName = "date_op";
            this.date_op.HeaderText = "Date";
            this.date_op.Name = "date_op";
            // 
            // montant_payer
            // 
            this.montant_payer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montant_payer.DataPropertyName = "montant_payer";
            this.montant_payer.HeaderText = "Montant à payer";
            this.montant_payer.Name = "montant_payer";
            // 
            // montanperçu
            // 
            this.montanperçu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.montanperçu.HeaderText = "Montant perçu";
            this.montanperçu.Name = "montanperçu";
            // 
            // Reste
            // 
            this.Reste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reste.DataPropertyName = "reste";
            this.Reste.HeaderText = "reste";
            this.Reste.Name = "Reste";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 100;
            // 
            // frmGestionfondasso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 464);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Enregistrement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGestionfondasso";
            this.Text = "frmGestionfondasso";
            this.Load += new System.EventHandler(this.frmGestionfondasso_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Enregistrement.ResumeLayout(false);
            this.Enregistrement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox cboAdhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontantapayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLib;
        private System.Windows.Forms.GroupBox Enregistrement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtreste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmontantperçu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_op;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn montanperçu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reste;
    }
}