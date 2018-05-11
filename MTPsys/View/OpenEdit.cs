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

namespace MTPsys.View
{
    public partial class OpenEdit : Form
    {
        private OleDbDataAdapter adapter;
        private DataSet ds;
        private string testid;
        public OpenEdit(string testid)
        {
            this.testid = testid;
            InitializeComponent();

            

        }

        private void OpenEdit_Load(object sender, EventArgs e)
        {

            // TODO: 这行代码将数据加载到表“mTP1DataSet1.T_TEST_ITEMS”中。您可以根据需要移动或删除它。
            this.t_TEST_ITEMSTableAdapter1.Fill(this.mTP1DataSet11.T_TEST_ITEMS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Company = (string)companyname.Text;
            p.Name = (string)Name.Text;
            p.Id = (string)ID.Text;
            p.Gender = sex.Text;
            p.Age = Convert.ToInt32(age.Text);
            p.Height = StrToFloat(height.Text);
            p.Weight = StrToFloat(weight.Text);
            p.Testype = testtype.Text;
            DataBase db = new DataBase();
            db.InsertPerson(p, testid);
            OleDbConnection conn1 = Connect.getConnection();
            conn1.Open();
           // Object score = (Object)dataGridView1.Rows[0].Cells[1];

            PersonItems pi1 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 1, "体型", "");
            db.WritePersonScore(pi1, conn1);
            /*if (dataGridView1.Rows[1].Cells[1].Value != null)
            {
                PersonItems pi2 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 2, "俯卧撑", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi2, conn1);
            }
            if (dataGridView1.Rows[2].Cells[1].Value != null)
            {
                PersonItems pi3 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 3, "仰卧起坐", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi3, conn1);
            }
            if (dataGridView1.Rows[2].Cells[1].Value != null)
            {
                PersonItems pi4 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 4, "10*5米跑", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi4, conn1);
            }
            if (dataGridView1.Rows[2].Cells[1].Value != null)
            {
                PersonItems pi5 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 5, "3000米", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi5, conn1);
            }
            if (dataGridView1.Rows[2].Cells[1].Value != null)
            {
                PersonItems pi6 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 6, "引体向上", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi6, conn1);
            }
            if (dataGridView1.Rows[2].Cells[1].Value != null)
            {
                PersonItems pi7 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 7, "单杠屈臂悬垂", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi7, conn1);
            }
            if (dataGridView1.Rows[2].Cells[1].Value != null)
            {
                PersonItems pi8 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 8, "双杠臂屈伸", (Object)dataGridView1.Rows[1].Cells[1]);
                db.WritePersonScore(pi8, conn1);
                string sqll = "update T_TEST_PERSON set LIST_ID=2,LIST_NAME='入伍考核类型' where PERSON_ID=@1";
                OleDbCommand cmds = new OleDbCommand(sqll, conn1);
                cmds.Parameters.AddWithValue("@1", p.Id);
                cmds.ExecuteNonQuery();
            }*/

        }
        public float StrToFloat(object FloatString)
        {
            float result;
            if (FloatString != null)
            {
                if (float.TryParse(FloatString.ToString(), out result))
                    return result;
                else
                {
                    return (float)0.00;
                }
            }
            else
            {
                return (float)0.00;
            }
        }
    }
}
