using MTPsys.Model;
using MTPsys.Util;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 * 老兵体能标准测评
 * @auther:NyikaHE
 */
namespace MTPsys.Logic
{
    
    class Veteran
    {
        private int result,temp,subjectid;
        private string standard,test;
        private DataBase db ;
        private CaculateItems ci;
        Object score;
        Comparetion cmp = new Comparetion();
        private OleDbConnection conn;
        
        public Veteran(CaculateItems ci, OleDbConnection conn,string testid)
        {
            this.ci = ci;
            this.conn = conn;
            test = testid;
            db = new DataBase(testid);
        }
        public void Process() {
            standard = cmp.getGroup1(ci.Age);//获取年龄分组
            //获取人员成绩
            string sql1 = "select SCORE,SUBJECT_ID,AUTO_ID from T_TESTPER_ITEMS where PERSON_ID=@1 and TEST_ID=@2";
            OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@1", ci.Personid);
            cmd1.Parameters.AddWithValue("@1", test);
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
                else
                {
                    Process4(subjectid, score, autoid);
                }
                if (subjectid != 1) {
                    db.WriteGride(ci.Personid, subjectid, result, conn);
                }
            } 
        }

        //俯卧撑标准236
        public int Process1(int subjectid,Object ss) {  
            int score;
            standard = cmp.getGroup1(ci.Age);//获取年龄分组
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
                if (subjectid != 6)
                {
                    result += (score - Convert.ToInt32(readera[standard])) / 2;
                }
                else {
                    result += (score - Convert.ToInt32(readera[standard])) / 1;
                }
                
                readera.Close();
            }
            reader.Close();
            return result;
           
        }
        //单杠屈臂悬垂7
        public int Process2(int subjectid,Object ss) {
            string score;
            //获取年龄分组
            standard = cmp.getGroup1(ci.Age);
            //获取人员成绩
            
            score = (string)ss;
            //根据项目id和性别获取评分对应表
            string sql = "select * from T_RESULTS1 where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            while (reader.Read())
            {
                if (cmp.Compare(score, (string)reader[standard]))
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
                temp = cmp.GetTime(score).m - cmp.GetTime((string)readera[standard]).m;
                result += (cmp.GetTime(score).s - cmp.GetTime((string)readera[standard]).s+temp*60) / 5;
                readera.Close();
            }

            
            reader.Close();
            return result;
        }
        //3000米和蛇形跑4，5
        public int Process3(int subjectid,Object ss) {
            //获取年龄分组
            string score=(string)ss;
            standard = cmp.getGroup1(ci.Age);
            //根据项目id和性别获取评分对应表
            string sql = "select * from T_RESULTS1 where SUBJECT_ID=" + subjectid + " and SEX='" + ci.Sex + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();//执行查询
            while (reader.Read())
            {
                if (cmp.Compare1(score, (string)reader[standard]))
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
                    temp = cmp.GetTime((string)readera[standard]).m - cmp.GetTime(score).m;
                    result += (cmp.GetTime((string)readera[standard]).s - cmp.GetTime(score).s+temp*60) / 5;
                }
                else {
                    temp = cmp.GetTime((string)readera[standard]).s - cmp.GetTime(score).s;
                    result += (cmp.GetTime((string)readera[standard]).ms*10 - cmp.GetTime(score).ms+temp*100) / 10;
                }
                
                readera.Close();
            }
            reader.Close();
            return result;
        }
        //体型1
        public void Process4(int subjectid,Object ss,int auto_id) {
            string score=(string)ss;
            standard = cmp.getGroup1(ci.Age);
            //获取人员成绩
            BMIcaculate qs = new BMIcaculate();
            qs.State(auto_id, score, cmp.getGroup(ci.Age), ci.Sex, conn);
        }
       
    }
}
