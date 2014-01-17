using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zVirtual.Connect.Client
{

    public class DeviceResult
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public int Showing { get; set; }
        public Datum[] Data { get; set; }
    }
}