using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _042_DortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastegele = new Random();
        int puan = 0;
        int sure = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = false;
            button2.Enabled = true;
            int sayi1, sayi2, islem;
            int a, b;
            int toplam, carp, cikar, bol;
            sayi1 = rastegele.Next(0, 51);
            sayi2 = rastegele.Next(0, 51);
            islem = rastegele.Next(1, 5);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();

            a = Convert.ToInt32(label1.Text);
            b = Convert.ToInt32(label2.Text);

            if(islem==1)
            {
                label3.Text = "+";
                toplam = a + b;
                label5.Text = toplam.ToString();
            }
            if (islem == 2)
            {
                label3.Text = "-";
                cikar = a - b;
                label5.Text = cikar.ToString();
            }
            if (islem == 3)
            {
                label3.Text = "*";
                carp = a * b;
                label5.Text = carp.ToString();
            }
            if (islem == 4)
            {
                label3.Text = "/";
                bol = a / b;
                label5.Text = bol.ToString();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            
            if(label5.Text==textBox1.Text)
            {
                puan += 10;
                label7.Text = puan.ToString();
            }
            else
            {
                puan -= 10;
                label7.Text = puan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label9.Text = sure.ToString();

            if(sure==0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                timer1.Stop();
                sure = 20;
            }
        }
    }
}
