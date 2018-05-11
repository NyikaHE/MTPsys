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
    public partial class Main : Form
    {
        private Boolean cc;
        public Main(Boolean flag)
        {
            cc = flag;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mTPDataSet.T_COMPANY”中。您可以根据需要移动或删除它。
            this.t_COMPANYTableAdapter.Fill(this.mTPDataSet.T_COMPANY);
            // TODO: 这行代码将数据加载到表“databaseDataSet.Arrea”中。您可以根据需要移动或删除它。
            this.arreaTableAdapter.Fill(this.databaseDataSet.Arrea);

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.New, "新建");
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Delete, "删除");
        }

        private void Edit_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Edit, "编辑");
        }

        private void Export_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Export, "导出");
        }

        private void Print_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Print, "打印");
        }

        private void Fresh_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Fresh, "刷新");
        }

        private void Profile_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Profile, "账户管理");
        }
        //最小化按钮事件
        private void Mix_Click(object sender, EventArgs e)
        {
            this.Size = this.MinimumSize;
        }
        //最大化
        private void Max_Click(object sender, EventArgs e)
        {
            this.Size= this.MaximumSize;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //窗口关闭时退出运行
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void New_Click(object sender, EventArgs e)
        {
            new Main_New().Show();
        }
    }
}
