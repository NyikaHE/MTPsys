using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTPsys.Model
{
    //封装个人项目信息，用于导入数据
    class PersonItems
    {
        private string test_id;
        private object person_id;
        private object person_name;
        private object sex;
        private object company_id;
        private object company_name;
        private object list_name;
        private int list_id;
        private int subject_id;
        private object subject_name;
        private object score;

        public PersonItems(string test_id, object person_id, object person_name, object sex, object company_name, object list_name, int subject_id, object subject_name, object score, int list_id)
        {
            this.Test_id = test_id;
            this.Person_id = person_id;
            this.Person_name = person_name;
            this.Sex = sex;
            this.Company_id = company_id;
            this.Company_name = company_name;
            this.List_name = list_name;
            this.Subject_id = subject_id;
            this.Subject_name = subject_name;
            this.Score = score;
            this.list_id = list_id;
        }

        public string Test_id { get => test_id; set => test_id = value; }
        public object Person_id { get => person_id; set => person_id = value; }
        public object Person_name { get => person_name; set => person_name = value; }
        public object Sex { get => sex; set => sex = value; }
        public object Company_id { get => company_id; set => company_id = value; }
        public object Company_name { get => company_name; set => company_name = value; }
        public object List_name { get => list_name; set => list_name = value; }
        public int Subject_id { get => subject_id; set => subject_id = value; }
        public object Subject_name { get => subject_name; set => subject_name = value; }
        public object Score { get => score; set => score = value; }
        public int List_id { get => list_id; set => list_id = value; }
    }
}
