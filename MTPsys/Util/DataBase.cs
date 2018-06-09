using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using MTPsys.Model;
using System.Windows.Forms;

namespace MTPsys
{
    class DataBase
    {
        private string testid;

        public DataBase(string testid)
        {
            this.testid = testid;
        }
        public DataBase()
        {
            
        }
        //登陆验证
        public Boolean GetUser(string username, string psw)
        {
            OleDbConnection conn = Connect.getConnection();
            string sql = "select PASSWORD from [T_USER] where LOGIN_NAME=@username";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.Parameters.AddWithValue("@username", username);
            conn.Open();//打开链接
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            
            reader.Read();//这个read调用很重要！不写的话运行时将提示找不到数据 

            //reader.HasRows当前查询结果是否为空
            if (reader.HasRows && (string)reader["PassWord"] == psw)
            {
                reader.Close();
                conn.Close();
                return true;
            }
            else
            {
                reader.Close();
                conn.Close();
                return false;
            }
        }
        //插入考核信息
        public Boolean InsertExam(ExamModel ex) {
            OleDbConnection conn = Connect.getConnection();
            string sql = "insert into T_TEST_PRJ (TEST_ID,TEST_DATE,COMPANY_NAME,COMLEVEL_NAME,QTY_TOTAL,STANDRAD,PERSON_TYPE,LIST_ID) values(@1,@2,@3,@4,@5,@6,@7,@8)";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.Parameters.AddWithValue("@1", ex.ExamID);
            cmd.Parameters.AddWithValue("@2", ex.ExamTime);
            cmd.Parameters.AddWithValue("@3", ex.OrganName);
            cmd.Parameters.AddWithValue("@4", ex.OrganLevel);
            cmd.Parameters.AddWithValue("@5", ex.Peoples);
            cmd.Parameters.AddWithValue("@6", ex.Standrad);
            cmd.Parameters.AddWithValue("@7", ex.Parent);
            cmd.Parameters.AddWithValue("@8", ex.Listid);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public int UpdateExam(ExamModel ex)
        {
            OleDbConnection conn = Connect.getConnection();

            /*string sql = "update T_TEST_PRJ set TEST_DATE='"+ ex.ExamTime + "',COMPANY_NAME='" +
               ex.OrganName+ "',COMLEVEL_NAME='" +
               ex.OrganLevel + "',QTY_TOTAL=" +
               ex.Peoples + ",STANDRAD=" +
               ex.Standrad + ",PERSON_TYPE='"+ 
               ex.Parent + "',LIST_ID=" +
               ex.Listid+" where TEST_ID='"+ ex.ExamID + "'";*/
            string sql = "update T_TEST_PRJ set TEST_DATE=@1,COMPANY_NAME=@2,COMLEVEL_NAME=@3,QTY_TOTAL=@4,STANDRAD=@5,PERSON_TYPE=@6,LIST_ID=@7 where TEST_ID=@8";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.Parameters.AddWithValue("@1", ex.ExamTime);
            cmd.Parameters.AddWithValue("@2", ex.OrganName);
            cmd.Parameters.AddWithValue("@3", ex.OrganLevel);
            cmd.Parameters.AddWithValue("@4", ex.Peoples);
            cmd.Parameters.AddWithValue("@5", ex.Standrad);
            cmd.Parameters.AddWithValue("@6", ex.Parent);
            cmd.Parameters.AddWithValue("@7", ex.Listid);
            cmd.Parameters.AddWithValue("@8", ex.ExamID);
            
            conn.Open();
            int a=cmd.ExecuteNonQuery();
            conn.Close();
            return a;
        }
        //删除考核信息
        public void Delete(string index){
            OleDbConnection conn = Connect.getConnection();
            conn.Open();//打开链接

            string sql = "delete from T_TESTPER_ITEMS where TEST_ID='"+index+"'";           
            
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句             
            cmd.ExecuteNonQuery();//执行查询

            //da.Update();
            
            conn.Close();
        }
        //插入人员信息
        public void InsertPerson(Person p,string testid) {
            OleDbConnection conn = Connect.getConnection();
            string sql= "insert into T_TEST_PERSON (PERSON_NAME,SEX,AGE,HEIGHT,WEIGHT,COMPANY_NAME,LIST_NAME,TEST_ID,PERSON_ID,LIST_ID) values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.Parameters.AddWithValue("@1", p.Name);
            cmd.Parameters.AddWithValue("@2", p.Gender);
            cmd.Parameters.AddWithValue("@3", p.Age);
            cmd.Parameters.AddWithValue("@4", p.Height);
            cmd.Parameters.AddWithValue("@5", p.Weight);
            cmd.Parameters.AddWithValue("@6", p.Company);
            cmd.Parameters.AddWithValue("@7", p.Testype);
            cmd.Parameters.AddWithValue("@8", testid);
            cmd.Parameters.AddWithValue("@9", p.Id);
            cmd.Parameters.AddWithValue("@10", p.Listid);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public Boolean SearchPerson1(int index, string testid, OleDbConnection conn)
        {
            string sql = "select * from T_TEST_PERSON where PERSON_ID=" + index + " and TEST_ID='" + testid + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            //reader.HasRows当前查询结果是否为空
            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else {
                reader.Close();
                return true;
            }
        }
        //查询人员信息
        public Person SearchPerson(int index,string testid, OleDbConnection conn) {
            int result=0;
             
            string sql = "select * from T_TEST_PERSON where PERSON_ID=" + index+" and TEST_ID='"+testid+"'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            //reader.HasRows当前查询结果是否为空
            Person p = new Person();
            while (reader.Read())
            {
                result = 0;
                p.Name = (string)reader[3];
                p.Gender= (string)reader[4];
                p.Age = (int)reader[5];
                
                try
                {
                    p.Height = (String)reader["HEIGHT"];
                    p.Weight = (String)reader["WEIGHT"];
                    p.Ispass = (string)reader["BASETEST"];
                }
                catch (Exception ex) {
                    p.Ispass = "未评定";
                    p.Height = "1";
                    p.Weight ="1";
                }
                
                //查询成绩
                string sql1 = "select RESULTS from T_TESTPER_ITEMS where PERSON_ID=" + index+ " and TEST_ID='" + testid + "'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, conn);  //sql语句 
                
                OleDbDataReader reader1 = cmd1.ExecuteReader();//执行查询
                while (reader1.Read())
                {
                    try
                    {
                        result += (int)reader1[0];
                    }
                    catch {
                        result += 0;
                    }
                }
                p.Grade = result;
            }
            reader.Close();
            return p;
        }
        //写入新兵成绩
        public void WriteBigjohn(int Person_ID,string testid, int Subject, string state, OleDbConnection conn) {
            
            string sql = "update T_TESTPER_ITEMS set ISPASS=@3 where PERSON_ID=@1 and SUBJECT_ID=@2 and TEST_ID=@4";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.Parameters.AddWithValue("@1", Person_ID);
            cmd.Parameters.AddWithValue("@2", Subject);
            cmd.Parameters.AddWithValue("@3", state);
            cmd.Parameters.AddWithValue("@4", testid);
            cmd.ExecuteNonQuery();
        }
        //将个人单项成绩的计算结果写入到数据库
        public void WriteGride(int Person_ID,int Subject,int result, OleDbConnection conn)
        {
            
            TestModel tm = QueryTest(testid);
            string state;
            
            if (result < tm.Standrad)
            {
                state = "不及格";
            }
            else
            {
                state = "及格";
            }
       
            string sql = "update T_TESTPER_ITEMS set RESULTS=" + result+",ISPASS='"+state+"' where PERSON_ID=" + Person_ID + " and SUBJECT_ID="+Subject;
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.ExecuteNonQuery();
        }

        //查询考核信息
        public TestModel QueryTest(string testid) {
            TestModel tm = new TestModel();
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PRJ where TEST_ID='" + testid + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            conn.Open();//打开链接
            OleDbDataReader reader = cmd.ExecuteReader();//执行查
            while (reader.Read())
            {
                tm.Testid = (string)reader["TEST_ID"];
                tm.Companyname1 = (string)reader["COMPANY_NAME"];
                tm.Sls = (int)reader["QTY_TOTAL"];
                tm.Joins = (int)reader["QTY_JOIN"];
                tm.Standrad = Convert.ToInt32(reader["STANDRAD"]);
                tm.Listid = Convert.ToInt32(reader["LIST_ID"]);
            }
            
            reader.Close();
            conn.Close();
            return tm;
        }

        //将BMI数据写入数据库
        public void WriteState(int autoID,string state, OleDbConnection conn)
        {
            string sql = "update T_TESTPER_ITEMS set ISPASS='"+state+"' where AUTO_ID="+autoID;
            OleDbCommand cmd = new OleDbCommand(sql,conn);  //sql语句 
            cmd.ExecuteNonQuery();
        }

        //将个人总成绩写入数据库
        public void WritePersonGrade(int autoid, string ispass,int result, OleDbConnection conn) {
            string sql = "update T_TEST_PERSON set BASETEST='" + ispass + "',TOTALTEST=" + result + " where AUTO_ID=" + autoid;
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.ExecuteNonQuery();
        }

        //将个人单项成绩写入数据库，成绩导入功能
        public void WritePersonScore(PersonItems pi,OleDbConnection conn) {
            try
            {
                string sql = "insert into T_TESTPER_ITEMS(TEST_ID, PERSON_ID, PERSON_NAME, SEX,COMPANY_NAME, LIST_NAME,SUBJECT_ID,SUBJECT,SCORE,LIST_ID) values(@1,@2,@3,@4,@6,@7,@8,@9,@10,@11)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@1", pi.Test_id);//TEST_ID
                cmd.Parameters.AddWithValue("@2", pi.Person_id);//PERSON_ID
                cmd.Parameters.AddWithValue("@3", pi.Person_name);//PERSON_NAME
                cmd.Parameters.AddWithValue("@4", pi.Sex);//SEX
                cmd.Parameters.AddWithValue("@6", pi.Company_name);//COMPANY_NAME
                cmd.Parameters.AddWithValue("@7", pi.List_name);//HEIGHT
                cmd.Parameters.AddWithValue("@8", pi.Subject_id);//WEIGHT
                cmd.Parameters.AddWithValue("@9", pi.Subject_name);//LIST_NAME
                cmd.Parameters.AddWithValue("@10", pi.Score);//COMPANY_ID
                cmd.Parameters.AddWithValue("@11", pi.List_id);//COMPANY_ID
                int a = cmd.ExecuteNonQuery();
            }
            catch {
                MessageBox.Show("插入信息有误，请重新插入！！！");
            }
            
        }

        //显示关闭数据库
        public void ConnClose(OleDbConnection conn) {
            if (conn != null)
            {
                conn.Close();
            }
        }
        public void ConnClose(OleDbConnection conn, OleDbDataReader reader) {
            if (conn != null) {
                conn.Close();
            }
            if (reader != null) {
                reader.Close();
            }
        }
    }
}
