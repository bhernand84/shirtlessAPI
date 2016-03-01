using ShirtlessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShirtlessAPI.Controllers
{
    public class LogController : ApiController
    {
        protected LogProvider _logProvider { get; set; }

        public IEnumerable<string> Get()
        {
            return _logProvider.GetLogs();
        }

        public LogController()
        {
            _logProvider = new DummyLogger();
        }
    }
}
