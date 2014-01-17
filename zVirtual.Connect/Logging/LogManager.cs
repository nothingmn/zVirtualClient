using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zVirtual.Connect.Contracts;

namespace zVirtual.Connect.Logging
{
    public class LogManager
    {
        public static ILog GetLogger<T>()
        {
#if WINDOWS_PHONE
               return new WindowsPhoneLogger<T>();
#endif
#if ANDROID
            return new AndroidLogger<T>();
#endif
#if NETFX_CORE
            return new StoreLogger<T>();
#else
            return new ConsoleLogger<T>();
#endif

        }
    }
}