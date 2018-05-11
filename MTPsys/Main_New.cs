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
    public partial class Main_New : Form
    {
        public Main_New()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //打开面板
        private void New_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
        }
        //关闭面板
        private void Close_Click(object sender, EventArgs e)
        {
            Add.Visible = false;
        }
        //添加完成，数据添加到树结构中
        private void button6_Click(object sender, EventArgs e)
        {
            if (Name.Text == "" && Level.Text == "" && Population.Text == "")
            {
                MessageBox.Show("信息为空请重新填入！！");
            }
            else
            {
                TreeNode root = new TreeNode();
                root.Text = Name.Text + "(" + Level.SelectedItem.ToString() + "," + Population.Text + ")";
                treeView1.Nodes.Add(root);
                Add.Visible = false;
                treeView1.Visible = true;
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {

        }
    }
}
