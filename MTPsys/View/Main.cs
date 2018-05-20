using MTPsys.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTPsys
{
   
    public partial class Main : Form
    {
        Point mouseOff;//鼠标移动位置变量    
        bool leftFlag;//标签是否为左键    
        string Testid,CompanyId;
        private OleDbDataAdapter adapter;
        private DataSet ds;
        private Boolean falg;
        private OleDbCommandBuilder builder;
        public Main(Boolean flag)
        {
            this.falg = flag;
            InitializeComponent();
            if (flag == false) {
                Tourist();
            }
            
        }
        public void Tourist() {
            New.Visible = false;
            Delete.Visible = false;
            Edit.Visible = false;
            Profile.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mTP1DataSet.T_TEST_PRJ”中。您可以根据需要移动或删除它。
            //this.t_TEST_PRJTableAdapter.Fill(this.mTP1DataSet.T_TEST_PRJ);
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PRJ";
            adapter = new OleDbDataAdapter(sql, conn);
            builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetDeleteCommand();
            ds = new DataSet();
            adapter.Fill(ds, "T_TEST_PRJ");
            this.dataGridView1.DataSource = ds.Tables["T_TEST_PRJ"];
            conn.Close();
        }
        //提示tooltips
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
            p.SetToolTip(this.Export, "打开");
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
            this.WindowState = FormWindowState.Minimized;
        }
        //最大化
        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
        //打开创建面板；
        private void New_Click(object sender, EventArgs e)
        {
            new Main_New().Show();
        }
        //刷新按钮事件
        private void Fresh_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PRJ";
            adapter = new OleDbDataAdapter(sql, conn);
            builder = new OleDbCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "T_TEST_PRJ");
            this.dataGridView1.DataSource = ds.Tables["T_TEST_PRJ"];
            conn.Close();
            MessageBox.Show("页面已刷新！！");
        }
        
        //删除选中行
        private void Delete_Click(object sender, EventArgs e)
        {
            int i;
            
            for (i = 0; i < dataGridView1.RowCount; i++) {
                if (dataGridView1.Rows[i].Selected==true) {            
                    //删除行
                    
                    OleDbConnection conn = Connect.getConnection();
                    /*string sql = "delete from T_TEST_PRJ where TEST_ID='"+ dataGridView1.Rows[i].Cells[1].Value+ "'";
                    OleDbCommand cmd = new OleDbCommand(sql,conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();*/
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    ds.Tables["T_TEST_PRJ"].Rows[i].Delete();
                    adapter.Update(ds.Tables["T_TEST_PRJ"]);
                }
            }
        }
        //单击打开按钮
        private void Export_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {                  
                    Testid = (string)r.Cells[1].Value;
                    //CompanyId= (string)r.Cells[1].Value;
                }
            }
            if (Testid != "")
                new Main_Open(Testid,falg).Show();
            else {
                MessageBox.Show("行未选中");
            }
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            new Profile().Show();
        }
        //查找按钮
        private void Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string testid = textBox1.Text;
                OleDbConnection conn = Connect.getConnection();
                string sql = "select * from T_TEST_PRJ where TEST_ID='" + testid + "'";
                adapter = new OleDbDataAdapter(sql, conn);
                builder = new OleDbCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "T_TEST_PRJ");
                this.dataGridView1.DataSource = ds.Tables["T_TEST_PRJ"];
                conn.Close();
            }
            else {
                OleDbConnection conn = Connect.getConnection();
                string sql = "select * from T_TEST_PRJ";
                adapter = new OleDbDataAdapter(sql, conn);
                builder = new OleDbCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "T_TEST_PRJ");
                this.dataGridView1.DataSource = ds.Tables["T_TEST_PRJ"];
                conn.Close();
            }
        }
        //打印按钮
        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            
            printDocument.DocumentName = "单位考核信息";//设置文档名
            PrintDialog.Document = printDocument;
            printDocument.Print();
        }
        //绘制打印内容
        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //打印啥东东就在这写了
            int i;
            Graphics g = e.Graphics;
            Brush b = new SolidBrush(Color.Black);
            Font titleFont = new Font("宋体", 16);
            string title = "项目考核汇总表";
            string[] tit = new string[9]{"考核编号","单位名称","单位级别","实力数","参考人数","参考率","及格人数","不及格人数","及格率"};
            for (i = 0; i < 9; i++) {
                g.DrawString(tit[i], new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 95*i+5, 40);
            }
            g.DrawString(title, titleFont, b, new PointF((e.PageBounds.Width - g.MeasureString(title, titleFont).Width) / 2, 20));

            int r = 5;
            int c = 60;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != 1) {
                        string data = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        int width = dataGridView1.Columns[j].Width+20;
                        Console.WriteLine(data);
                        g.DrawString(data, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
                        r = r + width;
                    }
                }
                r = 5;
                c += 20;

            }
        }
        
        /*
         * 无边框窗口通过定义mouse down,move,up来移动窗口
         */
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值    
                leftFlag = true;
                //点击左键按下时标注为true;    
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                //设置移动后的位置    
                Location = mouseSet;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;    
            }
        }
        //编辑按钮
        private void Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    Testid = (string)r.Cells[1].Value;
                    //CompanyId = (string)r.Cells[1].Value;
                }
            }
            if (Testid != "")
                new Main_New(Testid).Show();
            else
            {
                MessageBox.Show("行未选中");
            }
            
        }
        //双击打开
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    Testid = (string)r.Cells[1].Value;
                    //CompanyId = (string)r.Cells[1].Value;
                }
            }
            if (Testid != "")
                new Main_Open(Testid, falg).Show();
            else
            {
                MessageBox.Show("行未选中");
            }
        }
    }
}
