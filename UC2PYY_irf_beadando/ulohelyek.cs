using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC2PYY_irf_beadando
{
    class ulohelyek : Button
    {
        
        public ulohelyek()
        {
            Height = 30;
            Width = Height;
            Enabled = false;

            Random rnd = new Random();
            int szin = rnd.Next(1, 3);
            if (szin == 1)
            {
                BackColor = Color.White;
            }
            else
            {
                BackColor = Color.Green;
            }

        }
    }
}
