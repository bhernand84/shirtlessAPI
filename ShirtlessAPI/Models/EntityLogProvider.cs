using ShirtlessAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class EntityLogProvider : LogProvider
    {
        protected SearchRepository searchRepository { get; set; }

        public IEnumerable<string> GetLogs()
        {
            return searchRepository.GetSearchListings().Select(m=>m.SearchTerm);
        }

        public void Log(string query)
        {
            searchRepository.Add(query);
        }

        public EntityLogProvider()
        {
            searchRepository = new SearchRepository();
        }
    }
}