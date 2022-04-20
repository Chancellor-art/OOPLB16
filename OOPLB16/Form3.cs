using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOO_9
{
    public partial class Form3 : Form
    {
        string input;
        string output;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output = "";
            char[] temp = input.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '.') output += "...";
                else output += temp[i];
            }
            textBox2.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text.ToString();
        }
    }
}
