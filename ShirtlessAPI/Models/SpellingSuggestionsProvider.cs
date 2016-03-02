using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public interface SpellingSuggestionsProvider
    {
        IEnumerable<string> Get(string query);
    }
}