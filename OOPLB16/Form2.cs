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
    public partial class Form2 : Form
    {
        string input;
        string output;
        int valueO;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valueO = 0;
            char[] temp = input.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == 'о' || temp[i] == 'О') valueO++;
            output = valueO.ToString();
            textBox2.Text = output;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
