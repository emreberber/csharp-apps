using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _065_Devexpress2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add("Pendik");
            listBoxControl1.Items.Add("Üsküdar");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add("Tuzla");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add(textEdit1.Text);
        }
    }
}
