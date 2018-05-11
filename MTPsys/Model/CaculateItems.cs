using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 用于多线程处理单项成绩时传递参数
 */
namespace MTPsys.Model
{
    class CaculateItems
    {
        private string personid;
        private string sex;
        private int age;
        private float height;
        private float weight;


        public string Personid { get => personid; set => personid = value; }
        public string Sex { get => sex; set => sex = value; }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }
    }
}
