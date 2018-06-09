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
    class ItemGrade
    {
        //首先查询所有项目的情况；
        private OleDbCommand cmd;
        private OleDbConnection conn;
        private int listid;
        private DataBase db = new DataBase();

        public void PersonProcess(string TestId) {
            CaculateItems ci = new CaculateItems();
            conn = Connect.getConnection();
            string sql = "select PERSON_ID,SEX,AGE,LIST_ID from T_TEST_PERSON where TEST_ID=@1";
            cmd = new OleDbCommand(sql,conn);
            cmd.Parameters.AddWithValue("@1", TestId);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                ci.Personid = (int)reader[0];
                ci.Sex = (string)reader[1];
                ci.Age = (int)reader[2];
                listid= (int)reader[3];
                if (listid == 2)
                {
                    Veteran w = new Veteran(ci, conn, TestId);
                    w.Process();
                }
                else {
                    BigJohn bj = new BigJohn(ci,TestId, conn);
                    bj.Process();
                }
            }
            conn.Close();
            reader.Close();
        }
    }
}
