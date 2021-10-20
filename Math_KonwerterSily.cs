using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fireTools
{
    public partial class Math_KonwerterSily : Form
    {

        string[] units = {
            "aN (attoniutony)",
            "cN (centiniutony)",
            "dN (deciniutony)",
            "daN (dekaniutony)",
            "EN (exaniutony)",
            "fN (femtoniutony)",
            "GN (giganiutony)",
            "hN (hektoniutony)",
            "kN (kiloniutony)",
            "MN (meganiutony)",
            "µN (mikroniutony)",
            "nN (nanoniutony)",
            "PN (petaniutony)",
            "pN (pikoniutony)",
            "N (niutony)",
        };

        private string GetDisplay()
        {
            if (guna2ComboBox1.SelectedItem != null) return guna2ComboBox1.SelectedItem.ToString().Split(' ')[0];
            return "";
        }

        public Math_KonwerterSily()
        {
            InitializeComponent();

            guna2ComboBox1.Items.AddRange(units);
            guna2ComboBox2.Items.AddRange(units);

            guna2ComboBox1.SelectedIndex = 14;
            guna2ComboBox2.SelectedIndex = 12;

            Recalculate();
        }

        private void Recalculate()
        {
            try
            {
                double newtons = ConvertToNewtons(guna2ComboBox1.SelectedIndex, double.Parse(guna2TextBox1.Text));
                double result = newtons;

                if(guna2ComboBox2.SelectedIndex == 0) result = new UnitOf.Force().FromNewtons(newtons).ToAttonewtons();
                else if(guna2ComboBox2.SelectedIndex == 1) result = new UnitOf.Force().FromNewtons(newtons).ToCentinewtons();
                else if(guna2ComboBox2.SelectedIndex == 2) result = new UnitOf.Force().FromNewtons(newtons).ToDecinewtons();
                else if(guna2ComboBox2.SelectedIndex == 3) result = new UnitOf.Force().FromNewtons(newtons).ToDekanewtons();
                else if(guna2ComboBox2.SelectedIndex == 4) result = new UnitOf.Force().FromNewtons(newtons).ToExanewtons();
                else if(guna2ComboBox2.SelectedIndex == 5) result = new UnitOf.Force().FromNewtons(newtons).ToFemtonewtons();
                else if(guna2ComboBox2.SelectedIndex == 6) result = new UnitOf.Force().FromNewtons(newtons).ToGiganewtons();
                else if(guna2ComboBox2.SelectedIndex == 7) result = new UnitOf.Force().FromNewtons(newtons).ToHectonewtons();
                else if(guna2ComboBox2.SelectedIndex == 8) result = new UnitOf.Force().FromNewtons(newtons).ToKilonewtons();
                else if(guna2ComboBox2.SelectedIndex == 9) result = new UnitOf.Force().FromNewtons(newtons).ToMeganewtons();
                else if(guna2ComboBox2.SelectedIndex == 10) result = new UnitOf.Force().FromNewtons(newtons).ToMicronewtons();
                else if(guna2ComboBox2.SelectedIndex == 11) result = new UnitOf.Force().FromNewtons(newtons).ToMillinewtons();
                else if(guna2ComboBox2.SelectedIndex == 12) result = new UnitOf.Force().FromNewtons(newtons).ToNanonewtons();
                else if(guna2ComboBox2.SelectedIndex == 13) result = new UnitOf.Force().FromNewtons(newtons).ToPetanewtons();
                else if(guna2ComboBox2.SelectedIndex == 14) result = new UnitOf.Force().FromNewtons(newtons).ToPiconewtons();

                guna2TextBox2.Text = result + String.Empty;
            } catch
            {
                guna2TextBox2.Text = "Wykryto niepoprawną liczbę.";
            }
        }

        private double ConvertToNewtons(int index, double value)
        {
            switch (index)
            {
                case 0:
                    return new UnitOf.Force().FromAttonewtons(value).ToNewtons();
                case 1:
                    return new UnitOf.Force().FromCentinewtons(value).ToNewtons();
                case 2:
                    return new UnitOf.Force().FromDecinewtons(value).ToNewtons();
                case 3:
                    return new UnitOf.Force().FromDekanewtons(value).ToNewtons();
                case 4:
                    return new UnitOf.Force().FromExanewtons(value).ToNewtons();
                case 5:
                    return new UnitOf.Force().FromFemtonewtons(value).ToNewtons();
                case 6:
                    return new UnitOf.Force().FromGiganewtons(value).ToNewtons();
                case 7:
                    return new UnitOf.Force().FromHectonewtons(value).ToNewtons();
                case 8:
                    return new UnitOf.Force().FromKilonewtons(value).ToNewtons();
                case 9:
                    return new UnitOf.Force().FromMeganewtons(value).ToNewtons();
                case 10:
                    return new UnitOf.Force().FromMicronewtons(value).ToNewtons();
                case 11:
                    return new UnitOf.Force().FromMillinewtons(value).ToNewtons();
                case 12:
                    return new UnitOf.Force().FromNanonewtons(value).ToNewtons();
                case 13:
                    return new UnitOf.Force().FromPetanewtons(value).ToNewtons();
                case 14:
                    return new UnitOf.Force().FromPiconewtons(value).ToNewtons();
                case 15:
                    return value;
            }
            return 0;
        }

        private void antiText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
        && (e.KeyChar != ',') && (e.KeyChar != '-'))
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(",") > -1)
                e.Handled = true;

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as Guna.UI2.WinForms.Guna2TextBox).Text.Length > 0)
                e.Handled = true;
        }

        private void guna2ComboBox1_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recalculate();
        }
    }
}
