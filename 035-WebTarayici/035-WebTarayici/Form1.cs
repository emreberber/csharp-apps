using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _035_WebTarayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true; //Hata Göstermesin diye yazdım.
            webBrowser1.Navigate(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            this.Text = webBrowser1.DocumentTitle;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            string zaman = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
            string zaman2 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            FileStream f = new FileStream("gecmis.txt",FileMode.Append);
            StreamWriter yaz = new StreamWriter(f);
            yaz.WriteLine(zaman + "/" + zaman2 + "/" + webBrowser1.Url);
            yaz.Close();
            gecmisiyukle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {
                toolStripProgressBar1.Minimum = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gecmisiyukle();
        }
        private void gecmisiyukle()
        {
            listBox1.Items.Clear();
            StreamReader dosya = new StreamReader("gecmis.txt");
            while (!dosya.EndOfStream)
            {
                listBox1.Items.Add(dosya.ReadLine());
            }
            dosya.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("gecmis.txt");
            dosya.Write("");
            dosya.Close();
            gecmisiyukle();
        }
    }
}
