using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Common
{
    public interface ILoggerManager
    {
        void LogError(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogInfo(string message);
    }
}
