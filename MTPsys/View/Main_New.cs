using MTPsys.Model;
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
        string testType;
        int standrad;
        public Main_New()
        {
            InitializeComponent();
            
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Main_New_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mTPDataSet.T_TEST_PRJ”中。您可以根据需要移动或删除它。
       
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
                TreeNode root = new TreeNode();
                root.Text = textBox1.Text + "(" + comboBox1.SelectedItem.ToString() + "," + textBox3.Text + ")";
                treeView1.Nodes.Add(root);
            }
            MessageBox.Show("考试信息添加成功，请继续添加人员信息！");

        }
        
        //编辑完成按钮
        private void Finish_Click(object sender, EventArgs e)
        {
            ExamModel em = new ExamModel();
            em.OrganName = textBox1.Text;
            em.OrganLevel = comboBox1.Text;
            em.Peoples = Convert.ToInt32(textBox3.Text);
            em.ExamTime = (DateTime)dateTimePicker1.Value;
            em.ExamID = (string)textBox2.Text;
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
    }
}
