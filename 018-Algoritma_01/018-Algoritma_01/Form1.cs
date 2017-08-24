using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_Algoritma_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        int bolunensayisi;

        //7'ye bölünen sayılar
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=1; i<=100; i++)
            {
                if(i%7==0)
                {
                    bolunensayisi++;
                    lblBolunenAdet.Text = bolunensayisi.ToString();
                    toplam += i;
                    lblBolunenToplam.Text = toplam.ToString();
                }
            }

        }
    }
}
