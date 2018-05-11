using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTPsys
{
    public partial class Profile : Form
    {
        OleDbDataAdapter adapter;
        DataSet dataSet;
        public Profile()
        {
            InitializeComponent();
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_USER";
            adapter = new OleDbDataAdapter(sql, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            builder.QuotePrefix = "[";
            builder.QuoteSuffix = "]";
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            dataSet = new DataSet();
            adapter.Fill(dataSet, "T_USER");
            this.dataGridView1.DataSource = dataSet.Tables["T_USER"];
            
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
            dataGridView1.ReadOnly = false;
        }
        //删除按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
             if(dataGridView1.Rows[i].Selected==true)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    dataSet.Tables["T_USER"].Rows[i].Delete();
                    adapter.Update(dataSet.Tables["T_USER"]);
                }
            }
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
            // TODO: 这行代码将数据加载到表“mTP1DataSet.T_USER”中。您可以根据需要移动或删除它。
            //this.t_USERTableAdapter.Fill(this.mTP1DataSet.T_USER);

        }
        //添加按钮
        private void New_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                adapter.Update(dataSet.Tables["T_USER"]);
            }
            catch(Exception es) {
                MessageBox.Show("数据错误");
            }
        }
    }
}
