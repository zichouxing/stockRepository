using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.dao
{
    class TransactionDaoSqlite : ITransactionDao
    {
        public void saveTransactionRecords(String tableName, List<TransactionRecord> records)
        {
            StringBuilder sb = new System.Text.StringBuilder();
            foreach (TransactionRecord tr in records)
            {
                sb.Append("INSERT INTO ");
                sb.Append(tableName);
                sb.Append(" VALUES(");
                String valueString = tr.Currency + ", " + tr.StockName + ", " + tr.TransactionDate + ", " + tr.TransactionPrice + ", " + tr.TransactionVolumn + ", " + tr.TransactionAmount + ", " + tr.FundBalance + ", " + tr.ContractNumber + ", " + tr.BussinessName + ", " + tr.CommmisionCharge + ", " + tr.StampTax + tr.TransferFee + ", " + tr.ClearingFee + ", " + tr.StockCode + ", " + tr.ShareholderCode;
                sb.Append(valueString);
                sb.Append(");\r\n ");
            }
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = sb.ToString();
            cmd.ExecuteNonQuery();
        }
    }
}
