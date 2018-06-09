using MTPsys.Model;
using MTPsys.Util;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
/*
 * 1、新兵体能标准
 * @auther:NyikaHE
 */
namespace MTPsys.Logic
{
    class BigJohn
    {
        private int subjectid;//项目编号
        private DataBase db;
        private CaculateItems ci;
        Object score;
        Comparetion cmp = new Comparetion();
        private OleDbConnection conn;
        private string test;

        public BigJohn(CaculateItems ci,string testid, OleDbConnection conn)
        {
            this.ci = ci;
            this.conn = conn;
            test = testid;
            db = new DataBase();
        }

        public void Process()
        {
            //获取人员成绩
            string result;
            Comparetion cmp = new Comparetion();
            string age;
            string sql1 = "select SCORE,SUBJECT_ID from T_TESTPER_ITEMS where PERSON_ID=@1 and TEST_ID=@2";
            OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@1", ci.Personid);
            cmd1.Parameters.AddWithValue("@2", test);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                age = cmp.getGroup(ci.Age);
                score = reader1[0];
                subjectid = (int)reader1[1];
                string gender = ci.Sex;
                if (subjectid == 1)
                {
                    result=Process1(subjectid, score,age,gender);
                }
                else if (subjectid == 3)
                {
                    result = Process2(subjectid, score,gender);
                }
                else if (subjectid ==6)
                {
                    result = Process3(subjectid, score,gender);
                }
                else if (subjectid == 7)
                {
                    result = Process4(subjectid, score,gender);
                }
                else if (subjectid == 8)
                {
                    result = Process5(subjectid, score);
                }
                else
                {
                    result = Process6(subjectid, score, gender);
                }
                db.WriteBigjohn(ci.Personid, test, subjectid,result,conn);
                
            }
        }
        //体型
        private string Process1(int subjectid, object score,string age,string gender)
        {
            string result;
            Dictionary<string, double> MBMI = new Dictionary<string, double>();
            Dictionary<string, double> WBMI = new Dictionary<string, double>();
            Dictionary<string, double> MPBF = new Dictionary<string, double>();
            Dictionary<string, double> WPBF = new Dictionary<string, double>();
            //基准18.5
            MBMI.Add("M0", 25.9);
            MBMI.Add("M1", 26.9);
            MBMI.Add("M2", 27.9);
            MBMI.Add("M3", 28.9);
            MBMI.Add("M4", 29.4);
            MBMI.Add("M5", 29.9);
            //基准18.5
            WBMI.Add("M0", 23.9);
            WBMI.Add("M1", 24.9);
            WBMI.Add("M2", 25.9);
            WBMI.Add("M3", 26.9);
            WBMI.Add("M4", 27.4);
            WBMI.Add("M5", 27.9);
            //基准6.0
            MPBF.Add("M0", 20.7);
            MPBF.Add("M1", 21.7);
            MPBF.Add("M2", 22.7);
            MPBF.Add("M3", 23.7);
            MPBF.Add("M4", 24.3);
            MPBF.Add("M5", 24.9);
            //基准14.0
            WPBF.Add("M0", 30.1);
            WPBF.Add("M1", 30.6);
            WPBF.Add("M2", 31.1);
            WPBF.Add("M3", 31.6);
            WPBF.Add("M4", 31.7);
            WPBF.Add("M5", 31.9);
            //判断；
            double sc = Convert.ToDouble(score);
            if (gender == "男")
            {
                if (sc >= 18.5 && sc <= MBMI[age])
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }

            }
            else
            {
                if (sc >= 18.5 && sc <= WBMI[age])
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }

            }
            return result;
        }
        //仰卧起坐
        private string Process2(int subjectid, object score,string gender)
        {
            string result;
            int ss = Convert.ToInt32(score);
            if (gender == "男")
            {
                if (ss >= 70)
                {
                    result = "优秀";
                }
                else if (ss < 70 && ss >= 62)
                {
                    result = "良好";
                }
                else if (ss < 62 && ss >= 45)
                {
                    result = "及格";
                }
                else {
                    result = "不及格";
                }
            }
            else
            {
                if (ss >= 60)
                {
                    result = "优秀";
                }
                else if (ss < 60 && ss >= 50)
                {
                    result = "良好";
                }
                else if (ss < 50 && ss >= 40)
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }
            }
            return result;
        }
        //引体向上
        private string Process3(int subjectid, object score,string gender)
        {
            string result;
            int ss = Convert.ToInt32(score);
            if (ss >= 15)
            {
                result = "优秀";
            }
            else if (ss < 15 && ss >= 10)
            {
                result = "良好";
            }
            else if (ss < 10 && ss >= 5)
            {
                result = "及格";
            }
            else
            {
                result = "不及格";
            }
            return result;
        }
        //单杠屈臂悬垂
        private string Process4(int subjectid, object score, string gender)
        {
            string result;
            string ss = Convert.ToString(score);

            if (cmp.Compare(ss, "45\u0022")) {
                result = "优秀";
            }
            else if (cmp.Compare(ss, "30\u0022"))
            {
                result = "良好";
            }
            else if (cmp.Compare(ss, "20\u0022"))
            {
                result = "及格";
            }
            else
            {
                result = "不及格";
            }
            return result;
        }
        //双杠臂屈伸
        private string Process5(int subjectid, object score)
        {
            string result;
            
            int ss = Convert.ToInt32(score);
            if (ss >= 18)
            {
                result = "优秀";
                
            }
            else if ( ss >= 12)
            {
                result = "良好";
            }
            else if (ss >= 6)
            {
                result = "及格";
            }
            else
            {
                result = "不及格";
            }
            
            return result;
        }
        //3000米
        private string Process6(int subjectid, object score, string gender)
        {
            string result;
            string ss = Convert.ToString(score);
            if (gender == "男")
            {
                if (cmp.Compare("12\u0027" + "40\u0022", ss))
                {
                    result = "优秀";
                }
                else if (cmp.Compare("13\u0027" + "30\u0022", ss))
                {
                    result = "良好";
                }
                else if (cmp.Compare("14\u0027" + "20\u0022", ss))
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }
            }
            else {
                if (cmp.Compare("15\u0027" + "30\u0022", ss))
                {
                    result = "优秀";
                }
                else if (cmp.Compare("16\u0027" + "00\u0022", ss))
                {
                    result = "良好";
                }
                else if (cmp.Compare("17\u0027" + "00\u0022", ss))
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }
            }
            return result;
        }
    }
}
