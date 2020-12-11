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
            // 
            // kivalaszt
            // 
            this.kivalaszt.Location = new System.Drawing.Point(38, 247);
            this.kivalaszt.Name = "kivalaszt";
            this.kivalaszt.Size = new System.Drawing.Size(164, 48);
            this.kivalaszt.TabIndex = 2;
            this.kivalaszt.Text = "Tovább!";
            this.kivalaszt.UseVisualStyleBackColor = true;
            // 
            // filmvalasztas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kivalaszt);
            this.Controls.Add(this.filmeklistbox);
            this.Controls.Add(this.filmlista);
            this.Name = "filmvalasztas";
            this.Size = new System.Drawing.Size(1240, 628);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filmlista;
        private System.Windows.Forms.ListBox filmeklistbox;
        private System.Windows.Forms.Button kivalaszt;
    }
}
