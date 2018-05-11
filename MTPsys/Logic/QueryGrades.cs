using MTPsys.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/// <summary>
/// 查询每一项分数
/// </summary>
namespace MTPsys.Logic
{
    //定义时间的结构体
    public struct Time
    {
        public int m;       //分
        public int s;       //秒
        public int ms;      //毫秒
    }

    class QueryGrades
    {
        //首先查询所有项目的情况；
        private OleDbCommand cmd;
        private OleDbConnection conn;
       
        private DataBase db = new DataBase();

        public void PersonProcess(string TestId) {
            CaculateItems ci = new CaculateItems();
            conn = Connect.getConnection();
            string sql = "select PERSON_ID,SEX,AGE,HEIGHT,WEIGHT from T_TEST_PERSON where TEST_ID=@1";
            cmd = new OleDbCommand(sql,conn);
            cmd.Parameters.AddWithValue("@1", TestId);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                ci.Personid = (string)reader[0];
                ci.Sex = (string)reader[1];
                ci.Age = (int)reader[2];
                ci.Height = (float)reader[3];
                try { ci.Weight = (float)reader[4]; } catch (Exception ex) {
                    ci.Weight = 1;
                }
                
                Worker w = new Worker(ci, conn,TestId);
                w.Process();
            }
            conn.Close();
            reader.Close();
        }
    }
}
