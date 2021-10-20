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
    public partial class Math_KonwerterTemperatury : Form
    {

        string[] units = {
            "°C (stopnie Celsjusza)",
            "°F (stopnie Fahrenheita)",
            "K (Kelwiny)",
            "°R (skala Rankine'a)",
            "°Ré (skala Réaumura)",
        };

        private string GetDisplay()
        {
            if (guna2ComboBox1.SelectedItem != null) return guna2ComboBox1.SelectedItem.ToString().Split(' ')[0];
            return "";
        }

        public Math_KonwerterTemperatury()
        {
            InitializeComponent();

            guna2ComboBox1.Items.AddRange(units);
            guna2ComboBox2.Items.AddRange(units);

            guna2ComboBox1.SelectedIndex = 0;
            guna2ComboBox2.SelectedIndex = 1;

            Recalculate();
        }

        private void Recalculate()
        {
            try
            {
                double celsius = ConvertToCelcius(guna2ComboBox1.SelectedIndex, double.Parse(guna2TextBox1.Text));
                double result = celsius;

                if(guna2ComboBox2.SelectedIndex == 1) result = new UnitOf.Temperature().FromCelsius(celsius).ToFahrenheit();
                else if(guna2ComboBox2.SelectedIndex == 2) result = new UnitOf.Temperature().FromCelsius(celsius).ToKelvin();
                else if(guna2ComboBox2.SelectedIndex == 3) result = new UnitOf.Temperature().FromCelsius(celsius).ToRankine();
                else if(guna2ComboBox2.SelectedIndex == 4) result = new UnitOf.Temperature().FromCelsius(celsius).ToReaumur();

                guna2TextBox2.Text = result + String.Empty;
            } catch
            {
                guna2TextBox2.Text = "Wykryto niepoprawną liczbę.";
            }
        }

        private double ConvertToCelcius(int index, double value)
        {
            switch (index)
            {
                case 0:
                    return value;
                case 1:
                    return new UnitOf.Temperature().FromFahrenheit(value).ToCelsius();
                case 2:
                    return new UnitOf.Temperature().FromKelvin(value).ToCelsius();
                case 3:
                    return new UnitOf.Temperature().FromRankine(value).ToCelsius();
                case 4:
                    return new UnitOf.Temperature().FromReaumur(value).ToCelsius();
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
