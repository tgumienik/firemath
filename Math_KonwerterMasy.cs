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
    public partial class Math_KonwerterMasy : Form
    {

        string[] units = {
            "μg (mikrogramy)",
            "mg (miligramy)",
            "g (gramy)",
            "dag (dekagramy)",
            "kg (kilogramy)",
            "q (centary)",
            "t (tony metryczne)",
            "kt (kilotony metryczne)",
            "oz (uncje metryczne)",
            "oz (uncje amerykańskie)",
            "lb (funty)",
        };

        private string GetDisplay()
        {
            if (guna2ComboBox1.SelectedItem != null) return guna2ComboBox1.SelectedItem.ToString().Split(' ')[0];
            return "";
        }

        public Math_KonwerterMasy()
        {
            InitializeComponent();

            guna2ComboBox1.Items.AddRange(units);
            guna2ComboBox2.Items.AddRange(units);

            guna2ComboBox1.SelectedIndex = 5;
            guna2ComboBox2.SelectedIndex = 4;

            Recalculate();
        }

        private void Recalculate()
        {
            try
            {
                double grams = ConvertToGrams(guna2ComboBox1.SelectedIndex, double.Parse(guna2TextBox1.Text));
                double result = grams;

                if(guna2ComboBox2.SelectedIndex == 0) result = new UnitOf.Mass().FromGrams(grams).ToMicrograms();
                else if(guna2ComboBox2.SelectedIndex == 1) result = new UnitOf.Mass().FromGrams(grams).ToMilligrams();
                else if(guna2ComboBox2.SelectedIndex == 3) result = new UnitOf.Mass().FromGrams(grams).ToDekagrams();
                else if(guna2ComboBox2.SelectedIndex == 4) result = new UnitOf.Mass().FromGrams(grams).ToKilograms();
                else if(guna2ComboBox2.SelectedIndex == 5) result = new UnitOf.Mass().FromGrams(grams).ToCentners();
                else if(guna2ComboBox2.SelectedIndex == 6) result = new UnitOf.Mass().FromGrams(grams).ToTonsMetric();
                else if(guna2ComboBox2.SelectedIndex == 7) result = new UnitOf.Mass().FromGrams(grams).ToKilotonsMetric();
                else if(guna2ComboBox2.SelectedIndex == 8) result = new UnitOf.Mass().FromGrams(grams).ToOuncesMetric();
                else if(guna2ComboBox2.SelectedIndex == 9) result = new UnitOf.Mass().FromGrams(grams).ToOuncesUS();
                else if(guna2ComboBox2.SelectedIndex == 10) result = new UnitOf.Mass().FromGrams(grams).ToPounds();

                guna2TextBox2.Text = result + String.Empty;
            } catch
            {
                guna2TextBox2.Text = "Wykryto niepoprawną liczbę.";
            }
        }

        private double ConvertToGrams(int index, double value)
        {
            switch (index)
            {
                case 0:
                    return new UnitOf.Mass().FromMicrograms(value).ToGrams();
                case 1:
                    return new UnitOf.Mass().FromMilligrams(value).ToGrams();
                case 2:
                    return value;
                case 3:
                    return new UnitOf.Mass().FromDekagrams(value).ToGrams();
                case 4:
                    return new UnitOf.Mass().FromKilograms(value).ToGrams();
                case 5:
                    return new UnitOf.Mass().FromCentners(value).ToGrams();
                case 6:
                    return new UnitOf.Mass().FromTonsMetric(value).ToGrams();
                case 7:
                    return new UnitOf.Mass().FromKilotonsMetric(value).ToGrams();
                case 8:
                    return new UnitOf.Mass().FromOuncesMetric(value).ToGrams();
                case 9:
                    return new UnitOf.Mass().FromOuncesUS(value).ToGrams();
                case 10:
                    return new UnitOf.Mass().FromPounds(value).ToGrams();
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
