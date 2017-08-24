using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _033_ProgressBar_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >0)
            {
                progressBar1.Value -= 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if(progressBar2.Value==100)
            {
                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
