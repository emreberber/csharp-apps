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

namespace _014_KaydetSilGoruntule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6GEGC18\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");

        private void goruntule()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kitaplar", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["kitapad"].ToString());
                ekle.SubItems.Add(oku["yazar"].ToString());
                ekle.SubItems.Add(oku["yayinevi"].ToString());
                ekle.SubItems.Add(oku["sayfa"].ToString());

                listView1.Items.Add(ekle);
            }

            baglan.Close();
        }

 
        private void button1_Click_1(object sender, EventArgs e)
        {
            goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand($"INSERT INTO kitaplar (id,kitapad,yazar,yayinevi,sayfa) VALUES ('{textBox1.Text.ToString()}'," +
                $"'{textBox2.Text.ToString()}'," +
                $"'{textBox3.Text.ToString()}'," +
                $"'{textBox4.Text.ToString()}'," +
                $"'{textBox5.Text.ToString()}' )", baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            goruntule();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        int id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand($"DELETE FROM kitaplar WHERE id=({id})", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            goruntule();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand($"UPDATE kitaplar SET id='{ textBox1.Text.ToString()}' , kitapad='{textBox2.Text.ToString()}' , yazar='{textBox3.Text.ToString()}' , yayinevi='{textBox4.Text.ToString()}', sayfa='{textBox5.Text.ToString()}' WHERE id={id} ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            goruntule();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
