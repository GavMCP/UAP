using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAP.Interfaces
{
    interface ISortRecordsByUserAgent
    {
        void Sort<T>(IList<T> UAPlist);
        void OutputToFile<T>(IList<T> UAPList);
    }
}

