using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Advancetool : Form
    {
        public Advancetool()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Advancetool_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
            tNode = treeView1.Nodes.Add("website");

            treeView1.Nodes[0].Nodes.Add("Net-informations.com");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("CLR");

            treeView1.Nodes[0].Nodes.Add("Vb.net-informations.com");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("string Tutorial");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Excel Tutorial");

            treeView1.Nodes[0].Nodes.Add("Csharp.net-informations.com");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("ADO.NET");
            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Dataset");


        }
    }
}
