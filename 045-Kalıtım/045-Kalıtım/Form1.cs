using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_Kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            INSAN ins = new INSAN();
            ins.ad = "Emre";
            ins.soyad = "Berber";
            ins.yas = 20;
            ins.kilo = 70;

            PERSONEL pers = new PERSONEL();
            pers.departman = "Egitim";
            pers.boy = 180;
            pers.yer = "Sube-1";

            label1.Text = ins.ad;
            label2.Text = ins.soyad;
            label3.Text = ins.yas.ToString();
            label4.Text = ins.kilo.ToString();

            label5.Text = pers.departman;
            label6.Text = pers.boy.ToString();
            label7.Text = pers.yer;

            pers.ad = "Baran";
            pers.soyad = "Berber";
            label8.Text = pers.ad;
            label9.Text = pers.soyad;

        }
    }
}
