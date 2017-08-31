using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _050_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode ekle = new TreeNode("Linux");
            treeView1.Nodes.Add(ekle);

            ekle = new TreeNode("Windows");
            treeView1.Nodes.Add(ekle);

            TreeNode cocuk1 = new TreeNode("c#");
            TreeNode cocuk2 = new TreeNode("Visual Basic");
            TreeNode cocuk3 = new TreeNode("ASP .Net");

            TreeNode[] array = new TreeNode[] { cocuk1, cocuk2, cocuk3 };
            ekle = new TreeNode("Programlama Dilleri", array);

            treeView1.Nodes.Add(ekle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=1; i<=10;i++)
            {
                treeView2.Nodes.Add(i.ToString());
                for(int k=0; k<3;k++)
                {
                    treeView2.Nodes[i - 1].Nodes.Add(k.ToString());
                }
            }

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.ToString();
        }
    }
}
