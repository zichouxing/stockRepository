using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.data;
using WindowsFormsApplication1.model;
using WindowsFormsApplication1.dao;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
            ZSZQDataImport t = new ZSZQDataImport();
            List<TransactionRecord> records = t.ImportData("C://workspace//stockRepository//StockApp//StockApp//test.xls");

            
            

            TransactionDaoSqlite tds = new TransactionDaoSqlite();
            tds.saveTransactionRecords("stockDB.fundflow", records);

        }
    }
}
