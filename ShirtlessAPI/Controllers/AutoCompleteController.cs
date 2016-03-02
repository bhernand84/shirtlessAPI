using ShirtlessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShirtlessAPI.Controllers
{
    public class SpellingSuggestionsController : ApiController
    {
        protected SpellingSuggestionsProvider spellingSuggestionsProvider { get; set; }

        public IEnumerable<string> Get(string query)
        {
            return spellingSuggestionsProvider.Get(query);
        }

        public SpellingSuggestionsController()
        {
            spellingSuggestionsProvider = new BingSpellingSuggestionsProvider();
        }
    }
}
