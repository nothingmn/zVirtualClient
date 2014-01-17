using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zVirtual.Connect.Contracts;

namespace zVirtual.Connect.Client
{
    public class ClientManager
    {
        public static IWebApiClient Client
        {
            get { return null; }
            //new DefaultClient(); }

        }
    }
}
