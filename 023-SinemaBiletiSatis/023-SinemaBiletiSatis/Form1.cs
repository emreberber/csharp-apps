using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023_SinemaBiletiSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seans1 = 0;
        int seans1Ucret = 0;
        int seans2 = 0;
        int seans2Ucret = 0;
        int misir = 0, fiyat = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1Ucret += 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1Ucret.ToString();

            if(seans1==10)
            {
                button1.Enabled = false;
            }
            if(seans1 >=0)
            {
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1Ucret -= 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1Ucret.ToString();

            if(seans1==0)
            {
                button2.Enabled = false;
            }
            
            if (seans1 <= 10)
            {
                button1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2Ucret += 8;
            textBox4.Text = seans2.ToString();
            textBox3.Text = seans2Ucret.ToString();

            if(seans2==10)
            {
                button4.Enabled = false;
            }
            if(seans2 >=0)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2Ucret -= 8;
            textBox4.Text = seans2.ToString();
            textBox3.Text = seans2Ucret.ToString();

            if(seans2==0)
            {
                button3.Enabled = false;
            }
            if(seans2 <=10)
            {
                button4.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            misir--;
            fiyat -= 3;
            textBox5.Text = misir.ToString();
            textBox6.Text = fiyat.ToString();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
           
            misir++;
            fiyat += 3;
            textBox5.Text = misir.ToString();
            textBox6.Text = fiyat.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int top_izleyici , top_ucret;
            top_izleyici = seans1 + seans2;
            top_ucret = seans1Ucret + seans2Ucret;
            label7.Text = top_izleyici.ToString();
            label10.Text = top_ucret.ToString() + " TL";
        }
    }
}
