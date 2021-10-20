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
    public partial class Math_PICulator : Form
    {
        public Math_PICulator()
        {
            InitializeComponent();
        }
         
        public string CalculatePi(int digits)
        {
            try { 
                digits++;

                uint[] x = new uint[digits * 10 / 3 + 2];
                uint[] r = new uint[digits * 10 / 3 + 2];

                uint[] pi = new uint[digits];

                for (int j = 0; j < x.Length; j++)
                    x[j] = 20;

                for (int i = 0; i < digits; i++)
                {
                    uint carry = 0;
                    for (int j = 0; j < x.Length; j++)
                    {
                        uint num = (uint)(x.Length - j - 1);
                        uint dem = num * 2 + 1;

                        x[j] += carry;

                        uint q = x[j] / dem;
                        r[j] = x[j] % dem;

                        carry = q * num;
                    }


                    pi[i] = (x[x.Length - 1] / 10);


                    r[x.Length - 1] = x[x.Length - 1] % 10; ;

                    for (int j = 0; j < x.Length; j++)
                        x[j] = r[j] * 10;
                }

                var result = "";

                uint c = 0;

                for (int i = pi.Length - 1; i >= 0; i--)
                {
                    pi[i] += c;
                    c = pi[i] / 10;

                    result = (pi[i] % 10).ToString() + result;
                }

                return "3," + result.Substring(1);
            } catch(OutOfMemoryException)
            {
                notifyIcon1.BalloonTipText = "Twój komputer nie posiada wystarczająco pamięci RAM, aby wykonać to obliczenie.";
                notifyIcon1.ShowBalloonTip(5);
            }
            catch (OverflowException)
            {
                notifyIcon1.BalloonTipText = "Ta liczba jest za wielka.";
                notifyIcon1.ShowBalloonTip(5);
            }
            catch
            {
                notifyIcon1.BalloonTipText = "Wykryto nieokreślony błąd.";
                notifyIcon1.ShowBalloonTip(5);
            }

            return "Błąd.";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CalculatePi(int.Parse(guna2NumericUpDown1.Value.ToString())));

            notifyIcon1.BalloonTipText = "Skopiowano liczbę π zaokrągloną do " + guna2NumericUpDown1.Value.ToString() + " miejsc po przecinku.";
            notifyIcon1.ShowBalloonTip(5);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(Control.MousePosition);
        }

        private void opuśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
