using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 用于主面板插入新建测试
 */
namespace MTPsys.Model
{
    class ExamModel
    {
        private String organName;//单位名称
        private String organLevel;//单位级别
        private int peoples;//人数/实力数
        private DateTime examTime;//考核时间
        private String examID;//考核编号
        private string companyID;//单位编号
        private String examType;//考试类型

        private int standrad;//及格标准
        private int listid; //考核类型编号
        private string parent;//人员类型
        

        public ExamModel(){

        }

        public string OrganName { get => organName; set => organName = value; }
        public string OrganLevel { get => organLevel; set => organLevel = value; }
        public int Peoples { get => peoples; set => peoples = value; }
        public DateTime ExamTime { get => examTime; set => examTime = value; }
        public string ExamID { get => examID; set => examID = value; }
        public string ExamType { get => examType; set => examType = value; }
       
        public string CompanyID { get => companyID; set => companyID = value; }
        public int Standrad { get => standrad; set => standrad = value; }
        public string Parent { get => parent; set => parent = value; }
        public int Listid { get => listid; set => listid = value; }
    }
}
