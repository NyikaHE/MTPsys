using MTPsys.Model;
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
    public partial class Main_New : Form
    {
        string testType;
        int standrad;
        string test;
        private OleDbDataAdapter adapter;
        private DataSet ds;
        private OleDbCommandBuilder builder;
        public Main_New()
        {
            InitializeComponent();
            
        }
        public Main_New(string testid)
        {
            InitializeComponent();
            test = testid;
            textBox2.Visible = false;
            Finish.Visible = false;
        }
        private void Main_New_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mTP1DataSet.T_COMPANY”中。您可以根据需要移动或删除它。
            //this.t_COMPANYTableAdapter.Fill(this.mTP1DataSet.T_COMPANY);
            OleDbConnection conn = Connect.getConnection();
            string sql = "select COMPANY_NAME from T_TEST_PRJ";
            adapter = new OleDbDataAdapter(sql, conn);
            
            ds = new DataSet();
            adapter.Fill(ds, "T_TEST_PRJ");
            this.comboBox2.DataSource = ds.Tables["T_TEST_PRJ"];
            this.comboBox4.DataSource = ds.Tables["T_TEST_PRJ"];
            conn.Close();
        }
        //添加考核信息
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && comboBox1.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("信息为空请重新填入！！");
            }
            else
            {
                MessageBox.Show("考试信息添加成功，请继续添加考生信息！");
            }
        }
        
        //编辑完成按钮
        private void Finish_Click(object sender, EventArgs e)
        {
            ExamModel em = new ExamModel();
            em.OrganName = textBox1.Text;
            em.OrganLevel = comboBox1.Text;
            em.ExamType = testType;
            em.Peoples = Convert.ToInt32(textBox3.Text);
            em.ExamTime = (DateTime)dateTimePicker1.Value;
            em.ExamID = (string)textBox2.Text;
            if (comboBox2 != null)
            {
                em.Parent = (string)comboBox2.Text;
            }
            else {
                em.Parent = "根节点";
            }
            
            em.ExamType = testType;
            em.Standrad = standrad;
            DataBase db = new DataBase();
            db.InsertExam(em);
            this.Close();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) testType = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) testType = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) testType = radioButton4.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) testType = radioButton5.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            standrad = 65;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            standrad = 60;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            standrad = 55;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            standrad = 50;
        }
        //修改完成按钮
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" && comboBox3.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("信息为空请重新填入！！");
            }
            else
            {
                MessageBox.Show("考试信息修改成功，请继续修改考生信息！");
            }
        }
        //“修改”按钮事件
        private void button2_Click(object sender, EventArgs e)
        {
            ExamModel em = new ExamModel();
            em.OrganName = textBox6.Text;
            em.OrganLevel = comboBox3.Text;
            em.Peoples = Convert.ToInt32(textBox7.Text);
            em.ExamTime = (DateTime)dateTimePicker1.Value;
            em.ExamID = test;
            if (comboBox4 != null)
            {
                em.Parent = (string)comboBox4.Text;
            }
            else
            {
                em.Parent = "根节点";
            }

            em.ExamType = testType;
            em.Standrad = standrad;
            DataBase db = new DataBase();
            db.UpdateExam(em).ToString();
            
            
            this.Close();
        }
    }
}
