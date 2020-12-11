namespace UC2PYY_irf_beadando
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.helyfoglalo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(106, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 536);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üdvözöljük az Galaxy mozi honlapján! Helyfoglaláshoz kérem nyomja az alábbi gombo" +
    "t:";
            // 
            // helyfoglalo
            // 
            this.helyfoglalo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helyfoglalo.BackColor = System.Drawing.Color.Black;
            this.helyfoglalo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helyfoglalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helyfoglalo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.helyfoglalo.Location = new System.Drawing.Point(800, 83);
            this.helyfoglalo.Name = "helyfoglalo";
            this.helyfoglalo.Size = new System.Drawing.Size(200, 34);
            this.helyfoglalo.TabIndex = 2;
            this.helyfoglalo.Text = "Helyfoglalás";
            this.helyfoglalo.UseVisualStyleBackColor = false;
            this.helyfoglalo.Click += new System.EventHandler(this.helyfoglalo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 691);
            this.Controls.Add(this.helyfoglalo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helyfoglalo;
    }
}

