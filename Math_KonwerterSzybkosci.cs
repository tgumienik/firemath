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
    public partial class Math_KonwerterSzybkosci : Form
    {
        string[] units = {
            "cm/h (centymetry na godzinę)",
            "cm/min (centrymetry na minutę)",
            "cm/s (centrymetry na sekundę)",
            "ft/h (stopy na godzinę)",
            "ft/min (stopy na minutę)",
            "ft/s (stopy na sekundę)",
            "in/h (cale na godzinę)",
            "in/min (cale na minutę)",
            "in/s (cale na sekundę)",
            "km/h (kilometry na godzinę)",
            "km/min (kilometry na minutę)",
            "km/s (kilometry na sekundę)",
            "m/h (metry na godzinę)",
            "m/min (metry na minutę)",
            "m/s (metry na sekundę)",
            "mi/h (mile na godzinę)",
            "mi/min (mile na minutę)",
            "mi/s (mile na sekundę)",
            "mm/h (milimetry na godzinę)",
            "mm/min (milimetry na minutę)",
            "mm/s (milimetry na sekundę)",
            "yd/h (jardy na godzinę)",
            "yd/min (jardy na minutę)",
            "yd/s (jardy na sekundę)",
        };

        private string GetDisplay()
        {
            if (guna2ComboBox1.SelectedItem != null) return guna2ComboBox1.SelectedItem.ToString().Split(' ')[0];
            return "";
        }

        public Math_KonwerterSzybkosci()
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
                double meterspersec = ConvertToMetersPerSec(guna2ComboBox1.SelectedIndex, double.Parse(guna2TextBox1.Text));
                double result = meterspersec;

                if (guna2ComboBox2.SelectedIndex == 0) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToCentimetersPerHour();
                else if (guna2ComboBox2.SelectedIndex == 1) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToCentimetersPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 2) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToCentimetersPerSecond();
                else if (guna2ComboBox2.SelectedIndex == 3) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToFeetPerHour();
                else if (guna2ComboBox2.SelectedIndex == 4) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToFeetPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 5) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToFeetPerSecond();
                else if (guna2ComboBox2.SelectedIndex == 6) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToInchesPerHour();
                else if (guna2ComboBox2.SelectedIndex == 7) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToInchesPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 8) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToInchesPerSecond();
                else if (guna2ComboBox2.SelectedIndex == 9) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToKilometersPerHour();
                else if (guna2ComboBox2.SelectedIndex == 10) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToKilometersPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 11) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToKilometersPerSecond();
                else if (guna2ComboBox2.SelectedIndex == 12) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMetersPerHour();
                else if (guna2ComboBox2.SelectedIndex == 13) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMetersPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 15) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMilesPerHour();
                else if (guna2ComboBox2.SelectedIndex == 16) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMilesPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 17) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMilesPerSecond();
                else if (guna2ComboBox2.SelectedIndex == 18) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMillimetersPerHour();
                else if (guna2ComboBox2.SelectedIndex == 19) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMillimetersPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 20) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToMillimetersPerSecond();
                else if (guna2ComboBox2.SelectedIndex == 21) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToYardsPerHour();
                else if (guna2ComboBox2.SelectedIndex == 22) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToYardsPerMinute();
                else if (guna2ComboBox2.SelectedIndex == 23) result = new UnitOf.Speed().FromMetersPerSecond(meterspersec).ToYardsPerSecond();

                guna2TextBox2.Text = result + String.Empty;
            } catch
            {
                guna2TextBox2.Text = "Wykryto niepoprawną liczbę.";
            }
        }

        private double ConvertToMetersPerSec(int index, double value)
        {
            switch (index)
            {
                case 0:
                    return new UnitOf.Speed().FromCentimetersPerHour(value).ToMetersPerSecond();
                case 1:
                    return new UnitOf.Speed().FromCentimetersPerMinute(value).ToMetersPerSecond();
                case 2:
                    return new UnitOf.Speed().FromCentimetersPerSecond(value).ToMetersPerSecond();
                case 3:
                    return new UnitOf.Speed().FromFeetPerHour(value).ToMetersPerSecond();
                case 4:
                    return new UnitOf.Speed().FromFeetPerMinute(value).ToMetersPerSecond();
                case 5:
                    return new UnitOf.Speed().FromFeetPerSecond(value).ToMetersPerSecond();
                case 6:
                    return new UnitOf.Speed().FromInchesPerHour(value).ToMetersPerSecond();
                case 7:
                    return new UnitOf.Speed().FromInchesPerMinute(value).ToMetersPerSecond();
                case 8:
                    return new UnitOf.Speed().FromInchesPerSecond(value).ToMetersPerSecond();
                case 9:
                    return new UnitOf.Speed().FromKilometersPerHour(value).ToMetersPerSecond();
                case 10:
                    return new UnitOf.Speed().FromKilometersPerMinute(value).ToMetersPerSecond();
                case 11:
                    return new UnitOf.Speed().FromKilometersPerSecond(value).ToMetersPerSecond();
                case 12:
                    return new UnitOf.Speed().FromMetersPerHour(value).ToMetersPerSecond();
                case 13:
                    return new UnitOf.Speed().FromMetersPerMinute(value).ToMetersPerSecond();
                case 14:
                    return value;
                case 15:
                    return new UnitOf.Speed().FromMilesPerHour(value).ToMetersPerSecond();
                case 16:
                    return new UnitOf.Speed().FromMilesPerMinute(value).ToMetersPerSecond();
                case 17:
                    return new UnitOf.Speed().FromMilesPerSecond(value).ToMetersPerSecond();
                case 18:
                    return new UnitOf.Speed().FromMillimetersPerHour(value).ToMetersPerSecond();
                case 19:
                    return new UnitOf.Speed().FromMillimetersPerMinute(value).ToMetersPerSecond();
                case 20:
                    return new UnitOf.Speed().FromMillimetersPerSecond(value).ToMetersPerSecond();
                case 21:
                    return new UnitOf.Speed().FromYardsPerHour(value).ToMetersPerSecond();
                case 22:
                    return new UnitOf.Speed().FromYardsPerMinute(value).ToMetersPerSecond();
                case 23:
                    return new UnitOf.Speed().FromYardsPerSecond(value).ToMetersPerSecond();
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
