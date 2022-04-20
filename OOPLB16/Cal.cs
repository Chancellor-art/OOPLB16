using libMath;

namespace cal
{
    public partial class Cal : Form
    {
        MathJOJO mathjojo;
        bool rezTablo = true;
        char diya = ' ';
        int operationRun = 0;

        public Cal()
        {
            InitializeComponent();
            mathjojo = new MathJOJO(ref textTablo, ref textMemory, ref rezTablo, ref diya, ref operationRun);
        }

        private void off_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('9');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mathjojo.AddToScoreboard('0');
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            bool oneComa = false;
            int tabloNum = textTablo.Text.Length;

            if (rezTablo) textTablo.Text = "";

            for (int i = 0; i < tabloNum; i++)
                if (textTablo.Text[i] == ',')
                {
                    oneComa = true;
                    break;
                }

            if (!oneComa) textTablo.Text += ",";
            rezTablo = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textTablo.Text = $"{0}";
            diya = ' ';
            operationRun = 0;
        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            if (rezTablo) textTablo.Text = "0";
            else if (textTablo.Text[textTablo.Text.Length - 1] == diya)
            {
                diya = ' ';
                operationRun = 0;
                textTablo.Text = textTablo.Text.Substring(0, textTablo.Text.Length - 1);
            }
            else textTablo.Text = textTablo.Text.Substring(0, textTablo.Text.Length - 1);
            if (textTablo.Text == "") textTablo.Text = "0";
            rezTablo = false;
        } 

        private void buttonMS_Click(object sender, EventArgs e)
        {
            mathjojo.writeMemory("MS");
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            mathjojo.writeMemory("MC");
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            mathjojo.writeMemory("M+");
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            mathjojo.writeMemory("M-");
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            mathjojo.operation("sqrt");
        }

        private void buttonProcent_Click(object sender, EventArgs e)
        {
            mathjojo.operation("%");
        }

        private void buttonXdilOne_Click(object sender, EventArgs e)
        {
            mathjojo.operation("1/x");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mathjojo.operation("+/-");
        }

        private void buttonXTwo_Click(object sender, EventArgs e)
        {
            mathjojo.operation("x^2");
        }

        private void buttonLg_Click(object sender, EventArgs e)
        {
            mathjojo.operation("lg");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            mathjojo.addDiya('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            mathjojo.addDiya('-');
        }

        private void buttonDob_Click(object sender, EventArgs e)
        {
            mathjojo.addDiya('*');
        }

        private void buttonDil_Click(object sender, EventArgs e)
        {
            mathjojo.addDiya('/');
        }

        private void buttonRez_Click(object sender, EventArgs e)
        {
            if (textTablo.Text[textTablo.Text.Length - 1] != diya)
            {
                operationRun = 2;
                mathjojo.operationSearch();
            }
        }
    }
}