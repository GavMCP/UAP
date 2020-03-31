using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using UAP.Interfaces;
using UAP.Services;

namespace UAP
{
    class Program
    {
        static void Main(string[] args)
        {
            IGetFileContentService GetFile = new GetFileContentService();

            ISortRecordsByUserAgent SortRecords = new SortRecordsByUserAgent();


            GetFile.ReadMemoryStream();
            List<IRecordModel> ExtractedRecords = GetFile.GetRecordList();
            SortRecords.Sort(ExtractedRecords);
           
            
        }
    }
}
