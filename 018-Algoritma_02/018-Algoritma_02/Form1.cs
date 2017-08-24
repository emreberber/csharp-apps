using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_Algoritma_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            textBox1.Clear();
        }
        int tek = 0, cift = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                cift += sayi;
                lblCiftSayilar.Text = cift.ToString();
                
            }
            else
            {
                tek += sayi;
                lblTekSayilar.Text = tek.ToString();
            }
            Temizle();
        }
    }
}
