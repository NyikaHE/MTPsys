using MTPsys.Logic;
using MTPsys.Model;
using MTPsys.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTPsys
{
    public partial class Main_Open : Form
    {
        private string test,listname,companyname;
        private OleDbDataAdapter adapter;
        OleDbCommandBuilder builder;
        private DataSet ds;
        private int listid;
        public Main_Open(string testid,Boolean flag)
        {
            InitializeComponent();
            if (flag == false) {
                Tourist();
            }
            
            //表格一初始化
            //传参
            test = testid;
            //company = compid;

            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PERSON where TEST_ID='"+testid+"'";
            adapter = new OleDbDataAdapter(sql, conn);
            builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetDeleteCommand();
            ds = new DataSet();
            adapter.Fill(ds, "T_TEST_PERSON");
            this.TestPerson.DataSource = ds.Tables["T_TEST_PERSON"];
            //conn.Close();
           
            DataBase db = new DataBase();
            //初始化界面
            TestModel tm = db.QueryTest(testid);
            textBox1.Text = tm.Testid;
            textBox2.Text = tm.Companyname1;
            textBox3.Text = tm.Sls.ToString();
            textBox4.Text = tm.Joins.ToString();
            listid = tm.Listid;
            if (listid == 1)
            {
                listname = "入伍体能考核";
            }
            else if (listid == 2) {
                listname = "通用体能考核";
            }
            companyname = tm.Companyname1;
        }
        //游客控制
        public void Tourist()
        {
            New.Visible = false;
            button5.Visible = false;
            button3.Visible = false;
            button6.Visible = false;
            
        }
        
        
        //分数处理过程
        private void button6_Click_1(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            TestModel tm = db.QueryTest(test);

            //计算体型并写入
            BMIcaculate qs = new BMIcaculate();
            qs.Process(test);
            //查询分数并写入
            ItemGrade qg = new ItemGrade();     //定义一个查分对象
            qg.PersonProcess(test);
            qg.PersonProcess(test);
            //个人总分计算
            if (listid != 1) {
                IndividualGrade pg = new IndividualGrade();
                pg.Process(tm.Standrad,test);
                //单位总分计算
                ArmyGrade ct = new ArmyGrade();
                ct.Process(test);
                adapter.Update(ds.Tables["T_TEST_PERSON"]);
            }
            fresh();
            MessageBox.Show("所有用户成绩已经计算完毕");
        }
        public void fresh() {
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PERSON where TEST_ID='" + test + "'";
            adapter = new OleDbDataAdapter(sql, conn);
            builder = new OleDbCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "T_TEST_PERSON");
            this.TestPerson.DataSource = ds.Tables["T_TEST_PERSON"];
            conn.Close();
        }
        //清空表格
        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = Connect.getConnection();
            conn.Open();
            while (this.TestPerson.Rows.Count != 0)
            {
                this.TestPerson.Rows.RemoveAt(0);
                string sql = "delete from T_TESTPER_ITEMS where TEST_ID='"+test+"'";
                OleDbCommand cmd=new OleDbCommand(sql,conn);
                cmd.ExecuteNonQuery();
                string sql1 = "delete from T_TEST_PERSON where TEST_ID='" + test + "'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            try
            {
                adapter.Update(ds.Tables["T_TEST_PERSON"]);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        private void New_Click(object sender, EventArgs e)
        {
            new OpenEdit(test,listid,companyname).Show();
        }
        //导入按钮功能
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
        }
        //打开按钮
        private void OpenFile_FileOk(object sender, CancelEventArgs e)
        {
            DataBase db = new DataBase();
            string strConn2;
            string filePath = OpenFile.FileName;
            FileInfo fileInfo = new FileInfo(filePath);
            string directory = fileInfo.DirectoryName;
            strConn2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn2);
            conn.Open();
            DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

            //包含excel中表名的字符串数组
            string[] strTableNames = new string[dtSheetName.Rows.Count];
            for (int k = 0; k < dtSheetName.Rows.Count; k++)
            {
                strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
            }
            string strSql = "select * from [" + strTableNames[0] + "]";
            OleDbCommand Cmd = new OleDbCommand(strSql, conn);
            
            //将数据放入数据库
            
            OleDbConnection conn1 = Connect.getConnection();
            OleDbDataReader reader = Cmd.ExecuteReader();
            conn1.Open();

            while (reader.Read()&& !DBNull.Value.Equals(reader[0])) {

                if (db.SearchPerson1(Convert.ToInt32(reader[0]), test, conn1))
                {
                    string sql = "insert into T_TEST_PERSON(TEST_ID,PERSON_ID,PERSON_NAME,SEX,AGE,COMPANY_NAME,HEIGHT,WEIGHT,LIST_ID,LIST_NAME) values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)";
                    OleDbCommand cmd = new OleDbCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@1", test);//TEST_ID
                    cmd.Parameters.AddWithValue("@2", Convert.ToInt32(reader[0]));//PERSON_ID
                    cmd.Parameters.AddWithValue("@3", reader[1]);//PERSON_NAME
                    cmd.Parameters.AddWithValue("@4", reader[2]);//SEX
                    cmd.Parameters.AddWithValue("@5", Convert.ToInt32(reader[3]));//AGE
                    cmd.Parameters.AddWithValue("@6", reader[4]);//COMPANY_NAME
                    cmd.Parameters.AddWithValue("@7", reader[5]);
                    cmd.Parameters.AddWithValue("@8", reader[6]);
                    cmd.Parameters.AddWithValue("@9", listid);//LIST_ID
                    cmd.Parameters.AddWithValue("@10", listname);//LIST_NAME
                    cmd.ExecuteNonQuery();
                    PersonItems pi1 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 1, "体型", reader[8], listid);
                    db.WritePersonScore(pi1, conn1);
                    if (!"".Equals(reader[9]))
                    {
                        PersonItems pi2 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 2, "俯卧撑", reader[9], listid);
                        db.WritePersonScore(pi2, conn1);
                    }
                    if (!"".Equals(reader[10]))
                    {
                        PersonItems pi3 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 3, "仰卧起坐", reader[10], listid);
                        db.WritePersonScore(pi3, conn1);
                    }
                    if (!"".Equals(reader[11]))
                    {
                        PersonItems pi4 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 4, "往返跑", reader[11], listid);
                        db.WritePersonScore(pi4, conn1);
                    }
                    if (!"".Equals(reader[12]))
                    {
                        PersonItems pi5 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 5, "3000米", reader[12], listid);
                        db.WritePersonScore(pi5, conn1);
                    }
                    if (!"".Equals(reader[13]))
                    {
                        PersonItems pi6 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 6, "引体向上", reader[13], listid);
                        db.WritePersonScore(pi6, conn1);
                    }
                    if (!"".Equals(reader[14]))
                    {
                        PersonItems pi7 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 7, "单杠屈臂悬垂", reader[14], listid);
                        db.WritePersonScore(pi7, conn1);
                    }
                    if (!"".Equals(reader[15]))
                    {
                        PersonItems pi8 = new PersonItems(test, reader[0], reader[1], reader[2], reader[4], listname, 8, "双杠臂屈伸", reader[15], listid);
                        db.WritePersonScore(pi8, conn1);
                    }
                }
                else {
                    MessageBox.Show("数据重复");
                }
            }
            adapter.Update(ds.Tables["T_TEST_PERSON"]);
            adapter.Fill(ds, "T_TEST_PERSON");
            reader.Close();
            conn.Close();
            conn1.Close();
        }
       

        //导出信息
        private void button2_Click(object sender, EventArgs e)
        {
            OutputXlsx outputXlsx = new OutputXlsx();
            outputXlsx.OutputAsExcelFile(TestPerson);
        }
        //打印按钮
        private void button1_Click(object sender, EventArgs e)
        {
            print1.ShowDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            printDocument.DocumentName = "单位考核信息";//设置文档名
            print1.Document = printDocument;
            printDocument.Print();
        }

        private void TestPerson_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            DataBase db = new DataBase();
            foreach (DataGridViewRow r in TestPerson.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    //向个人成绩窗格中填入数据；
                    index = (int)r.Cells[0].Value;
                    OleDbConnection conn = Connect.getConnection();
                    string sql = "select * from T_TESTPER_ITEMS where PERSON_ID=" + index + " and TEST_ID='" + test + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "T_TESTPER_ITEMS");
                    this.Profile.DataSource = ds.Tables["T_TESTPER_ITEMS"];

                    //给表头填写信息；
                    conn.Open();
                    Person p = new Person();
                    p = db.SearchPerson(index, test, conn);
                    name.Text = p.Name;
                    gender.Text = p.Gender;
                    age.Text = p.Age.ToString();
                    if (!"1".Equals(p.Height)) {
                        height.Text = p.Height;
                    }
                    if (!"1".Equals(p.Weight)) { weight.Text = p.Weight; }
                    
                    grade.Text = p.Grade.ToString();
                    try
                    {
                        mark.Text = p.Ispass.ToString();
                    }
                    catch
                    {
                        mark.Text = "未评定";
                    }

                    conn.Close();
                }
            }
        }

        private void New_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.New, "添加人员");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button5, "清空数据");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button3, "导入文件");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button2, "导出文件");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button1, "打印个人成绩");
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button6, "成绩评定");
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.button7, "页面刷新");
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //打印啥东东就在这写了
            int i, width;
            int r = 20;
            int c = 350;
            //string str1 = System.Windows.Forms.Application.StartupPath;//目标图片的安装位置
            //str1 += "\\bg.png";
            Graphics g = e.Graphics;
            //Image image = Image.FromFile(str1);
            Pen blackPen = new Pen(Color.Black,3);
            Brush b = new SolidBrush(Color.Black);
            Font titleFont = new Font("宋体", 16);
            string title = "人员体能考核信息";
            //打印图像
            //Point point = new Point(100,100);
            //g.DrawImage(image,point);
            //打印内容
            g.DrawString(title, titleFont, b, new PointF((e.PageBounds.Width - g.MeasureString(title, titleFont).Width) / 2, 20));
            g.DrawLine(blackPen,new Point(20,80),new Point(700,80));
            g.DrawString("人员基本信息", new Font("宋体", 13, FontStyle.Regular), b, 30, 110);
            g.DrawString("姓名：", new Font("宋体", 10, FontStyle.Regular), b, 50, 150);
            g.DrawString(name.Text, new Font("宋体", 10, FontStyle.Regular), b, 90, 150);
            g.DrawString("性别：", new Font("宋体", 10, FontStyle.Regular), b, 300, 150);
            g.DrawString(gender.Text, new Font("宋体", 10, FontStyle.Regular), b, 340, 150);
            g.DrawString("年龄：", new Font("宋体", 10, FontStyle.Regular), b, 600, 150);
            g.DrawString(age.Text, new Font("宋体", 10, FontStyle.Regular), b, 640, 150);
            g.DrawString("身高：", new Font("宋体", 10, FontStyle.Regular), b, 50, 200);
            g.DrawString(height.Text, new Font("宋体", 10, FontStyle.Regular), b, 90, 200);
            g.DrawString("体重：", new Font("宋体", 10, FontStyle.Regular), b, 300, 200);
            g.DrawString(weight.Text, new Font("宋体", 10, FontStyle.Regular), b, 340, 200);
            g.DrawString("考核成绩：", new Font("宋体", 10, FontStyle.Regular), b, 600, 200);
            g.DrawString(grade.Text, new Font("宋体", 10, FontStyle.Regular), b, 670, 200);
            g.DrawString("评定结果：", new Font("宋体", 10, FontStyle.Regular), b, 50, 250);
            g.DrawString(mark.Text, new Font("宋体", 10, FontStyle.Regular), b, 110, 250);
            
            g.DrawLine(blackPen, new Point(20, 280), new Point(700, 280));
            string[] tit = new string[4] { "测试科目", "成绩", "状态", "分数" };
            for (i = 0; i < 4; i++)
            {
                width = Profile.Columns[i].Width + 20;
                g.DrawString(tit[i], new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, 300);
                r = r + width;
            }
            r = 20;
            c = 350;
            for (i = 0; i < Profile.Rows.Count; i++)
            {
                for (int j = 0; j < Profile.Columns.Count; j++)
                {
                    
                        string data = Profile.Rows[i].Cells[j].Value.ToString();
                        width = Profile.Columns[j].Width + 20;
                        Console.WriteLine(data);
                        g.DrawString(data, new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
                        r = r + width;
                }
                r = 20;
                c += 20;
            }
        }
        //刷新按钮
        private void button7_Click(object sender, EventArgs e)
        {
            fresh();
        }
    }
}
