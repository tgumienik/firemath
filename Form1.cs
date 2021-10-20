using fireTools;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TymonInformatyka
{
    public partial class Form1 : Form
    {

        private void handleButtonNext(object sender, EventArgs e)
        {
            Control ctr = sender as Control;
            switch (ctr.Name.ToLower().Substring(10))
            {
                case "math":
                    pnlMathList.Show();
                    break;
                case "art":
                    MessageBox.Show("Math.. no Art");
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            lbMathApps.SelectedIndex = 0;
        }

        private void rgb1_ValueChanged(object sender, EventArgs e)
        {

        }

        Timer t1 = new Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 20;
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void guna2ColorTransition1_ValueChanged(object sender, EventArgs e)
        {
            List<Guna2Button> list = new List<Guna2Button>();
            list.Add(((Guna2Button)Controls.Find("guna2Button1", true)[0]));
            foreach (Guna2Button z in list)
            {
                z.FillColor = guna2ColorTransition1.Value;
            }
        }

        private void icoInfo_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "InfoForm")
                    Application.OpenForms[i].Close();
            }
            new InfoForm().Show();
        }

        private void back(object sender, EventArgs e)
        {
            pnlMathList.Hide();
        }

        private void lbMathApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                String description = "";
                Image logo = fireTools.Properties.Resources.ico_polefigury;
                Image screenshot = fireTools.Properties.Resources.preview_polefigury;
                switch (lbMathApps.SelectedItem.ToString().ToLower())
                {
                    case "pole figury":
                        description = "Oblicz pole figury.";
                        logo = fireTools.Properties.Resources.ico_polefigury;
                        screenshot = fireTools.Properties.Resources.preview_polefigury;
                        break;
                    case "konwerter długości":
                        description = "Jardy? Metry? Stopy? Kilometry? Nic nie jast dla tej aplikacji problemem!";
                        logo = fireTools.Properties.Resources.ico_lengthconverter;
                        screenshot = fireTools.Properties.Resources.preview_lengthconverter;
                        break;
                    case "konwerter masy":
                        description = "Bo gram jest za mały do samolotu, a tona za dużo dla ciastka...";
                        logo = fireTools.Properties.Resources.ico_massconverter;
                        screenshot = fireTools.Properties.Resources.preview_massconverter;
                        break;
                    case "konwerter szybkości":
                        description = "Ruch jest ważny. A jego szybkość również.";
                        logo = fireTools.Properties.Resources.ico_speedconverter;
                        screenshot = fireTools.Properties.Resources.preview_speedconverter;
                        break;
                    case "konwerter siły":
                        description = "10000000N zamień na proste 10MN!";
                        logo = fireTools.Properties.Resources.ico_forceconverter;
                        screenshot = fireTools.Properties.Resources.preview_forceconverter;
                        break;
                    case "konwerter temperatur":
                        description = "My używamy stopni Celsjusza, ale co to 91 stopni Fahrenheita?";
                        logo = fireTools.Properties.Resources.ico_temperatureconverter;
                        screenshot = fireTools.Properties.Resources.preview_temperatureconverter;
                        break;
                    case "kalkulator liczby π":
                        description = "Ten program obliczy ją do określonych miejsc po przecinku.";
                        logo = fireTools.Properties.Resources.ico_piculator;
                        screenshot = fireTools.Properties.Resources.preview_piculator;
                        break;
                }
                label2.Text = lbMathApps.SelectedItem.ToString();
                label3.Text = description;
                guna2CirclePictureBox1.Image = logo;
                pictureBox1.Image = screenshot;
            } catch
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name.ToLower() == "firemath | " + lbMathApps.SelectedItem.ToString().ToLower())
                    Application.OpenForms[i].Close();
            }
            switch (lbMathApps.SelectedItem.ToString().ToLower())
            {
                case "pole figury":
                    new Math_PoleFigury().Show();
                    break;
                case "konwerter długości":
                    new Math_KonwerterDlugosci().Show();
                    break;
                case "konwerter masy":
                    new Math_KonwerterMasy().Show();
                    break;
                case "konwerter szybkości":
                    new Math_KonwerterSzybkosci().Show();
                    break;
                case "konwerter siły":
                    new Math_KonwerterSily().Show();
                    break;
                case "konwerter temperatur":
                    new Math_KonwerterTemperatury().Show();
                    break;
                case "kalkulator liczby π":
                    new Math_PICulator().Show();
                    break;
            }
        }
    }
}
