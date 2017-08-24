using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _038_PansiyonKayit
{
    public partial class FrmKayitForm : Form
    {
        public FrmKayitForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6GEGC18\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM müsteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["Gtarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["Ctarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO müsteriler (id,ad,soyad,odaNo,Gtarih,telefon,Hesap,Ctarih) VALUES ('"+ textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + dateTimePicker2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }

        int id = 0; //Silme icin

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM müsteriler WHERE id=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //Silme calısmadı :/
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE müsteriler SET id='" + textBox1.Text.ToString() + "',ad='" + textBox2.Text.ToString() + "',soyad='" + textBox3.Text.ToString() + "',odaNo='" + textBox4.Text.ToString() + "',Gtarih='" + dateTimePicker1.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',Hesap='" + textBox6.Text.ToString() + "',Ctarih='" + dateTimePicker2.Text.ToString() + "'WHERE id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM müsteriler WHERE ad like '%" + textBox7.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["Gtarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["Ctarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
    }
}
