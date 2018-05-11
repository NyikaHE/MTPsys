using MTPsys.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//定义线程处理成绩
namespace MTPsys.Logic
{
    
    class Worker
    {
        private int result,subjectid;
        private string standard;
        private DataBase db ;
        private CaculateItems ci;
        Object score;
        private OleDbConnection conn;
        
        public Worker(CaculateItems ci, OleDbConnection conn,string testid)
        {
            this.ci = ci;
            this.conn = conn;
            
            db = new DataBase(testid);
        }
        public void Process() {
            standard = getGroup1(ci.Age);//获取年龄分组
            //获取人员成绩
            string sql1 = "select SCORE,SUBJECT_ID,AUTO_ID from T_TESTPER_ITEMS where PERSON_ID=@1";
            OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@1", ci.Personid);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read()) {
                score = reader1[0];
                subjectid = (int)reader1[1];
                int autoid = (int)reader1[2];
                if (subjectid == 2 || subjectid == 3 || subjectid == 6)
                {
                    Process1(subjectid, score);
                }
                else if (subjectid == 7)
                {
                    Process2(subjectid, score);
                }
                else if (subjectid == 4 || subjectid == 5)
                {
                    Process3(subjectid, score);
                }
                else if (subjectid == 8)
                {
                    Process5(subjectid, score);
                }
                else
                {
                    Process4(subjectid, score, autoid);
                }
                
            }
            
        }

        //俯卧撑标准236
        public void Process1(int subjectid,Object ss) {  
            int score;
            standard = getGroup1(ci.Age);//获取年龄分组
                                         //获取人员成绩
            score = Convert.ToInt32(ss);
            string sql = "select * from T_RESULTS where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            while (reader.Read())
            {
                if ( score >=Convert.ToInt32(reader[standard]))
                {
                    result = (int)reader["RESULTS"];
                    break;
                }
                result = 0;
            }
            if (result == 100) {
                string sql1 = "select * from T_RESULTS_MAX where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
                OleDbCommand cmda = new OleDbCommand(sql, conn);
                OleDbDataReader readera = cmda.ExecuteReader();
                readera.Read();
                result += (score - Convert.ToInt32(readera[standard])) / 2;
                readera.Close();
            }
            db.WriteGride(ci.Personid, subjectid, result, conn);
            //根据项目id和性别获取评分对应表
            reader.Close();
        }
        //单杠屈臂悬垂7
        public void Process2(int subjectid,Object ss) {
            string score;
            //获取年龄分组
            standard = getGroup1(ci.Age);
            //获取人员成绩
            score = (string)ss;
            //根据项目id和性别获取评分对应表
            string sql = "select * from T_RESULTS1 where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            while (reader.Read())
            {
                if (Compare(score, (string)reader[standard]))
                {
                    result = (int)reader["RESULTS"];
                    break;
                }
                result = 0;
            }
            if (result == 100) {
                string sql1 = "select * from T_RESULTS1_MAX where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
                OleDbCommand cmda = new OleDbCommand(sql, conn);
                OleDbDataReader readera = cmda.ExecuteReader();
                readera.Read();
                result+= (GetTime(score).s - GetTime((string)readera[standard]).s) / 5;
                readera.Close();
            }

            db.WriteGride(ci.Personid, subjectid, result, conn);
            reader.Close();
        }
        //3000米和蛇形跑4，5
        public void Process3(int subjectid,Object ss) {
            //获取年龄分组
            string score=(string)ss;
            standard = getGroup1(ci.Age);
            
            //根据项目id和性别获取评分对应表
            string sql = "select * from T_RESULTS1 where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            while (reader.Read())
            {
                if (Compare1(score, (string)reader[standard]))
                {
                    result = (int)reader["RESULTS"];
                    break;
                }
                result = 0;
            }
            if (result == 100)
            {
                string sql1 = "select * from T_RESULTS1_MAX where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
                OleDbCommand cmda = new OleDbCommand(sql, conn);
                OleDbDataReader readera = cmda.ExecuteReader();
                readera.Read();
                if (subjectid == 5)
                {
                    result += (GetTime((string)readera[standard]).s - GetTime(score).s) / 5;
                }
                else {
                    result += (GetTime((string)readera[standard]).ms*10 - GetTime(score).ms) / 10;
                }
                
                readera.Close();
            }
            db.WriteGride(ci.Personid, subjectid, result, conn);
            reader.Close();
        }
        //体型1
        public void Process4(int subjectid,Object ss,int auto_id) {
            string score=(string)ss;
            standard = getGroup1(ci.Age);
            //获取人员成绩
            QueryStatue qs = new QueryStatue();
            qs.State(auto_id, score, getGroup(ci.Age), ci.Sex, conn);
        }
        //新兵项目8
        public void Process5(int subjectid, Object ss) {
            string state;
            Console.WriteLine(ss);
            
            if (ci.Sex == "男")
            {
                int score = Convert.ToInt32(ss);
                if (score >= 18)
                {
                    state = "优秀";
                    result = 90;
                }
                else if (score >= 12)
                {
                    state = "良好";
                    result = 70;
                }
                else if (score >= 6)
                {
                    result = 60;
                    state = "及格";
                }
                else
                {
                    result = 0;
                    state = "不及格";
                }
            }
            else {
                double score = Convert.ToDouble(ss);
                if (score >= 3.4)
                {
                    state = "优秀";
                    result = 90;
                }
                else if (score >= 2.8)
                {
                    state = "良好";
                    result = 70;
                }
                else if (score >= 1.5)
                {
                    state = "及格";
                    result = 60;
                }
                else
                {
                    state = "不及格";
                    result = 0;
                }
            }
            string sql = "update T_TESTPER_ITEMS set RESULTS=" + result + ",ISPASS='" + state + "' where PERSON_ID='" +ci.Personid + "' and SUBJECT_ID=" + subjectid;
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            cmd.ExecuteNonQuery();
        }

        //6段表
        public string getGroup(int age)
        {
            if (age <= 24)
            {
                return "M0";
            }
            else if (age >= 25 && age <= 29)
            {
                return "M1";
            }
            else if (age >= 30 && age <= 39)
            {
                return "M2";
            }
            else if (age >= 40 && age <= 49)
            {
                return "M3";
            }
            else if (age >= 50 && age <= 59)
            {
                return "M4";
            }
            else
            {
                return "M5";
            }
        }
        //13段表
        public string getGroup1(int age)
        {
            if (age <= 24)
            {
                return "M0";
            }
            else if (age >= 25 && age <= 27)
            {
                return "M1";
            }
            else if (age >= 28 && age <= 30)
            {
                return "M2";
            }
            else if (age >= 31 && age <= 33)
            {
                return "M3";
            }
            else if (age >= 34 && age <= 36)
            {
                return "M4";
            }
            else if (age >= 37 && age <= 39)
            {
                return "M5";
            }
            else if (age >= 40 && age <= 42)
            {
                return "M6";
            }
            else if (age >= 43 && age <= 45)
            {
                return "M7";
            }
            else if (age >= 46 && age <= 48)
            {
                return "M8";
            }
            else if (age >= 49 && age <= 51)
            {
                return "M9";
            }
            else if (age >= 52 && age <= 54)
            {
                return "M10";
            }
            else if (age >= 55 && age <= 57)
            {
                return "M11";
            }
            else
            {
                return "M12";
            }
        }
        //时间比较,第一段时间大于第二段时间返回true；
        public Boolean Compare(string r1, string r2)
        {
            Time t1, t2;
            t1 = GetTime(r1);
            t2 = GetTime(r2);
            if (t1.m > t2.m)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s > t2.s)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s == t2.s && t1.ms >= t2.ms*10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean Compare1(string r1, string r2)
        {
            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            Time t1, t2;
            t1 = GetTime(r1);
            t2 = GetTime(r2);
            if (t1.m < t2.m)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s < t2.s)
            {
                return true;
            }
            else if (t1.m == t2.m && t1.s == t2.s && t1.ms <= t2.ms * 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //字符串切割；
        public Time GetTime(string t)
        {
            Time gol;
            int[] num = new int[3];
            int j = 2;
            string[] sArray = t.Split(new char[6] { '“', '”', '’', '‘', '\u0027', '"' });
            for(int i= sArray.Length-1; i>=0;i--)
            {
                if (sArray[i]!="")
                {
                    //Console.WriteLine(t);
                    try {
                        num[j] = Convert.ToInt32(sArray[i]);
                    }
                    catch (Exception ex) {
                        num[j] = 0;
                        //Console.WriteLine(t);
                        MessageBox.Show(ex.Message,t);
                    }
                    
                }
                j--;
            }
            gol.m = num[0];
            gol.s = num[1];
            gol.ms = num[2];
            return gol;
        }
    }
}
