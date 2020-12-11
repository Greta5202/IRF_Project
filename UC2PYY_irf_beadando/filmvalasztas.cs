using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UC2PYY_irf_beadando
{
    public partial class filmvalasztas : UserControl
    {
        private AccountController _controller = new AccountController();

        private bool passwordCheckPassed;
        public bool PasswordCheckPassed
        {
            get { return passwordCheckPassed; }
            set
            {
                passwordCheckPassed = value;
                gomb_regisztralok.Enabled = passwordCheckPassed;
                if (passwordCheckPassed)
                    textBox_jelszo2.BackColor = Color.White;
                else
                    textBox_jelszo2.BackColor = Color.Red;
            }
        }

        public filmvalasztas()
        {
            InitializeComponent();
            PasswordCheckPassed = true;
            dataGridView1.DataSource = _controller.AccountManager.Accounts;
        }

        private void filmlista_Click(object sender, EventArgs e)
        {
            GetMovies1();
        }

        private void GetMovies1()
        {
            string path_of_xml = "xml_filmek.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path_of_xml);
            filmeklistbox.Items.Clear();
            foreach (XmlNode node in doc.ChildNodes)
            {
                if (node.Name == "Filmek")
                {
                    foreach (XmlNode node_of_node in node.ChildNodes)
                    {
                        if (node_of_node.Name == "Film")
                        {
                            string titel = node_of_node["cím"].InnerText;
                            filmeklistbox.Items.Add(titel);
                        }
                    }
                }
            }
        }

        private void filmeklistbox_SelectedValueChanged(object sender, EventArgs e)
        {
            kivalaszt.Enabled = true;
        }

        private void kivalaszt_Click(object sender, EventArgs e)
        {
            if (filmeklistbox.SelectedItem.ToString() == "Sodródás" || filmeklistbox.SelectedItem.ToString() == "Karácsonyi krónikák" || filmeklistbox.SelectedItem.ToString() == "Csaló csajok" || filmeklistbox.SelectedItem.ToString() == "A Wall Street pillangói")
            {
                panel_termek.Visible = true;
                panel_reg.Visible = true;
                egyesterem();
            }
            else
            {
                panel_termek.Visible = true;
                panel_reg.Visible = true;
                kettesterem();
            }
        }

        public void egyesterem()
        {
            //vászon elhelyezése
            vaszon vsz = new vaszon();
            vsz.Location = new System.Drawing.Point(0, 0);
            vsz.Left = panel_termek.Size.Width / 2 - vsz.Size.Width / 2;
            panel_termek.Controls.Add(vsz);

            //helyek elhelyezése
            int lineWidth = 40;
            int sorszam = 1;

            for (int row = 2; row < 10; row++)
            {
                for (int col = 1; col < 7; col++)
                {
                    ulohelyek uh = new ulohelyek();
                    uh.Left = col * uh.Width + (int)(Math.Floor((double)(col / 4))) * lineWidth;
                    uh.Top = row * uh.Height;
                    uh.Text = sorszam++.ToString();
                    panel_termek.Controls.Add(uh);
                }
            }
        }

        public void kettesterem()
        {
            //vászon elhelyezése
            vaszon vsz = new vaszon();
            vsz.Location = new System.Drawing.Point(0, 0);
            vsz.Left = panel_termek.Size.Width / 2 - vsz.Size.Width / 2;
            panel_termek.Controls.Add(vsz);

            //helyek elhelyezése
            int lineWidth = 40;
            int sorszam = 1;
            

            for (int row = 2; row < 10; row++)
            {
                for (int col = 1; col < 7; col++)
                {
                    ulohelyek uh = new ulohelyek();
                    uh.Left = col * uh.Width + (int)(Math.Floor((double)(col / 5))) * lineWidth;
                    uh.Top = row * uh.Height;
                    uh.Text = sorszam++.ToString();
                    panel_termek.Controls.Add(uh);
                }
            } 
        }

        private void textBox_jelszo1_TextChanged(object sender, EventArgs e)
        {
            PasswordCheckPassed = textBox_jelszo1.Text.Equals(textBox_jelszo2.Text);
        }
        
       
        private void gomb_regisztralok_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Register(
                    textBox_email.Text,
                    textBox_jelszo1.Text,
                    textBox_ulohely.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
