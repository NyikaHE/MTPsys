using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MTPsys
{
    class Connect
    {
        public static OleDbConnection getConnection()
        {
            //相对路径\\database\\db.mdb;
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+System.Windows.Forms.Application.StartupPath + "\\MTP1.mdb";
            OleDbConnection conn = new OleDbConnection(strConnection);  //建立连接  
            return conn;
        }
    }
}
