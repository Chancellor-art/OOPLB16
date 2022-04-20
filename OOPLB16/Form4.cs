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
    public partial class Form4 : Form
    {
        string input;
        string output;
        int value;
        bool lastKey;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = 0;
            lastKey = false;
            char[] temp = input.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                bool actualKey = true;
                if (temp[i] == ' ' || temp[i] == ',' || temp[i] == '.') actualKey = false;
                if (lastKey == false && actualKey == true) value++;
                lastKey = actualKey;
            }
            output = value.ToString();
            textBox2.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text.ToString();
        }
    }
}
