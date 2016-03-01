using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class DummyLogger : LogProvider
    {
        public IEnumerable<string> GetLogs()
        {
            return new List<string>()
            {
                "Tom Hardy",
                "Stephen Amell",
                "Christian Bale",
                "Chris Helmsworth",
                "Soccer players"
            };
        }

        public void Log(string query)
        {
            
        }
    }
}