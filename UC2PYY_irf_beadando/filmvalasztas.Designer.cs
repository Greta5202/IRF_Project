﻿namespace UC2PYY_irf_beadando
{
    partial class filmvalasztas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filmlista = new System.Windows.Forms.Button();
            this.filmeklistbox = new System.Windows.Forms.ListBox();
            this.kivalaszt = new System.Windows.Forms.Button();
            this.panel_termek = new System.Windows.Forms.Panel();
            this.gomb_lefoglal = new System.Windows.Forms.Button();
            this.panel_reg = new System.Windows.Forms.Panel();
            this.textBox_ulohely = new System.Windows.Forms.TextBox();
            this.label_ulohely = new System.Windows.Forms.Label();
            this.textBox_jelszo2 = new System.Windows.Forms.TextBox();
            this.textBox_jelszo1 = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_jelszo2 = new System.Windows.Forms.Label();
            this.label_jelszo1 = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_nev = new System.Windows.Forms.Label();
            this.gomb_regisztrálok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gomb_kiiras = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_termek.SuspendLayout();
            this.panel_reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmlista
            // 
            this.filmlista.Location = new System.Drawing.Point(38, 29);
            this.filmlista.Name = "filmlista";
            this.filmlista.Size = new System.Drawing.Size(164, 48);
            this.filmlista.TabIndex = 0;
            this.filmlista.Text = "Filmek listázása";
            this.filmlista.UseVisualStyleBackColor = true;
            this.filmlista.Click += new System.EventHandler(this.filmlista_Click);
            // 
            // filmeklistbox
            // 
            this.filmeklistbox.FormattingEnabled = true;
            this.filmeklistbox.ItemHeight = 20;
            this.filmeklistbox.Location = new System.Drawing.Point(20, 108);
            this.filmeklistbox.Name = "filmeklistbox";
            this.filmeklistbox.Size = new System.Drawing.Size(222, 104);
            this.filmeklistbox.TabIndex = 1;
            this.filmeklistbox.SelectedValueChanged += new System.EventHandler(this.filmeklistbox_SelectedValueChanged);
            // 
            // kivalaszt
            // 
            this.kivalaszt.Enabled = false;
            this.kivalaszt.Location = new System.Drawing.Point(38, 247);
            this.kivalaszt.Name = "kivalaszt";
            this.kivalaszt.Size = new System.Drawing.Size(164, 48);
            this.kivalaszt.TabIndex = 2;
            this.kivalaszt.Text = "Tovább!";
            this.kivalaszt.UseVisualStyleBackColor = true;
            this.kivalaszt.Click += new System.EventHandler(this.kivalaszt_Click);
            // 
            // panel_termek
            // 
            this.panel_termek.BackColor = System.Drawing.SystemColors.Info;
            this.panel_termek.Controls.Add(this.textBox1);
            this.panel_termek.Location = new System.Drawing.Point(344, 29);
            this.panel_termek.Name = "panel_termek";
            this.panel_termek.Size = new System.Drawing.Size(420, 500);
            this.panel_termek.TabIndex = 3;
            this.panel_termek.Visible = false;
            // 
            // gomb_lefoglal
            // 
            this.gomb_lefoglal.Location = new System.Drawing.Point(600, 535);
            this.gomb_lefoglal.Name = "gomb_lefoglal";
            this.gomb_lefoglal.Size = new System.Drawing.Size(164, 48);
            this.gomb_lefoglal.TabIndex = 4;
            this.gomb_lefoglal.Text = "Lefoglalom";
            this.gomb_lefoglal.UseVisualStyleBackColor = true;
            this.gomb_lefoglal.Click += new System.EventHandler(this.gomb_lefoglal_Click);
            // 
            // panel_reg
            // 
            this.panel_reg.BackColor = System.Drawing.SystemColors.Info;
            this.panel_reg.Controls.Add(this.gomb_kiiras);
            this.panel_reg.Controls.Add(this.dataGridView1);
            this.panel_reg.Controls.Add(this.gomb_regisztrálok);
            this.panel_reg.Controls.Add(this.textBox_ulohely);
            this.panel_reg.Controls.Add(this.label_ulohely);
            this.panel_reg.Controls.Add(this.textBox_jelszo2);
            this.panel_reg.Controls.Add(this.textBox_jelszo1);
            this.panel_reg.Controls.Add(this.textBox_email);
            this.panel_reg.Controls.Add(this.textBox_nev);
            this.panel_reg.Controls.Add(this.label_jelszo2);
            this.panel_reg.Controls.Add(this.label_jelszo1);
            this.panel_reg.Controls.Add(this.label_email);
            this.panel_reg.Controls.Add(this.label_nev);
            this.panel_reg.Location = new System.Drawing.Point(802, 29);
            this.panel_reg.Name = "panel_reg";
            this.panel_reg.Size = new System.Drawing.Size(420, 500);
            this.panel_reg.TabIndex = 4;
            this.panel_reg.Visible = false;
            // 
            // textBox_ulohely
            // 
            this.textBox_ulohely.Location = new System.Drawing.Point(194, 143);
            this.textBox_ulohely.Name = "textBox_ulohely";
            this.textBox_ulohely.ReadOnly = true;
            this.textBox_ulohely.Size = new System.Drawing.Size(208, 26);
            this.textBox_ulohely.TabIndex = 9;
            // 
            // label_ulohely
            // 
            this.label_ulohely.AutoSize = true;
            this.label_ulohely.Location = new System.Drawing.Point(13, 142);
            this.label_ulohely.Name = "label_ulohely";
            this.label_ulohely.Size = new System.Drawing.Size(61, 20);
            this.label_ulohely.TabIndex = 8;
            this.label_ulohely.Text = "Ülőhely";
            // 
            // textBox_jelszo2
            // 
            this.textBox_jelszo2.Location = new System.Drawing.Point(194, 111);
            this.textBox_jelszo2.Name = "textBox_jelszo2";
            this.textBox_jelszo2.Size = new System.Drawing.Size(208, 26);
            this.textBox_jelszo2.TabIndex = 7;
            // 
            // textBox_jelszo1
            // 
            this.textBox_jelszo1.Location = new System.Drawing.Point(194, 79);
            this.textBox_jelszo1.Name = "textBox_jelszo1";
            this.textBox_jelszo1.Size = new System.Drawing.Size(208, 26);
            this.textBox_jelszo1.TabIndex = 6;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(194, 45);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(208, 26);
            this.textBox_email.TabIndex = 5;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(194, 8);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(208, 26);
            this.textBox_nev.TabIndex = 4;
            // 
            // label_jelszo2
            // 
            this.label_jelszo2.AutoSize = true;
            this.label_jelszo2.Location = new System.Drawing.Point(13, 111);
            this.label_jelszo2.Name = "label_jelszo2";
            this.label_jelszo2.Size = new System.Drawing.Size(154, 20);
            this.label_jelszo2.TabIndex = 3;
            this.label_jelszo2.Text = "Jelszó megerősítése";
            // 
            // label_jelszo1
            // 
            this.label_jelszo1.AutoSize = true;
            this.label_jelszo1.Location = new System.Drawing.Point(13, 79);
            this.label_jelszo1.Name = "label_jelszo1";
            this.label_jelszo1.Size = new System.Drawing.Size(54, 20);
            this.label_jelszo1.TabIndex = 2;
            this.label_jelszo1.Text = "Jelszó";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(13, 48);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(48, 20);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email";
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(13, 14);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(36, 20);
            this.label_nev.TabIndex = 0;
            this.label_nev.Text = "Név";
            // 
            // gomb_regisztrálok
            // 
            this.gomb_regisztrálok.Enabled = false;
            this.gomb_regisztrálok.Location = new System.Drawing.Point(120, 186);
            this.gomb_regisztrálok.Name = "gomb_regisztrálok";
            this.gomb_regisztrálok.Size = new System.Drawing.Size(164, 48);
            this.gomb_regisztrálok.TabIndex = 5;
            this.gomb_regisztrálok.Text = "Regisztrálok";
            this.gomb_regisztrálok.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(385, 126);
            this.dataGridView1.TabIndex = 10;
            // 
            // gomb_kiiras
            // 
            this.gomb_kiiras.Enabled = false;
            this.gomb_kiiras.Location = new System.Drawing.Point(120, 381);
            this.gomb_kiiras.Name = "gomb_kiiras";
            this.gomb_kiiras.Size = new System.Drawing.Size(164, 48);
            this.gomb_kiiras.TabIndex = 11;
            this.gomb_kiiras.Text = "Mentés";
            this.gomb_kiiras.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // filmvalasztas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_reg);
            this.Controls.Add(this.gomb_lefoglal);
            this.Controls.Add(this.panel_termek);
            this.Controls.Add(this.kivalaszt);
            this.Controls.Add(this.filmeklistbox);
            this.Controls.Add(this.filmlista);
            this.Name = "filmvalasztas";
            this.Size = new System.Drawing.Size(1240, 628);
            this.panel_termek.ResumeLayout(false);
            this.panel_termek.PerformLayout();
            this.panel_reg.ResumeLayout(false);
            this.panel_reg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filmlista;
        private System.Windows.Forms.ListBox filmeklistbox;
        private System.Windows.Forms.Button kivalaszt;
        private System.Windows.Forms.Button gomb_lefoglal;
        private System.Windows.Forms.Label label_ulohely;
        private System.Windows.Forms.TextBox textBox_jelszo2;
        private System.Windows.Forms.TextBox textBox_jelszo1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_jelszo2;
        private System.Windows.Forms.Label label_jelszo1;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Button gomb_kiiras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gomb_regisztrálok;
        internal System.Windows.Forms.Panel panel_reg;
        internal System.Windows.Forms.TextBox textBox_ulohely;
        internal System.Windows.Forms.Panel panel_termek;
        private System.Windows.Forms.TextBox textBox1;
    }
}
