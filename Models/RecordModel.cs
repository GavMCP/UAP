using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAP.Interfaces;

namespace UAP.Models
{
    /// <summary>
    /// A Class to contain a line from the MemoryStream.
    /// </summary>
    internal class RecordModel : IRecordModel
    {
        public string RecordLine { get; set; }
    }
}
