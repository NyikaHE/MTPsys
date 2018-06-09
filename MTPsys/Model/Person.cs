using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 打开人员信息页面显示个人信息时查询参数传递
 */
namespace MTPsys.Model
{
    class Person
    {
        private string id;
        private int listid;
        private string testype;
        private string company;
        private string name;
        private string gender;
        private int age;
        private String height;
        private String weight;
        private int grade;
        private string ispass;

        public Person()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }  
        
        public String Height { get => height; set => height = value; }
        public String Weight { get => weight; set => weight = value; }
        public int Grade { get => grade; set => grade = value; }
        public string Ispass { get => ispass; set => ispass = value; }
        public string Id { get => id; set => id = value; }
        public string Testype { get => testype; set => testype = value; }
        public string Company { get => company; set => company = value; }
        public int Listid { get => listid; set => listid = value; }
    }
}
