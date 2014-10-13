using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.dao
{
    interface ITransactionDao
    {
        void saveTransactionRecords(String name, List<TransactionRecord> records);
    }
}
