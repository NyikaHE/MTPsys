using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// 打开excel文件
/// @auther NyikaHE
/// </summary>
namespace MTPsys.Logic
{
    class InputXlsx
    {
        private void inputXlsx(string Path)
        {
            string strConn2;
            string filePath = Path;
            FileInfo fileInfo = new FileInfo(filePath);
            string directory = fileInfo.DirectoryName;

            strConn2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;';";
            string strConnection = string.Format(strConn2, Path);
            OleDbConnection conn = new OleDbConnection(strConnection);
            try
            {
                conn.Open();
                String tableName = null;
                DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                tableName = dt.Rows[0][2].ToString().Trim();
                OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + tableName + "]", strConnection);
                //oada.Fill(dtOld);
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }
    }
}
