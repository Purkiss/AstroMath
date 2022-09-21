using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.ServiceModel;
using System.Collections;

// Zac Purkiss (P444025)
// 19/09/2022
// AT2 AstroMathGUI
// A program that connects to a server that references a dll to return answers to astronomical math questions regarding star velocity, star distance, temperature and event horizons.

/*
2.	Create a form with suitable components for UI,
a. Series of textboxes for large numeric data,
b.	Series of textbox/listbox/listview for display of processed information from the server,
c.	Button(s) to initiate an event and send/receive data.
*/

namespace AstroMathGUI
{
    public partial class AstroMathGUI : Form
    {
        
        IAstroContact channel = ChannelFactory<IAstroContact>.CreateChannel(new NetNamedPipeBinding(NetNamedPipeSecurityMode.None)
            , new EndpointAddress("net.pipe://localhost/PipeAstro"));
        bool darkMode = false;
        ArrayList starVelocityList = new ArrayList();
        ArrayList starDistanceList = new ArrayList();
        ArrayList tempKelvinList = new ArrayList();
        ArrayList eventHorizonList = new ArrayList();

        public AstroMathGUI()
        {
            InitializeComponent();
        }


        // 3.	Menu options to change the language and layout for the three different countries
        private void EnglishUKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("fr");
        }

        private void GermanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("de");
        }

        private void ChangeLanguage(string lang)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AstroMathGUI));

            foreach (Control a in this.Controls)
            {
                resources.ApplyResources(a, a.Name, new CultureInfo(lang));
                if (a is GroupBox)
                {
                    foreach (Control c in a.Controls)
                    {
                        resources.ApplyResources(c, c.Name, new CultureInfo(lang));
                    }
                }
            }
            foreach (ToolStripMenuItem c in menuStrip1.Items)
            {
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
                foreach (ToolStripMenuItem a in c.DropDownItems)
                {
                    resources.ApplyResources(a, a.Name, new CultureInfo(lang));
                }
            }
        }


        // 4.	Menu options to change the form’s theme (colours and visual appearance).
        private void ChooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colDialog = new ColorDialog();
            if (colDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = colDialog.Color;
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColour(Color.Black);
        }

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColour(Color.White);
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColour(Color.Red);
        }

        private void ChangeForeColour(Color c)
        {
            this.ForeColor = c;
            foreach (Control x in this.Controls)
            {
                if (x.GetType() == typeof(GroupBox))
                {
                    x.ForeColor = c;
                }
            }
        }

        private void DarkLightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkMode == true)
            {
                ChangeForeColour(Color.Black);
                this.BackColor = Color.White;
                darkMode = false;
            }
            else if (darkMode == false)
            {
                ChangeForeColour(Color.White);
                this.BackColor = Color.Black;
                darkMode = true;
            }
        }


        private void DisplayData()
        {
            dataView.Items.Clear();
            int length = Math.Max(Math.Max(Math.Max(starVelocityList.Count, starDistanceList.Count), tempKelvinList.Count), eventHorizonList.Count);
            for (int i = 0; i < length; i++)
            {
                ListViewItem item = new ListViewItem();

                if (starVelocityList.Count > i)
                    item.Text = starVelocityList[i].ToString();
                else
                    item.Text = " ";

                if (starDistanceList.Count > i)
                    item.SubItems.Add(starDistanceList[i].ToString());
                else
                    item.SubItems.Add(" ");

                if (tempKelvinList.Count > i)
                    item.SubItems.Add(tempKelvinList[i].ToString());
                else
                    item.SubItems.Add(" ");

                if (eventHorizonList.Count > i)
                    item.SubItems.Add(eventHorizonList[i].ToString());
                else
                    item.SubItems.Add(" ");

                dataView.Items.Add(item);
            }
        }

        private void StarVelocityButton_Click(object sender, EventArgs e)
        {
            if (observedBox.Text != "" && restBox.Text != "" && observedBox.Text != "." && restBox.Text != "." && observedBox.Text != "-" && restBox.Text != "-")
            {
                if (double.Parse(observedBox.Text) >= 0 && double.Parse(restBox.Text) >= 0)
                    starVelocityList.Add(Math.Round(channel.StarVelocity(double.Parse(observedBox.Text), double.Parse(restBox.Text)), 4));
                DisplayData();
            }
        }

        private void StarDistanceButton_Click(object sender, EventArgs e)
        {
            if (parallaxBox.Text != "" && parallaxBox.Text != "." && parallaxBox.Text != "-")
            {
                if (double.Parse(parallaxBox.Text) >= 0 && double.Parse(parallaxBox.Text) <= 1)
                    starDistanceList.Add(Math.Round(channel.StarDistance(double.Parse(parallaxBox.Text)), 4));
                DisplayData();
            }
        }

        private void TempButton_Click(object sender, EventArgs e)
        {
            if (tempBox.Text != "" && tempBox.Text != "." && tempBox.Text != "-")
            {
                if (double.Parse(tempBox.Text) > -273.15)
                    tempKelvinList.Add(Math.Round(channel.TempKelvin(double.Parse(tempBox.Text)), 4));
                DisplayData();
            }
        }

        private void EventHorizonButton_Click(object sender, EventArgs e)
        {
            if (massBox.Text != "" && massBox.Text != "." && massBox.Text != "-")
            {
                if (double.Parse(massBox.Text) >= 1 && double.Parse(massBox.Text) < 10)
                {
                    double results = channel.EventHorizon(double.Parse(massBox.Text) * (Math.Pow(10, double.Parse(massExponent.Text))));
                    int power = 0;
                    while (results >= 10)
                    {
                        results = results / 10;
                        power++;
                    }
                    string result = Math.Round(results, 2) + "E" + power;
                    eventHorizonList.Add(result);
                }
            }
            DisplayData();
        }

        private void ObservedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyInput(sender, e);
        }

        private void RestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyInput(sender, e);
        }

        private void ParallaxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyInput(sender, e);
        }

        private void TempBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyInput(sender, e);
        }

        private void MassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyInput(sender, e);
        }

        // allows only numeric inputs, with a single decimal place as well as limiting a negative sign to only the first character
        private void VerifyInput(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != '-'))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }
    }
}
