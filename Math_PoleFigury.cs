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
    public partial class Math_PoleFigury : Form
    {
        double pi = 3.14159265358979323846;
        string[] from = {
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

        string[] to = {
            "nm² (nanometry kwadratowe)",
            "μm² (mikrometry kwadratowe)",
            "mm² (milimetry kwadratowe)",
            "cm² (centymetry kwadratowe)",
            "dm² (decymetry kwadratowe)",
            "m² (metry kwadratowe)",
            "km² (kilometry kwadratowe)",
            "mi² (mile kwadratowe)",
            "ft² (stopy kwadratowe)",
            "in² (cale kwadratowe)",
            "ha (hektary)",
            "a (ary)",
            "yd² (jardy kwadratowe)",
        };

        public Math_PoleFigury()
        {
            InitializeComponent();

            guna2ComboBox2.Items.AddRange(from);
            guna2ComboBox3.Items.AddRange(from);
            guna2ComboBox5.Items.AddRange(from);

            guna2ComboBox4.Items.AddRange(to);

            guna2ComboBox1.SelectedIndex = 0;
            guna2ComboBox2.SelectedIndex = 5;
            guna2ComboBox3.SelectedIndex = 5;
            guna2ComboBox4.SelectedIndex = 5;
            guna2ComboBox5.SelectedIndex = 5;

            CalculateTriangle(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text));
            UpdateUI();
        }

        public void setVis(Color c, bool val)
        {
            if (c == Color.Blue)
            {
                pictureBox1.Visible = val;
                guna2TextBox1.Visible = val;
                guna2ComboBox1.Visible = val;
            } else if (c == Color.Red)
            {
                pictureBox3.Visible = val;
                guna2TextBox2.Visible = val;
                guna2ComboBox3.Visible = val;
            } else if (c == Color.Green)
            {
                pictureBox4.Visible = val;
                guna2TextBox3.Visible = val;
                guna2ComboBox5.Visible = val;
            }
}

        public void UpdateUI()
        {
            //Trójkąt
            //Kwadrat
            //Prostokąt
            //Równoległobok
            //Romb(przekątne)
            //Romb(boki)
            //Trapez
            //Deltoid
            //Koło
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, true);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_triangle;
                    break;
                case 1:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, false);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_square;
                    break;
                case 2:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, true);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_rectangle;
                    break;
                case 3:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, true);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_parallelogram;
                    break;
                case 4:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, true);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_rhombus;
                    break;
                case 5:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, true);
                    setVis(Color.Green, true);
                    pictureBox1.Image = Properties.Resources.figura_trapeze;
                    break;
                case 6:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, true);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_kite;
                    break;
                case 7:
                    setVis(Color.Blue, true);
                    setVis(Color.Red, false);
                    setVis(Color.Green, false);
                    pictureBox1.Image = Properties.Resources.figura_circle;
                    break;
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

        private double ConvertToSquareResult(int index, double value)
        {
            switch (index)
            {
                case 0:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareNanometers();
                case 1:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareMicrometers();
                case 2:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareMillimeters();
                case 3:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareCentimeters();
                case 4:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareDecimeters();
                case 5:
                    return value;
                case 6:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareKilometers();
                case 7:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareMiles();
                case 8:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareFeet();
                case 9:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareInches();
                case 10:
                    return new UnitOf.Area().FromSquareMeters(value).ToHectares();
                case 11:
                    return new UnitOf.Area().FromSquareMeters(value).ToAres();
                case 12:
                    return new UnitOf.Area().FromSquareMeters(value).ToSquareYards();
            }
            return 0;
        }

        private string GetSquareDisplay()
        {
            if(guna2ComboBox4.SelectedItem != null) return guna2ComboBox4.SelectedItem.ToString().Split(' ')[0];
            return "";
        }

        public void CalculateCircle(double blue)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);

            double resultMeters = pi * (blueMeters * blueMeters);
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateKite(double blue, double red)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);
            double redMeters = ConvertToMeters(guna2ComboBox3.SelectedIndex, red);

            double resultMeters = (blueMeters * redMeters) / 2;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateRhombus(double blue, double red)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);
            double redMeters = ConvertToMeters(guna2ComboBox3.SelectedIndex, red);

            double resultMeters = (blueMeters * redMeters) / 2;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateTriangle(double blue, double red)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);
            double redMeters = ConvertToMeters(guna2ComboBox3.SelectedIndex, red);

            double resultMeters = (blueMeters * redMeters) / 2;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateTrapeze(double blue, double red, double green)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);
            double redMeters = ConvertToMeters(guna2ComboBox3.SelectedIndex, red);
            double greenMeters = ConvertToMeters(guna2ComboBox5.SelectedIndex, green);

            double resultMeters = ((blueMeters + redMeters) * greenMeters) / 2;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateParallelogram(double blue, double red)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);
            double redMeters = ConvertToMeters(guna2ComboBox3.SelectedIndex, red);

            double resultMeters = blueMeters * redMeters;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateRectangle(double blue, double red)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);
            double redMeters = ConvertToMeters(guna2ComboBox3.SelectedIndex, red);

            double resultMeters = blueMeters * redMeters;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        public void CalculateSquare(double blue)
        {
            double blueMeters = ConvertToMeters(guna2ComboBox2.SelectedIndex, blue);

            double resultMeters = blueMeters * blueMeters;
            double finalResult = ConvertToSquareResult(guna2ComboBox4.SelectedIndex, resultMeters);

            label3.Text = finalResult + " " + GetSquareDisplay();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = fireTools.Properties.Resources.figura_triangle;
                    break;
            }
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void Recalculate()
        {
            if (guna2TextBox1.Text.Length == 0 || guna2TextBox2.Text.Length == 0)
            {
                label3.Text = "";
            } else
            {
                try {
                    switch (guna2ComboBox1.SelectedIndex)
                    {
                        case 0:
                            CalculateTriangle(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text));
                            break;
                        case 1:
                            CalculateSquare(double.Parse(guna2TextBox1.Text));
                            break;
                        case 2:
                            CalculateRectangle(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text));
                            break;
                        case 3:
                            CalculateParallelogram(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text));
                            break;
                        case 4:
                            CalculateRhombus(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text));
                            break;
                        case 5:
                            CalculateTrapeze(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text), double.Parse(guna2TextBox3.Text));
                            break;
                        case 6:
                            CalculateKite(double.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text));
                            break;
                        case 7:
                            CalculateCircle(double.Parse(guna2TextBox1.Text));
                            break;
                    }
                } catch {
                    label3.Text = "Wykryto niepoprawną liczbę.";
                }
            }            
        }

        private void Recalculate1(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Recalculate2(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void UpdateUI_cb(object sender, EventArgs e)
        {
            UpdateUI();
            Recalculate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    new Math_PoleFigury_Wzor("triangle").Show();
                    break;
                case 1:
                    new Math_PoleFigury_Wzor("square").Show();
                    break;
                case 2:
                    new Math_PoleFigury_Wzor("rectangle").Show();
                    break;
                case 3:
                    new Math_PoleFigury_Wzor("parallelogram").Show();
                    break;
                case 4:
                    new Math_PoleFigury_Wzor("rhombus").Show();
                    break;
                case 5:
                    new Math_PoleFigury_Wzor("trapeze").Show();
                    break;
                case 6:
                    new Math_PoleFigury_Wzor("kite").Show();
                    break;
                case 7:
                    new Math_PoleFigury_Wzor("circle").Show();
                    break;
            }
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
