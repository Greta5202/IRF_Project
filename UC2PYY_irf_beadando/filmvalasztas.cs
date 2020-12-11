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
        public filmvalasztas()
        {
            InitializeComponent();
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
                egyesterem();
            }
            else
            {
                panel_termek.Visible = true;
                kettesterem();
            }
        }

        private void egyesterem()
        {
        }

        private void kettesterem()
        {
        }
    }
}
