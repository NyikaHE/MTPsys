using MTPsys.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MTPsys.Logic
{
    
    class PersonGrade
    {
        public void Process(int standrad)
        {
            int result=0, autoid;
            DataBase db = new DataBase();
            string personid,ispass="及格";
            OleDbDataReader reader1;
            //查询每个人的成绩
            OleDbConnection conn = Connect.getConnection();
            string sql = "select PERSON_ID,AUTO_ID from T_TEST_PERSON";
            OleDbCommand cmd = new OleDbCommand(sql, conn);  //sql语句 
            conn.Open();//打开链接
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            while (reader.Read()) {
                ispass = "及格";
                result = 0;
                personid = (string)reader[0];
                autoid = (int)reader[1];
                string sql1 = "select RESULTS,ISPASS from T_TESTPER_ITEMS where PERSON_ID='"+personid+"'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, conn);  //sql语句 
                reader1 = cmd1.ExecuteReader();//执行查询
                while (reader1.Read()) {
                    if ((string)reader1[1] == "不及格") {
                        ispass = "不及格";
                    }
                    result += (int)reader1[0];
                }
                reader1.Close();
                if (ispass != "不及格"&&standrad==65) {
                    
                }
                
                db.WritePersonGrade(autoid, ispass, conn);
            }
            
            db.ConnClose(conn,reader);
        }
        public string Standrad1(int result) {
            string ispass;
            if (result < 260)
            {
                ispass = "不及格";
            }
            else if (result >= 260 && result < 340)
            {
                ispass = "及格";
            }
            else if (result >= 340 && result < 380)
            {
                ispass = "良好";
            }
            else if (result >= 380 && result < 440)
            {
                ispass = "优秀";
            }
            else if (result >= 440 && result < 480)
            {
                ispass = "特3级";
            }
            else if (result >= 480 && result < 500)
            {
                ispass = "特2级";
            }
            else
            {
                ispass = "特1级";
            }
            return ispass;
        }
        public string Standrad2(int result)
        {
            string ispass;
            if (result < 240)
            {
                ispass = "不及格";
            }
            else if (result >= 240 && result < 320)
            {
                ispass = "及格";
            }
            else if (result >= 320 && result < 360)
            {
                ispass = "良好";
            }
            else if (result >= 360 && result < 440)
            {
                ispass = "优秀";
            }
            else if (result >= 440 && result < 480)
            {
                ispass = "特3级";
            }
            else if (result >= 480 && result < 500)
            {
                ispass = "特2级";
            }
            else
            {
                ispass = "特1级";
            }
            return ispass;
        }
        public string Standrad3(int result)
        {
            string ispass;
            if (result < 220)
            {
                ispass = "不及格";
            }
            else if (result >= 220 && result < 300)
            {
                ispass = "及格";
            }
            else if (result >= 300 && result < 340)
            {
                ispass = "良好";
            }
            else if (result >= 340 && result < 440)
            {
                ispass = "优秀";
            }
            else if (result >= 440 && result < 480)
            {
                ispass = "特3级";
            }
            else if (result >= 480 && result < 500)
            {
                ispass = "特2级";
            }
            else
            {
                ispass = "特1级";
            }
            return ispass;
        }
        //将成绩写入到Rerson数据库
    }
}
