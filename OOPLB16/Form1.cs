using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-') e.Handled = true;
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) e.Handled = true;
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1)) e.Handled = true;
        }
        
        static bool InputDouble(out double x, TextBox Pole, string message)
        {
            x = 0;
            try 
            {
                x = Convert.ToDouble(Pole.Text); 
            }
            catch (System.FormatException)
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Pole.Focus();
                return false;
            }
            return true;
        }

        private void Pole_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).Text = "0";
                ((TextBox)sender).SelectAll();
            }
        }

        private void Pole_Validating(object sender, CancelEventArgs e)
        {
            double a = 0;
            if (!InputDouble(out a, (TextBox)sender, "Ви ввели не дійсне число"))
            {
                e.Cancel = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(PoleX.Text);
            double y = Convert.ToDouble(PoleY.Text);
            double z = Convert.ToDouble(PoleZ.Text);

            if (!InputDouble(out x, PoleX, "Ви ввели не число в поле x")) return;
            if (!InputDouble(out y, PoleY, "Ви ввели не число в поле y")) return;
            if (!InputDouble(out x, PoleZ, "Ви ввели не число в поле z")) return;
            double res = (Math.Pow(Math.Sin(x - y), 2) / 78) + ((x * y) / Math.Pow(Math.Sin(1.3 - (x * y)), 2)) + (Math.Pow(Math.Sin((1.3 * x) - 0.6), 2)) / (5 * z);
            PoleRes.Text = Convert.ToString(res);
        }

        static double JOJO(double c1, double c2)
        {
            return Math.Sqrt(c1 * c1 + c2 * c2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(PoleX.Text);
            double y = Convert.ToDouble(PoleY.Text);
            double z = Convert.ToDouble(PoleZ.Text);

            if (!InputDouble(out x, PoleX, "Ви ввели не число в поле x")) return;
            if (!InputDouble(out y, PoleY, "Ви ввели не число в поле y")) return;
            if (!InputDouble(out x, PoleZ, "Ви ввели не число в поле z")) return;
            double res = JOJO(4, x) / JOJO(x, y) + JOJO(65, y) / JOJO(6.4, z);
            PoleRes.Text = Convert.ToString(res);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2_Click(this, new EventArgs());
        }
    }
}
