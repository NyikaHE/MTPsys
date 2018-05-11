using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTPsys
{
    public partial class MainNew : Form
    {
        public MainNew()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //单击关闭面板时，隐藏面板
        private void Close_Click(object sender, EventArgs e)
        {
            Add.Visible = false;
        }
        //添加单位，显示面板；
        private void New_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
        }
        //增加单位完成按钮功能；
        private void button6_Click(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode();
            root.Text=Name.Text+"("+Level.Items+","+Population.Text+")";
            treeView1.Nodes.Add(root);
            Add.Visible = false;
            treeView1.Visible = true;
        }
    }
}
