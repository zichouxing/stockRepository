using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection;

using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.data
{
    class ZSZQDataImport : IDataImport
    {
        private string sheetName = "wt";

        public List<TransactionRecord> ImportData(String filePath)
        {
            DataSet ds = ExcelToDataSet(filePath, sheetName); 
            List<TransactionRecord> trList = DataSetToList(ds);
            return trList;
        }

        public DataSet ExcelToDataSet(string excelFile, string sheetName)
        {
            DataSet ds = new DataSet();
            try
            {
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = string.Format("SELECT * FROM [{0}$]", sheetName);
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, sheetName);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<TransactionRecord> DataSetToList(DataSet ds)
        {
            if (ds == null || ds.Tables.Count <= 0)
                return null;

            DataTable dt = ds.Tables[0];
            List<TransactionRecord> trList = new List<TransactionRecord>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TransactionRecord tr = new TransactionRecord();
                PropertyInfo[] propertyInfo = tr.GetType().GetProperties();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    foreach (PropertyInfo info in propertyInfo)
                    {
                        if (dt.Rows[i][j] != DBNull.Value)
                        {
                            info.SetValue(tr, dt.Rows[i][j], null);
                        }
                        else
                        {
                            info.SetValue(tr, null, null);
                        }
                        break;
                    }
                }
                trList.Add(tr);
            }
            return trList;
        }
    }


}


























