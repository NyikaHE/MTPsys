using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MTPsys.Logic
{
    //测评体脂和BMI
    class QueryStatue
    {
        public void State(int autoID,string score,string age,string gender, OleDbConnection conn)
        {
            string result;
            int grade;
            Dictionary<string, double> MBMI = new Dictionary<string, double>();
            Dictionary<string, double> WBMI = new Dictionary<string, double>();
            Dictionary<string, double> MPBF = new Dictionary<string, double>();
            Dictionary<string, double> WPBF = new Dictionary<string, double>();
            //基准18.5
            MBMI.Add("M0",25.9);
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
            MPBF.Add("M0",20.7);
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
                    grade = 100;
                }
                else
                {
                    result = "不及格";
                    grade = 0;
                }

            }
            else {
                if (sc >= 18.5 && sc <= WBMI[age])
                {
                    result = "及格";
                    grade = 100;
                }
                else
                {
                    result = "不及格";
                    grade = 0;
                }

            }
            //将结果写入成绩中；
            DataBase db = new DataBase();
            db.WriteState(autoID,result,grade,conn);
        }
        //体型转化；
        public void Process() {
            string score;
            string pid;
            double weight=1, height=1;
            OleDbConnection conn = Connect.getConnection();
            string sql = "select HEIGHT,WEIGHT,PERSON_ID from T_TEST_PERSON";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            conn.Open();//打开链接
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            //reader.HasRows当前查询结果是否为空
            while (reader.Read())
            {
                if (reader[1] == DBNull.Value)
                {
                    weight = 1;
                }
                else if (reader[0] == DBNull.Value)
                {
                    height = 1;
                }
                else {
                    weight = Convert.ToDouble(reader[1]);
                    height = Convert.ToDouble(reader[0]);
                }
                
                pid = (string)reader[2];
                score = Convert.ToString(weight / (height * height / 10000));
                sql = "update T_TESTPER_ITEMS set SCORE='"+score+"' where PERSON_ID='"+pid+"' and SUBJECT_ID=1";
                cmd = new OleDbCommand(sql,conn);           
                cmd.ExecuteNonQuery();
                
            }
            reader.Close();
            conn.Close();
        }
    }
}
