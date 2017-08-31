using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _049_LinkLabel_VScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if(vScrollBar1.Value >= 75)
            {
                this.BackColor = Color.Yellow;
            }
            if(vScrollBar1.Value <= 50)
            {
                this.BackColor = Color.Red;
            }
            if (vScrollBar1.Value <= 25)
            {
                this.BackColor = Color.Purple;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Mspaint.exe");
        }
    }
}
