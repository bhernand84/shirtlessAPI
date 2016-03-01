using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public interface LogProvider
    {
        void Log(string query);
        IEnumerable<string> GetLogs();
    }
}