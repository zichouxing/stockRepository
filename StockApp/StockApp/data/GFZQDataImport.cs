using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using WindowsFormsApplication1.model;

namespace WindowsFormsApplication1.data
{
    class GFZQDataImport : IDataImport
    {
        List<TransactionRecord> importData(String content)
        {
            throw new System.NotSupportedException("import data for GFZQ is not supported.");
        }

        List<TransactionRecord> importData(FileStream fileStream)
        {
            throw new System.NotSupportedException("import data for GFZQ is not supported.");
        }
    }
}
