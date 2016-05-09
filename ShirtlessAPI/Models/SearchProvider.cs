using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public interface SearchProvider
    {
        IEnumerable<SearchResult> Get(string query);

        IEnumerable<SearchResult> Post(string query);
    }
}