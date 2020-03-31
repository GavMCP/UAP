using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAP.Interfaces;
using UAP.Data;
using System.IO;
using UAP.Models;

namespace UAP.Services
{
    internal class GetFileContentService : IGetFileContentService
    {
        // Interface to the Data Layer.
        IReadDataFromUAP MemoryStream = new ReadDataFromUAP();

        List<IRecordModel> Records = new List<IRecordModel>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A MemoryStream object containing the contents of the UAP textfile.</returns>
        public MemoryStream GetMemoryStream()
        {
            return MemoryStream.ReadData();
        }


        /// <summary>
        /// Reads each line of the MemoryStream. Foreach line a new Model class is created and the line is writen to the Class property.
        /// Next the RecordModel Class is added to the List<IRecordModel>.
        /// </summary>
        public void ReadMemoryStream()
        {
            MemoryStream MS = GetMemoryStream();

            using(StreamReader sr = new StreamReader(MS))
            {
                try
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        IRecordModel newRecord = new RecordModel();
                        newRecord.RecordLine = line;
                        Records.Add(newRecord);
                    }
                }
                catch(OutOfMemoryException outEx)
                {
                    Console.WriteLine($"OutOfMemoryException: {outEx.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message} {ex.InnerException} {ex.StackTrace}");
                }
            }
        }

        /// <summary>
        /// List of Records.
        /// </summary>
        /// <returns>A List of each record from the MemoryStream.</returns>
        public List<IRecordModel> GetRecordList()
        {
            return Records;
        }
    }
}
