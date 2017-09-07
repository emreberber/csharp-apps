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

namespace _064_DevExpress1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6GEGC18\\SQLEXPRESS;Initial Catalog=kisibilgiler;Integrated Security=True");
        
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kisitablo", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["meslek"].ToString());
                ekle.SubItems.Add(oku["sehir"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelControl1.Text = "Merhabaa";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into kisitablo (ad,soyad,meslek,sehir) values('"+textEdit3.Text.ToString()+ "','" + textEdit4.Text.ToString() + "','" + textEdit5.Text.ToString() + "','" + textEdit6.Text.ToString()+"')",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";

        }
    }
}
