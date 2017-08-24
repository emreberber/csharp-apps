using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_DizilerForeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = new string[7];
            gunler[0] = "pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "carsamba";
            gunler[3] = "persembe";
            gunler[4] = "cuma";
            gunler[5] = "cumartesi";
            gunler[6] = "pazar";

            label1.Text = gunler[2];

            // Diğer gösterim :
            int[] dizi = { 1, 2, 3, 4};
            int toplam = 0;
            for(int i=0; i<dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            label2.Text = toplam.ToString();


            //Dizinin Boyutu
            double[] sayilar = { 1.74, 2.89, 3.14, 1.90 };
            int eleman = sayilar.Length;

            //Foreach Döngüsü
            int[] dizi2 = { 2, 5 };
            int sum = 0;
            foreach(int sayi in dizi2)
            {
                sum += sayi;
            }
            label3.Text = sum.ToString();

            
            
            

        }
    }
}
