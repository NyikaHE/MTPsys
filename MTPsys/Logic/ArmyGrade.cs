/*
 * 统计整支队伍的考核成绩
 */
using MTPsys.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MTPsys.Logic
{
    class ArmyGrade
    {
        public void Process(string testid)
        {
            //countF不及格人数，countP总人数
            int countP=0, countS,countF=0;
            OleDbConnection conn = Connect.getConnection();
            string sql = "select * from T_TEST_PERSON where TEST_ID = '"+testid+"'";
            OleDbCommand cmd = new OleDbCommand(sql,conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                countP++;
                if ((string)reader["BASETEST"] == "不及格")
                    countF++;
            }
            float SProba, JProba;
            DataBase db = new DataBase();
            countS = countP - countF;
            TestModel tm = db.QueryTest(testid);

            SProba = (float) countS / countP;
            JProba = (float)countP /tm.Sls;
            string sql1 = "update T_TEST_PRJ set QTY_JOIN=" + countP + ",QTY_RATE=" + JProba + ",TEST_PASS=" + countS + ",TEST_FAIL=" + countF + ",TEST_RATE=" + SProba + " where TEST_ID='"+testid+"'";
            OleDbCommand cmd1 = new OleDbCommand(sql1,conn);
            cmd1.ExecuteNonQuery();
            reader.Close();
            conn.Close();
        }
    }
}
