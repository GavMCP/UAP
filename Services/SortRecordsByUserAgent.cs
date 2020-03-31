using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAP.Interfaces;
using System.IO;

namespace UAP.Services
{
    /// <summary>
    /// Sort the extracted Records from the RecordModel Class by User Agent.
    /// </summary>
    internal class SortRecordsByUserAgent : ISortRecordsByUserAgent
    {
        /// <summary>
        /// Copy a List of records into a temp List. Sort the temp List by user agent and then write the temp list back to the param List.
        /// </summary>
        /// <typeparam name="T">A strongly typed List of Records.</typeparam>
        /// <param name="UAPlist"></param>
        /// <returns>A sorted by User Agent Parameter List.</returns>
        public void Sort<T>(IList<T> UAPlist)
        {
            List<T> tmpList = new List<T>(UAPlist);
            tmpList.Sort();

            for (int x = 0; x < tmpList.Count; x++)
            {
                UAPlist[x] = tmpList[x];
            }

            OutputToFile(UAPlist);
        }

        /// <summary>
        /// Write to output file.
        /// </summary>
        public void OutputToFile<T>(IList<T> UAPList )
        {
            foreach(IRecordModel record in UAPList)
            {
                
            }
        }

    }
}
