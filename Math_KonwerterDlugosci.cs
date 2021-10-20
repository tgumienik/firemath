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
    public partial class Math_KonwerterDlugosci : Form
    {

        string[] units = {
            "nm (nanometry)",
            "μm (mikrometry)",
            "mm (milimetry)",
            "cm (centymetry)",
            "dm (decymetry)",
            "m (metry)",
            "km (kilometry)",
            "mi (mile)",
            "ft (stopy)",
            "in (cale)",
            "yd (jardy)"
        };

        private string GetDisplay()
        {
            if (guna2ComboBox1.SelectedItem != null) return guna2ComboBox1.SelectedItem.ToString().Split(' ')[0];
            return "";
        }

        public Math_KonwerterDlugosci()
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
                double meters = ConvertToMeters(guna2ComboBox1.SelectedIndex, double.Parse(guna2TextBox1.Text));
                double result = meters;

                if(guna2ComboBox2.SelectedIndex == 0) result = new UnitOf.Length().FromMeters(meters).ToNanometers();
                else if(guna2ComboBox2.SelectedIndex == 1) result = new UnitOf.Length().FromMeters(meters).ToMicrometers();
                else if(guna2ComboBox2.SelectedIndex == 2) result = new UnitOf.Length().FromMeters(meters).ToMillimeters();
                else if(guna2ComboBox2.SelectedIndex == 3) result = new UnitOf.Length().FromMeters(meters).ToCentimeters();
                else if(guna2ComboBox2.SelectedIndex == 4) result = new UnitOf.Length().FromMeters(meters).ToDecimeters();
                else if(guna2ComboBox2.SelectedIndex == 6) result = new UnitOf.Length().FromMeters(meters).ToKilometers();
                else if(guna2ComboBox2.SelectedIndex == 7) result = new UnitOf.Length().FromMeters(meters).ToMiles();
                else if(guna2ComboBox2.SelectedIndex == 8) result = new UnitOf.Length().FromMeters(meters).ToFeet();
                else if(guna2ComboBox2.SelectedIndex == 9) result = new UnitOf.Length().FromMeters(meters).ToInches();
                else if(guna2ComboBox2.SelectedIndex == 10) result = new UnitOf.Length().FromMeters(meters).ToYards();

                guna2TextBox2.Text = result + String.Empty;
            } catch
            {
                guna2TextBox2.Text = "Wykryto niepoprawną liczbę.";
            }
        }

        private double ConvertToMeters(int index, double value)
        {
            switch (index)
            {
                case 0:
                    return new UnitOf.Length().FromNanometers(value).ToMeters();
                case 1:
                    return new UnitOf.Length().FromMicrometers(value).ToMeters();
                case 2:
                    return new UnitOf.Length().FromMillimeters(value).ToMeters();
                case 3:
                    return new UnitOf.Length().FromCentimeters(value).ToMeters();
                case 4:
                    return new UnitOf.Length().FromDecimeters(value).ToMeters();
                case 5:
                    return value;
                case 6:
                    return new UnitOf.Length().FromKilometers(value).ToMeters();
                case 7:
                    return new UnitOf.Length().FromMiles(value).ToMeters();
                case 8:
                    return new UnitOf.Length().FromFeet(value).ToMeters();
                case 9:
                    return new UnitOf.Length().FromInches(value).ToMeters();
                case 10:
                    return new UnitOf.Length().FromYards(value).ToMeters();
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
