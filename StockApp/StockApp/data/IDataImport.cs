using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.data
{
    interface IDataImport
    {
        List<TransactionRecord> ImportData(String content);

    }
}
