using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using UAP.Interfaces;

namespace UAP.Data
{

    /// <summary>
    /// Reads the content of the UAP file and copies into Memory.
    /// </summary>
    public class ReadDataFromUAP : IReadDataFromUAP
    {
        private string UAPfilePath = ConfigurationManager.AppSettings["Path"];

        public MemoryStream InMemory = new MemoryStream();

        /// <summary>
        /// Open UAP file for reading and copying into memory.
        /// </summary>
        /// <returns>MemoryStream object with the contents of the UAP file.</returns>
        public MemoryStream ReadData()
        {
            using(FileStream fileStream = File.OpenRead(UAPfilePath))
            {
                fileStream.CopyTo(InMemory);
            }

            return InMemory;
        }
    }
}
