﻿namespace gTontine
{
    partial class frmstatlisteadherent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstatlisteadherent));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTontine = new System.Windows.Forms.ComboBox();
            this.cboCycle = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_adh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cycle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tontine :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 114;
            this.label5.Text = "Effectif :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTontine);
            this.groupBox1.Controls.Add(this.cboCycle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(656, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 137);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critères";
            // 
            // cboTontine
            // 
            this.cboTontine.BackColor = System.Drawing.SystemColors.Info;
            this.cboTontine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTontine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTontine.FormattingEnabled = true;
            this.cboTontine.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.cboTontine.Location = new System.Drawing.Point(73, 24);
            this.cboTontine.Name = "cboTontine";
            this.cboTontine.Size = new System.Drawing.Size(211, 24);
            this.cboTontine.TabIndex = 49;
            // 
            // cboCycle
            // 
            this.cboCycle.BackColor = System.Drawing.SystemColors.Info;
            this.cboCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCycle.FormattingEnabled = true;
            this.cboCycle.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.cboCycle.Location = new System.Drawing.Point(73, 83);
            this.cboCycle.Name = "cboCycle";
            this.cboCycle.Size = new System.Drawing.Size(211, 24);
            this.cboCycle.TabIndex = 49;
            this.cboCycle.SelectedIndexChanged += new System.EventHandler(this.cboCycle_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.sexe,
            this.tel,
            this.date_adh});
            this.dataGridView1.Location = new System.Drawing.Point(4, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 353);
            this.dataGridView1.TabIndex = 108;
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
            // sexe
            // 
            this.sexe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexe.DataPropertyName = "sexe";
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            // 
            // tel
            // 
            this.tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Téléphone";
            this.tel.Name = "tel";
            // 
            // date_adh
            // 
            this.date_adh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_adh.DataPropertyName = "date_adh";
            this.date_adh.HeaderText = "Date d\'adhésion";
            this.date_adh.Name = "date_adh";
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectif.Location = new System.Drawing.Point(756, 281);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(78, 20);
            this.lblEffectif.TabIndex = 115;
            this.lblEffectif.Text = "Effectif :";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Silver;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = global::gTontine.Properties.Resources.exit1;
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(847, 360);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(84, 31);
            this.Button2.TabIndex = 110;
            this.Button2.Text = "&Fermer";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Silver;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = global::gTontine.Properties.Resources.printer1;
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(743, 359);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(91, 31);
            this.Button1.TabIndex = 111;
            this.Button1.Text = "&Imprimer";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.Silver;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Image = global::gTontine.Properties.Resources.Btn_Std_ok1;
            this.BtnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjouter.Location = new System.Drawing.Point(656, 359);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(79, 31);
            this.BtnAjouter.TabIndex = 112;
            this.BtnAjouter.Text = "&Afficher";
            this.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 46);
            this.panel2.TabIndex = 116;
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
            this.button8.Size = new System.Drawing.Size(460, 37);
            this.button8.TabIndex = 0;
            this.button8.Text = "Formulaire pour connaitre l\'etat d\'un l\'adhérent";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmstatlisteadherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(945, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEffectif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmstatlisteadherent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmetatstatadherent";
            this.Load += new System.EventHandler(this.frmstatlisteadherent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox cboTontine;
        internal System.Windows.Forms.ComboBox cboCycle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_adh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
    }
}