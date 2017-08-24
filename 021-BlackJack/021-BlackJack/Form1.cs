using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sayac = 0;
        int oyuncupuan = 0;
        int pcpuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if(sayac==1)
            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if(sayac==2)
            {
                int a3, toplam;
                a3 = rastgele.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label10.Text) + a3;
                label10.Text = toplam.ToString();
                
            }
            if(sayac==3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = Convert.ToInt32(label10.Text) + a4;
                label10.Text = toplam.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            label11.Text = toplam.ToString();

            if(toplam<16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();
                toplam += b3;
                label11.Text = toplam.ToString();
            }
            if(toplam<16)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();
                toplam += b4;
                label11.Text = toplam.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int oyuncutoplam, pctoplam;
            oyuncutoplam = Convert.ToInt32(label10.Text);
            pctoplam = Convert.ToInt32(label11.Text);

            if(oyuncutoplam>pctoplam && oyuncutoplam <=21)
            {
                oyuncupuan += 10;
                label16.Text = oyuncupuan.ToString();
            }
            if(pctoplam > oyuncutoplam && pctoplam <=21 )
            {
                pcpuan += 10;
                label17.Text = pcpuan.ToString();
            }
            if(pctoplam > 21 && oyuncutoplam >21)
            {
                MessageBox.Show("Değerler Eşit ");
            }
            if(pcpuan == oyuncupuan && pctoplam<=21 && oyuncutoplam<=21)
            {
                pcpuan += 10;
                oyuncupuan += 10;
            }
            if(oyuncupuan ==50)
            {
                MessageBox.Show("Kazandın");
            }
            if(pcpuan==50)
            {
                MessageBox.Show("Kaybettin ");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;

        }
    }
}
