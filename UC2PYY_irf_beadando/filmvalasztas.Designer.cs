namespace UC2PYY_irf_beadando
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
            this.panel_reg = new System.Windows.Forms.Panel();
            this.gomb_kiiras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_ulohely = new System.Windows.Forms.TextBox();
            this.label_ulohely = new System.Windows.Forms.Label();
            this.textBox_jelszo2 = new System.Windows.Forms.TextBox();
            this.textBox_jelszo1 = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_jelszo2 = new System.Windows.Forms.Label();
            this.label_jelszo1 = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_zold = new System.Windows.Forms.TextBox();
            this.textBox_szurke = new System.Windows.Forms.TextBox();
            this.label_zold = new System.Windows.Forms.Label();
            this.label_szurke = new System.Windows.Forms.Label();
            this.gomb_regi = new System.Windows.Forms.Button();
            this.panel_reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmlista
            // 
            this.filmlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.filmlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmlista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.filmlista.Location = new System.Drawing.Point(38, 29);
            this.filmlista.Name = "filmlista";
            this.filmlista.Size = new System.Drawing.Size(164, 48);
            this.filmlista.TabIndex = 0;
            this.filmlista.Text = "Mutasd a filmeket!";
            this.filmlista.UseVisualStyleBackColor = false;
            this.filmlista.Click += new System.EventHandler(this.filmlista_Click);
            // 
            // filmeklistbox
            // 
            this.filmeklistbox.BackColor = System.Drawing.Color.MistyRose;
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
            this.kivalaszt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kivalaszt.Enabled = false;
            this.kivalaszt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kivalaszt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.kivalaszt.Location = new System.Drawing.Point(38, 247);
            this.kivalaszt.Name = "kivalaszt";
            this.kivalaszt.Size = new System.Drawing.Size(164, 48);
            this.kivalaszt.TabIndex = 2;
            this.kivalaszt.Text = "Tovább!";
            this.kivalaszt.UseVisualStyleBackColor = false;
            this.kivalaszt.Click += new System.EventHandler(this.kivalaszt_Click);
            // 
            // panel_termek
            // 
            this.panel_termek.BackColor = System.Drawing.Color.Lavender;
            this.panel_termek.Location = new System.Drawing.Point(344, 29);
            this.panel_termek.Name = "panel_termek";
            this.panel_termek.Size = new System.Drawing.Size(420, 500);
            this.panel_termek.TabIndex = 3;
            this.panel_termek.Visible = false;
            // 
            // panel_reg
            // 
            this.panel_reg.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel_reg.Controls.Add(this.gomb_regi);
            this.panel_reg.Controls.Add(this.gomb_kiiras);
            this.panel_reg.Controls.Add(this.dataGridView1);
            this.panel_reg.Controls.Add(this.textBox_ulohely);
            this.panel_reg.Controls.Add(this.label_ulohely);
            this.panel_reg.Controls.Add(this.textBox_jelszo2);
            this.panel_reg.Controls.Add(this.textBox_jelszo1);
            this.panel_reg.Controls.Add(this.textBox_email);
            this.panel_reg.Controls.Add(this.label_jelszo2);
            this.panel_reg.Controls.Add(this.label_jelszo1);
            this.panel_reg.Controls.Add(this.label_email);
            this.panel_reg.Location = new System.Drawing.Point(802, 29);
            this.panel_reg.Name = "panel_reg";
            this.panel_reg.Size = new System.Drawing.Size(420, 500);
            this.panel_reg.TabIndex = 4;
            this.panel_reg.Visible = false;
            // 
            // gomb_kiiras
            // 
            this.gomb_kiiras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gomb_kiiras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gomb_kiiras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gomb_kiiras.Location = new System.Drawing.Point(120, 381);
            this.gomb_kiiras.Name = "gomb_kiiras";
            this.gomb_kiiras.Size = new System.Drawing.Size(164, 48);
            this.gomb_kiiras.TabIndex = 11;
            this.gomb_kiiras.Text = "Mentés";
            this.gomb_kiiras.UseVisualStyleBackColor = false;
            this.gomb_kiiras.Click += new System.EventHandler(this.gomb_kiiras_Click);
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
            // textBox_ulohely
            // 
            this.textBox_ulohely.Location = new System.Drawing.Point(194, 143);
            this.textBox_ulohely.Name = "textBox_ulohely";
            this.textBox_ulohely.Size = new System.Drawing.Size(208, 26);
            this.textBox_ulohely.TabIndex = 9;
            // 
            // label_ulohely
            // 
            this.label_ulohely.AutoSize = true;
            this.label_ulohely.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_ulohely.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
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
            this.textBox_jelszo2.PasswordChar = '*';
            this.textBox_jelszo2.Size = new System.Drawing.Size(208, 26);
            this.textBox_jelszo2.TabIndex = 7;
            this.textBox_jelszo2.TextChanged += new System.EventHandler(this.textBox_jelszo1_TextChanged);
            // 
            // textBox_jelszo1
            // 
            this.textBox_jelszo1.Location = new System.Drawing.Point(194, 79);
            this.textBox_jelszo1.Name = "textBox_jelszo1";
            this.textBox_jelszo1.PasswordChar = '*';
            this.textBox_jelszo1.Size = new System.Drawing.Size(208, 26);
            this.textBox_jelszo1.TabIndex = 6;
            this.textBox_jelszo1.TextChanged += new System.EventHandler(this.textBox_jelszo1_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(194, 45);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(208, 26);
            this.textBox_email.TabIndex = 5;
            // 
            // label_jelszo2
            // 
            this.label_jelszo2.AutoSize = true;
            this.label_jelszo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_jelszo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label_jelszo2.Location = new System.Drawing.Point(13, 111);
            this.label_jelszo2.Name = "label_jelszo2";
            this.label_jelszo2.Size = new System.Drawing.Size(154, 20);
            this.label_jelszo2.TabIndex = 3;
            this.label_jelszo2.Text = "Jelszó megerősítése";
            // 
            // label_jelszo1
            // 
            this.label_jelszo1.AutoSize = true;
            this.label_jelszo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_jelszo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label_jelszo1.Location = new System.Drawing.Point(13, 79);
            this.label_jelszo1.Name = "label_jelszo1";
            this.label_jelszo1.Size = new System.Drawing.Size(54, 20);
            this.label_jelszo1.TabIndex = 2;
            this.label_jelszo1.Text = "Jelszó";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label_email.Location = new System.Drawing.Point(13, 48);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(48, 20);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email";
            // 
            // textBox_zold
            // 
            this.textBox_zold.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox_zold.Location = new System.Drawing.Point(241, 463);
            this.textBox_zold.Name = "textBox_zold";
            this.textBox_zold.Size = new System.Drawing.Size(27, 26);
            this.textBox_zold.TabIndex = 5;
            this.textBox_zold.Visible = false;
            // 
            // textBox_szurke
            // 
            this.textBox_szurke.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBox_szurke.Location = new System.Drawing.Point(241, 495);
            this.textBox_szurke.Name = "textBox_szurke";
            this.textBox_szurke.Size = new System.Drawing.Size(27, 26);
            this.textBox_szurke.TabIndex = 6;
            this.textBox_szurke.Visible = false;
            // 
            // label_zold
            // 
            this.label_zold.AutoSize = true;
            this.label_zold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label_zold.Location = new System.Drawing.Point(274, 465);
            this.label_zold.Name = "label_zold";
            this.label_zold.Size = new System.Drawing.Size(64, 20);
            this.label_zold.TabIndex = 7;
            this.label_zold.Text = "Szabad";
            this.label_zold.Visible = false;
            // 
            // label_szurke
            // 
            this.label_szurke.AutoSize = true;
            this.label_szurke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label_szurke.Location = new System.Drawing.Point(274, 498);
            this.label_szurke.Name = "label_szurke";
            this.label_szurke.Size = new System.Drawing.Size(57, 20);
            this.label_szurke.TabIndex = 8;
            this.label_szurke.Text = "Foglalt";
            this.label_szurke.Visible = false;
            // 
            // gomb_regi
            // 
            this.gomb_regi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gomb_regi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gomb_regi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gomb_regi.Location = new System.Drawing.Point(120, 195);
            this.gomb_regi.Name = "gomb_regi";
            this.gomb_regi.Size = new System.Drawing.Size(164, 48);
            this.gomb_regi.TabIndex = 12;
            this.gomb_regi.Text = "Regisztráció";
            this.gomb_regi.UseVisualStyleBackColor = false;
            this.gomb_regi.Click += new System.EventHandler(this.button1_Click);
            // 
            // filmvalasztas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label_szurke);
            this.Controls.Add(this.label_zold);
            this.Controls.Add(this.textBox_szurke);
            this.Controls.Add(this.textBox_zold);
            this.Controls.Add(this.panel_reg);
            this.Controls.Add(this.panel_termek);
            this.Controls.Add(this.kivalaszt);
            this.Controls.Add(this.filmeklistbox);
            this.Controls.Add(this.filmlista);
            this.Name = "filmvalasztas";
            this.Size = new System.Drawing.Size(1240, 628);
            this.panel_reg.ResumeLayout(false);
            this.panel_reg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filmlista;
        private System.Windows.Forms.ListBox filmeklistbox;
        private System.Windows.Forms.Button kivalaszt;
        private System.Windows.Forms.Label label_ulohely;
        private System.Windows.Forms.TextBox textBox_jelszo2;
        private System.Windows.Forms.TextBox textBox_jelszo1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_jelszo2;
        private System.Windows.Forms.Label label_jelszo1;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button gomb_kiiras;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Panel panel_reg;
        internal System.Windows.Forms.TextBox textBox_ulohely;
        internal System.Windows.Forms.Panel panel_termek;
        private System.Windows.Forms.TextBox textBox_zold;
        private System.Windows.Forms.TextBox textBox_szurke;
        private System.Windows.Forms.Label label_zold;
        private System.Windows.Forms.Label label_szurke;
        private System.Windows.Forms.Button gomb_regi;
    }
}
