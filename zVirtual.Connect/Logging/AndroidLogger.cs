using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zVirtual.Connect.Contracts;

namespace zVirtual.Connect.Logging
{
#if ANDROID

    public class AndroidLogger<T> : ILog
    {
        private T type;
        private string typeName = typeof (T).FullName;

        public void Debug(object message)
        {
            DebugFormat("{0}", message);
        }

        public void Debug(object message, Exception exception)
        {
            DebugFormat("{0} - {1}", message, exception);
        }


        public void DebugFormat(string format, params object[] args)
        {
            Android.Util.Log.Debug("DEBUG (" + typeName + ")", null, format, args);
        }

        public void Info(object message)
        {
            throw new NotImplementedException();
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(object message)
        {
            throw new NotImplementedException();
        }

        public void Error(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool IsDebugEnabled { get; private set; }
        public bool IsInfoEnabled { get; private set; }
        public bool IsWarnEnabled { get; private set; }
        public bool IsErrorEnabled { get; private set; }
        public bool IsFatalEnabled { get; private set; }
    }
#endif
}
