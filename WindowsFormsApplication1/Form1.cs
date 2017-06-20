using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;
        ServiceReference1.CompositeType CT;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new ServiceReference1.Service1Client();
            CT = client.fetchData();
            AddToCombo(CT.StartTime, startBox);
            AddToCombo(CT.StopTime, stopBox);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {

            if (client.checkIfStartCityExists(CT, cityA.Text) && client.checkIfStopCityExists(CT, cityB.Text))
            {
                outBox.Text = "";
                string result = client.findConnection(CT, cityA.Text, cityB.Text, startBox.SelectedItem.ToString(), stopBox.SelectedItem.ToString());
                if(result == "")
                {
                    outBox.Text = "Nie znaleziono połączenia";
                } else
                {
                    outBox.Text = result;
                }
            }
            else
            {
                MessageBox.Show("Podano nie istniejące miasto", "",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AddToCombo(Array array, ComboBox c)
        {
            foreach (var a in array)
            {
                c.Items.Add(a);
            }
            c.SelectedIndex = c.FindStringExact("Żaden");
        }
    }
}
