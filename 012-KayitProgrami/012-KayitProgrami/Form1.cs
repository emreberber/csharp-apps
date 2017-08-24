using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _012_KayitProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6GEGC18\\SQLEXPRESS;Initial Catalog=Kayitlar;Integrated Security=True");

        private void verilerigoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Gelenler", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["firma"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());

                listView1.Items.Add(ekle);
               
            }

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand($"INSERT INTO Gelenler (adsoyad,firma,telefon) VALUES ('{textBox1.Text.ToString()}','{textBox2.Text.ToString()}','{textBox3.Text.ToString()}')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
