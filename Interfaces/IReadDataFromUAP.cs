using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UAP.Interfaces
{
    interface IReadDataFromUAP
    {
        MemoryStream ReadData();
    }
}
