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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //创建tooltip
        private void New_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.New, "创建");
        }
        //修改按钮点击事件
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //删除按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //修改tooltip
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button2, "修改");
        }

        //删除tooltip
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button1, "删除");
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mTPDataSet.T_USER”中。您可以根据需要移动或删除它。
            this.t_USERTableAdapter.Fill(this.mTPDataSet.T_USER);
            // TODO: 这行代码将数据加载到表“databaseDataSet.User”中。您可以根据需要移动或删除它。
            this.userTableAdapter.Fill(this.databaseDataSet.User);

        }
    }
}
