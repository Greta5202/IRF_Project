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

            Random rnd = new Random();
            int szin = rnd.Next(1, 3);
            if (szin == 1)
            {
                BackColor = Color.White;
            }
            else
            {
                BackColor = Color.Gray;
            }

            if (BackColor == Color.Gray)
            {
                Enabled = false;
            }

            if (BackColor == Color.Green)
            {
                
            }


            MouseClick += Ulohelyek_MouseClick;
        }

        public void Ulohelyek_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.Green;

           
            //int i = 1;

            //if (i % 2 == 1)
            //{
            //    this.BackColor = Color.Green;
            //    i++;
            //}
            //else if (i % 2 == 0)
            //{
            //    this.BackColor = Color.White;
            //    i++;
            //}

            
        }

        
    }
}
