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
        private string testid,listname,companyname;
        private int listid;
        public OpenEdit(string testid,int listid,string companyname)
        {
            this.testid = testid;
            this.listid = listid;
            if (listid == 1)
            {
                listname = "入伍体能考核";
            }
            else if (listid == 2)
            {
                listname = "通用体能考核";
            }
            this.companyname = companyname;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            //try
            //{
                p.Name = (string)Name.Text;
            p.Id = (string)ID.Text;
            p.Gender = sex.Text;
            p.Age = Convert.ToInt32(age.Text);
            p.Height = height.Text;
            p.Weight = weight.Text;
            p.Company = companyname;
            p.Testype = listname;
            p.Listid = listid;
            DataBase db = new DataBase();
            db.InsertPerson(p, testid);
            OleDbConnection conn1 = Connect.getConnection();
            conn1.Open();
            
                PersonItems pi1 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 1, "体型", "", listid);
                db.WritePersonScore(pi1, conn1);
                if (f.Text != "")
                {
                    PersonItems pi2 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 2, "俯卧撑", Convert.ToInt32(f.Text), listid);
                    db.WritePersonScore(pi2, conn1);
                    //MessageBox.Show(a.ToString());
                }
                if (y.Text != "")
                {
                    PersonItems pi3 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 3, "仰卧起坐", Convert.ToInt32(y.Text), listid);
                    db.WritePersonScore(pi3, conn1);
                }
                if (s.Text != "")
                {
                    PersonItems pi4 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 4, "往返跑", Convert.ToString(s.Text), listid);
                    db.WritePersonScore(pi4, conn1);
                }
                if (sq.Text != "")
                {
                    PersonItems pi5 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 5, "3000米", Convert.ToString(sq.Text), listid);
                    db.WritePersonScore(pi5, conn1);
                }
                if (yt.Text != "")
                {
                    PersonItems pi6 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 6, "引体向上", Convert.ToInt32(yt.Text), listid);
                    db.WritePersonScore(pi6, conn1);
                }
                if (dg.Text != "")
                {
                    PersonItems pi7 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 7, "单杠屈臂悬垂", Convert.ToString(dg.Text), listid);
                    db.WritePersonScore(pi7, conn1);
                }
                if (sg.Text != "")
                {
                    PersonItems pi8 = new PersonItems(testid, p.Id, p.Name, p.Gender, p.Company, p.Testype, 8, "双杠臂屈伸", Convert.ToInt32(sg.Text), listid);
                    db.WritePersonScore(pi8, conn1);
                }

                this.Close();
            //}
            //catch {
            //    MessageBox.Show("插入信息有误，请重新插入！！！");
            //}

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
