using cal;
using lab_10;
using TOO_9;

namespace OOPLB16
{
    public partial class FormBase : Form
    {
        Form lab10 = null;
        Form cal = null;
        Form lab9_1 = null;
        Form lab9_2 = null;
        Form lab9_3 = null;

        public FormBase()
        {
            InitializeComponent();
        }

        void OpenForm(int id)
        {
            bool salo = false;
            ref Form form = ref lab10;
            switch (id)
            {
                case 0:
                    form = ref lab10;
                    if (form == null || form.IsDisposed) form = new Form1();
                    else salo = true;
                    break;

                case 1:
                    form = ref lab9_1;
                    if (form == null || form.IsDisposed) form = new Form2();
                    else salo = true;
                    break;

                case 2:
                    form = ref lab9_2;
                    if (form == null || form.IsDisposed) form = new Form3();
                    else salo = true;
                    break;

                case 3:
                    form = ref lab9_3;
                    if (form == null || form.IsDisposed) form = new Form4();
                    else salo = true;
                    break;

                case 4:
                    form = ref cal;
                    if (form == null || form.IsDisposed) form = new Cal();
                    else salo = true;
                    break;
            }
            if (salo == false) form.Show();
            else form.Focus();

        }

        void closeForm(int id)
        {
            ref Form form = ref lab10;
            switch (id)
            {
                case 0:
                    form = ref lab10;
                    break;

                case 1:
                    form = ref lab9_1;
                    break;

                case 2:
                    form = ref lab9_2;
                    break;

                case 3:
                    form = ref lab9_3;
                    break;

                case 4:
                    form = ref cal;
                    break;
            }
            if (form != null && !form.IsDisposed)
            {
                form.Close();
                form = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) closeForm(i);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm(0);
        }
    }
}