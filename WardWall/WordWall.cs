namespace OYUNLAR
{
    public partial class Form1 : Form
    {
        public int i = 0;

        int puan = 0;


        public Form1()
        {
            InitializeComponent();

        }


        List<Button> btn = new List<Button>();

        public void kontrol(string birinci, string ikinci)
        {
            if (birinci == ikinci)
            {
                puan = puan + 10;
                // label3.Text = "puanýnýz:" + Convert.ToString(puan);
                foreach (Button button in btn)
                {
                    if (button.Text == label1.Text)
                    {
                        button.Visible = false;
                        i++;


                    }

                }


            }

            if (i == 36)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn.Add(button1);
            if (label2.Text == null)
            {
                label2.Text = button1.Text;

            }
            else
            {
                label1.Text = button1.Text;
                kontrol(label1.Text, label2.Text);

            }


        }



        private void button14_Click(object sender, EventArgs e)
        {
            btn.Add(button14);
            if (label1.Text == null)
            {
                label1.Text = button14.Text;

            }
            else
            {
                label2.Text = button14.Text;
                kontrol(label1.Text, label2.Text);

            }

            i++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn.Add(button2);
            if (label2.Text == null)
            {
                label2.Text = button2.Text;

            }
            else
            {
                label1.Text = button2.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            btn.Add(button28);
            if (label1.Text == null)
            {
                label1.Text = button28.Text;

            }
            else
            {
                label2.Text = button28.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn.Add(button3);
            if (label2.Text == null)
            {
                label2.Text = button3.Text;

            }
            else
            {
                label1.Text = button3.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            btn.Add(button33);
            if (label1.Text == null)
            {
                label1.Text = button33.Text;

            }
            else
            {
                label2.Text = button33.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            btn.Add(button4);
            if (label1.Text == null)
            {
                label1.Text = button4.Text;

            }
            else
            {
                label2.Text = button4.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            btn.Add(button34);
            if (label2.Text == null)
            {
                label2.Text = button34.Text;

            }
            else
            {
                label1.Text = button34.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn.Add(button5);
            if (label2.Text == null)
            {
                label2.Text = button5.Text;

            }
            else
            {
                label1.Text = button5.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            btn.Add(button21);
            if (label1.Text == null)
            {
                label1.Text = button21.Text;

            }
            else
            {
                label2.Text = button21.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn.Add(button6);
            if (label1.Text == null)
            {
                label1.Text = button6.Text;

            }
            else
            {
                label2.Text = button6.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            btn.Add(button20);
            if (label2.Text == null)
            {
                label2.Text = button20.Text;

            }
            else
            {
                label1.Text = button20.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btn.Add(button12);
            if (label2.Text == null)
            {
                label2.Text = button12.Text;

            }
            else
            {
                label1.Text = button12.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn.Add(button10);
            if (label1.Text == null)
            {
                label1.Text = button10.Text;

            }
            else
            {
                label2.Text = button10.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn.Add(button9);
            if (label1.Text == null)
            {
                label1.Text = button9.Text;

            }
            else
            {
                label2.Text = button9.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            btn.Add(button27);
            if (label2.Text == null)
            {
                label2.Text = button27.Text;

            }
            else
            {
                label1.Text = button27.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn.Add(button8);
            if (label2.Text == null)
            {
                label2.Text = button8.Text;

            }
            else
            {
                label1.Text = button8.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            btn.Add(button15);
            if (label1.Text == null)
            {
                label1.Text = button15.Text;

            }
            else
            {
                label2.Text = button15.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn.Add(button11);
            if (label1.Text == null)
            {
                label1.Text = button11.Text;

            }
            else
            {
                label2.Text = button11.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn.Add(button7);
            if (label2.Text == null)
            {
                label2.Text = button7.Text;

            }
            else
            {
                label1.Text = button7.Text;
                kontrol(label1.Text, label2.Text);

            }



        }

        private void button18_Click(object sender, EventArgs e)
        {
            btn.Add(button18);
            if (label2.Text == null)
            {
                label2.Text = button18.Text;

            }
            else
            {
                label1.Text = button18.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            btn.Add(button31);
            if (label1.Text == null)
            {
                label1.Text = button31.Text;

            }
            else
            {
                label2.Text = button31.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            btn.Add(button17);
            if (label1.Text == null)
            {
                label1.Text = button17.Text;

            }
            else
            {
                label2.Text = button17.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            btn.Add(button19);
            if (label2.Text == null)
            {
                label2.Text = button19.Text;

            }
            else
            {
                label1.Text = button19.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            btn.Add(button16);
            if (label2.Text == null)
            {
                label2.Text = button16.Text;

            }
            else
            {
                label1.Text = button16.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            btn.Add(button30);
            if (label1.Text == null)
            {
                label1.Text = button30.Text;

            }
            else
            {
                label2.Text = button30.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btn.Add(button13);
            if (label1.Text == null)
            {
                label1.Text = button13.Text;

            }
            else
            {
                label2.Text = button13.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            btn.Add(button36);
            if (label2.Text == null)
            {
                label2.Text = button36.Text;

            }
            else
            {
                label1.Text = button36.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            btn.Add(button24);
            if (label1.Text == null)
            {
                label1.Text = button24.Text;

            }
            else
            {
                label2.Text = button24.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            btn.Add(button32);
            if (label2.Text == null)
            {
                label2.Text = button32.Text;

            }
            else
            {
                label1.Text = button32.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            btn.Add(button23);
            if (label1.Text == null)
            {
                label1.Text = button23.Text;

            }
            else
            {
                label2.Text = button23.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            btn.Add(button25);
            if (label2.Text == null)
            {
                label2.Text = button25.Text;

            }
            else
            {
                label1.Text = button25.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            btn.Add(button35);
            if (label2.Text == null)
            {
                label2.Text = button35.Text;

            }
            else
            {
                label1.Text = button35.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            btn.Add(button22);
            if (label1.Text == null)
            {
                label1.Text = button22.Text;

            }
            else
            {
                label2.Text = button22.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            btn.Add(button29);
            if (label1.Text == null)
            {
                label1.Text = button29.Text;

            }
            else
            {
                label2.Text = button29.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            btn.Add(button26);
            if (label2.Text == null)
            {
                label2.Text = button26.Text;

            }
            else
            {
                label1.Text = button26.Text;
                kontrol(label1.Text, label2.Text);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button34.Visible = true;
            button35.Visible = true;
            button36.Visible = true;
            button37.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            pictureBox1.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label20.Visible = false;
            label18.Visible = true;
            label19.Visible = true;
            






        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox3.Visible = true;
        }
        int saniye = 0;
        int dakika = 0;
        int saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label6.Text = saniye.ToString();
            if (saniye > 59)
            {
                dakika++;
                label5.Text = dakika.ToString();
            }
            if (dakika > 59)
            {
                saat++;
                label7.Text = saat.ToString();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }
    }
}

