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
        private String organName;
        private String organLevel;
        private int peoples;
        private DateTime examTime;
        private String examID;
        private string companyID;
        private String examType;
        private String peopleType;
        private int standrad;
        private string parent;
        

        public ExamModel(){

        }

        public string OrganName { get => organName; set => organName = value; }
        public string OrganLevel { get => organLevel; set => organLevel = value; }
        public int Peoples { get => peoples; set => peoples = value; }
        public DateTime ExamTime { get => examTime; set => examTime = value; }
        public string ExamID { get => examID; set => examID = value; }
        public string ExamType { get => examType; set => examType = value; }
        public string PeopleType { get => peopleType; set => peopleType = value; }
        public string CompanyID { get => companyID; set => companyID = value; }
        public int Standrad { get => standrad; set => standrad = value; }
        public string Parent { get => parent; set => parent = value; }
    }
}
