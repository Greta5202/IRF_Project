﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC2PYY_irf_beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Left = panel1.Size.Width / 2 - label1.Size.Width / 2;
            helyfoglalo.Left = panel1.Size.Width / 2 - label1.Size.Width / 2;
        }

        private void helyfoglalo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl filmvalasztas = new filmvalasztas();
            panel1.Controls.Add(filmvalasztas);
            filmvalasztas.Dock = DockStyle.Fill;
        }
    }
}
