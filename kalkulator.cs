namespace kalkulatorbiasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float nilai1, hasil;
        int count = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            nilai1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = nilai1.ToString() + "÷";
            count = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nilai1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = nilai1.ToString() + "×";
            count = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nilai1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = nilai1.ToString() + "-";
            count = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nilai1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Text = nilai1.ToString() + "+";
            count = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    hasil = nilai1 / float.Parse(textBox1.Text);
                    textBox1.Text = hasil.ToString();
                    break;
                case 2:
                    hasil = nilai1 * float.Parse(textBox1.Text);
                    textBox1.Text = hasil.ToString();
                    break;
                case 3:
                    hasil = nilai1 - float.Parse(textBox1.Text);
                    textBox1.Text = hasil.ToString();
                    break;
                case 4:
                    hasil = nilai1 + float.Parse(textBox1.Text);
                    textBox1.Text = hasil.ToString();
                    break;
                default:
                    break;
            }
            count = 5;
        }

        private void kosong_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 0;
            textBox2.Text = textBox2.Text + 0;
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 1;
            textBox2.Text = textBox2.Text + 1;
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 2;
            textBox2.Text = textBox2.Text + 2;
        }

        private void but_3_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 3;
            textBox2.Text = textBox2.Text + 3;
        }

        private void but_4_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 4;
            textBox2.Text = textBox2.Text + 4;
        }

        private void but_5_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 5;
            textBox2.Text = textBox2.Text + 5;
        }

        private void but_6_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 6;
            textBox2.Text = textBox2.Text + 6;
        }

        private void but_7_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 7;
            textBox2.Text = textBox2.Text + 7;
        }

        private void but_8_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 8;
            textBox2.Text = textBox2.Text + 8;
        }

        private void but_9_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            textBox1.Text = textBox1.Text + 9;
            textBox2.Text = textBox2.Text + 9;
        }

        private void but_dot_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
                textBox2.Text = textBox2.Text + ".";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            if (count == 5)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void but_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
