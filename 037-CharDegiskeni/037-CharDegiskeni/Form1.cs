using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _037_CharDegiskeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char cinsiyet;
            cinsiyet = 'E';
            label1.Text = cinsiyet.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char ch;
            ch = (char)97;
            label2.Text = ch.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam;
            toplam = 'a' + 5 + 'A';
            label3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            char harf = Convert.ToChar(textBox2.Text);
            int toplam = 0;

            foreach(char i in cumle)
            {
                if(harf==i)
                {
                    toplam++;
                }
            }

            label5.Text = toplam.ToString();

        }
    }
}
