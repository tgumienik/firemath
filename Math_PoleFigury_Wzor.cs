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
    public partial class Math_PoleFigury_Wzor : Form
    {
        public Math_PoleFigury_Wzor(string figura)
        {
            InitializeComponent();
            switch (figura)
            {
                case "triangle":
                    Text = "fireMath | Wzór na pole trójkąta";
                    pictureBox1.Image = Properties.Resources.area_triangle;
                    break;
                case "square":
                    Text = "fireMath | Wzór na pole kwadratu";
                    pictureBox1.Image = Properties.Resources.area_square;
                    break;
                case "rectangle":
                    Text = "fireMath | Wzór na pole prostokąta";
                    pictureBox1.Image = Properties.Resources.area_rectangle;
                    break;
                case "parallelogram":
                    Text = "fireMath | Wzór na pole równoległoboku";
                    pictureBox1.Image = Properties.Resources.area_parallelogram;
                    break;
                case "rhombus":
                    Text = "fireMath | Wzór na pole rombu";
                    pictureBox1.Image = Properties.Resources.area_rhombus;
                    break;
                case "trapeze":
                    Text = "fireMath | Wzór na pole trapezu";
                    pictureBox1.Image = Properties.Resources.area_trapeze;
                    break;
                case "kite":
                    Text = "fireMath | Wzór na pole deltoidu";
                    pictureBox1.Image = Properties.Resources.area_kite;
                    break;
                case "circle":
                    Text = "fireMath | Wzór na pole koła";
                    pictureBox1.Image = Properties.Resources.area_circle;
                    break;
            }
        }
    }
}
