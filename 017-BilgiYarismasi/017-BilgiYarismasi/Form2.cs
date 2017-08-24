using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_BilgiYarismasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6GEGC18\\SQLEXPRESS;Initial Catalog=sorular;Integrated Security=True");

        int sayac = 0;
        int puan = 0;
        int zaman = 10;

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            zaman = 10;
            timer1.Enabled = true;
            BtnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            BtnBasla.Text = "İleri";
            sayac++;
            lblsoru.Text = sayac.ToString();

            if(sayac==1)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select * from soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }

                baglan.Close();
            }
            if(sayac==2)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select * from soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }

                baglan.Close();
            }
            if (sayac == 3)
            {
                
                BtnBasla.Enabled = false;
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select * from soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());

                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }

                baglan.Close();
            }
            if(sayac==4)
            {
                BtnBasla.Text = "Oyun bİtti";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblsoru.Text = sayac.ToString();
            lbldogru.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text==lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            lblzaman.Text = zaman.ToString();
            if(zaman==0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                BtnBasla.Enabled = true;
            }
        }
    }
}
