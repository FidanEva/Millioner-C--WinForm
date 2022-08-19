using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace millioner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int no = 0, sc, time;
        public void score()
        {
            sc = Convert.ToInt32(label4.Text);
            sc = sc + 10;
            label4.Text = sc.ToString();
        }
        public void buttonenable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        public void timescore()
        {
            if (timer1.Enabled == false)
            {
                sc = sc + time;
                label4.Text = sc.ToString();
            }
        }
        public void color()
        {
            if (no == 1)
            {
                button1.BackColor = Color.LightCoral;
                button2.BackColor = Color.LightGreen;
                button3.BackColor = Color.LightCoral;
                button4.BackColor = Color.LightCoral;
            }
            if (no == 2)
            {
                button1.BackColor = Color.LightCoral;
                button2.BackColor = Color.LightCoral;
                button3.BackColor = Color.LightGreen;
                button4.BackColor = Color.LightCoral;
            }
            if (no == 3)
            {
                button1.BackColor = Color.LightCoral;
                button2.BackColor = Color.LightCoral;
                button3.BackColor = Color.LightGreen;
                button4.BackColor = Color.LightCoral;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "NEXT";
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            timer1.Enabled = true;
            time = 20;
            label2.Text = time.ToString();
            no++;
            label1.Text = no.ToString();
            if (no == 1)
            {
                richTextBox1.Text = "Xankəndi rayonu neçənci ildə erməni təcavüzkarları tərəfindən işğal olunmuşdur?";
                button1.Text = "1990";
                button2.Text = "1991";
                button3.Text = "1992";
                button4.Text = "1993";
            }
            if (no == 2)
            {
                richTextBox1.Text = "Azərbaycan Xalq Cümhuriyyəti Milli Şurasının sədri kim olmuşdur?";
                button1.Text = "Heydər Əliyev";
                button2.Text = "Əbülfəz Elçibəy";
                button3.Text = "Məmməd Əmin Rəsulzadə";
                button4.Text = "Əlimərdan bəy Topçubaşov";
            }
            if (no == 3)
            {
                richTextBox1.Text = "Heydər Əliyev neçənci ildə anadan olmuşdur?";
                button1.Text = "1941";
                button2.Text = "1918";
                button3.Text = "1923";
                button4.Text = "1956";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonenable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buttonenable();
            button5.Enabled = true;
            timer1.Enabled = false;
            color();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttonenable();
            button5.Enabled = true;
            timer1.Enabled = false;
            color();
            if (no == 1)
            {
                timescore();
                score();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            buttonenable();
            button5.Enabled = true;
            timer1.Enabled = false;
            color();
            if (no == 2)
            {
                timescore();
                score();
            }
            if (no == 3)
            {
                timescore();
                score();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            buttonenable();
            button5.Enabled = true;
            timer1.Enabled = false;
            color();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = Convert.ToInt32(label2.Text);
            time--;
            label2.Text = time.ToString();
            if (time == 0)
            {
                timer1.Enabled = false;
                buttonenable();
                button5.Enabled = true;
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
