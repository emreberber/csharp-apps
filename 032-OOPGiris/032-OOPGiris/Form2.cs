using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _032_OOPGiris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.marka = "Opel";
            oto.model = "Astra";
            oto.renk = "Siyah";
            oto.yil = 2013;
            oto.vites = "Manuel";

            string marka = oto.markagetir();
            label6.Text = marka;
            label7.Text = oto.model;
            label8.Text = oto.yil.ToString();
            label9.Text = oto.renk;
            label10.Text = oto.vites;
        }
    }
}
