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
        string testType="通用体能考核",personType="二类人员";
        int standrad=60,listid=2;
        string test;
        DateTime dt = DateTime.Now;


        public Main_New()
        {
            InitializeComponent();
            dateTimePicker1.Value = dt.Date;
            radioButton9.Enabled = false;
            button2.Visible = false;
        }
        public Main_New(string testid)
        {
            InitializeComponent();
            dateTimePicker1.Value = dt.Date;
            test = testid;
            init();
            textBox2.Visible = false;
            Finish.Visible = false;
        }

        public void init() {
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PRJ where TEST_ID='" + test + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            reader.Read();
            textBox1.Text = reader["COMPANY_NAME"].ToString();
            comboBox1.Text = reader["COMLEVEL_NAME"].ToString();
            textBox3.Text = reader["QTY_TOTAL"].ToString();
        }
        
        
        //编辑完成按钮
        private void Finish_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PRJ where TEST_ID='" + textBox2.Text + "'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("考核编号重复，请重填！");
            }
            else {
                ExamModel em = new ExamModel();
                em.OrganName = textBox1.Text;
                em.OrganLevel = comboBox1.Text;
                em.ExamType = testType;
                em.Peoples = Convert.ToInt32(textBox3.Text);
                
                em.ExamTime = (DateTime)dateTimePicker1.Value;
                em.ExamID = textBox2.Text;
                em.Parent = personType;
                em.ExamType = testType;
                em.Standrad = standrad;
                em.Listid = listid;
                DataBase db = new DataBase();
                db.InsertExam(em);
                this.Close(); 
            }
            reader.Close();
            conn.Close();  
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                testType = radioButton2.Text;
                listid = 2;
                radioButton9.Enabled = false;
            }
            else {
                radioButton9.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { testType = radioButton3.Text;
                listid = 3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { testType = radioButton4.Text;
                listid = 4;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) { testType = radioButton5.Text;
                listid = 1;
                
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) {
                standrad = 65;
                personType = "一类人员";
            }
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                standrad = 60;
                personType = "二类人员";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                standrad = 55;
                personType = "三类人员";
            }
        }

        private void Main_New_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                personType = "入伍训练人员";
                radioButton2.Enabled = false;
            }
            else {
                radioButton2.Enabled = true;
            }
        }
        //“修改”按钮事件
        private void button2_Click(object sender, EventArgs e)
        {
            ExamModel em = new ExamModel();
            em.OrganName = textBox1.Text;
            em.OrganLevel = comboBox1.Text;
            em.Peoples = Convert.ToInt32(textBox3.Text);
            em.ExamTime = (DateTime)dateTimePicker1.Value;
            em.ExamID = test;
            em.Listid = listid;
            em.Parent = personType;
            em.ExamType = testType;
            em.Standrad = standrad;
            DataBase db = new DataBase();
            db.UpdateExam(em).ToString();
            this.Close();
        }

    }
}
