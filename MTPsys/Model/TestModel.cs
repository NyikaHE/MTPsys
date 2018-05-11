using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 用于打开页面显示单位信息
 */
namespace MTPsys.Model
{
    class TestModel
    {
        private string testid;
        private string Companyname;
        private int sls;
        private int joins;
        private int standrad;

        public string Testid { get => testid; set => testid = value; }
        public string Companyname1 { get => Companyname; set => Companyname = value; }
        public int Sls { get => sls; set => sls = value; }
        public int Joins { get => joins; set => joins = value; }
        public int Standrad { get => standrad; set => standrad = value; }
    }
}
