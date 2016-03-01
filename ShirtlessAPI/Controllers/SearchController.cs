using ShirtlessAPI.Helpers;
using ShirtlessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShirtlessAPI.Controllers
{
    public class SearchController : ApiController
    {
        protected SearchProvider _searchProvider { get; set; }
        protected LogProvider _logProvider { get; set; }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IEnumerable<SearchResult> Get(string query)
        {
            _logProvider.Log(query);
            return _searchProvider.Get(query);            
        }

        #region Constructors

        public SearchController()
        {
            _searchProvider = new BingSearchProvider();
            _logProvider = new EntityLogProvider();
        }
        #endregion
    }
}