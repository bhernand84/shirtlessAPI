using ShirtlessAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class BingSpellingSuggestionsProvider : SpellingSuggestionsProvider
    {
        public IEnumerable<string> Get(string query)
        {
            // Create a Bing container.

            string rootUri = "https://api.datamarket.azure.com/Bing/Search";

            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUri));

            // Replace this value with your account key.

            var accountKey = APIKeys.BingKey;

            // Configure bingContainer to use your credentials.

            bingContainer.Credentials = new NetworkCredential(accountKey, accountKey);

            // Build the query.

            var autoCompleteQuery = bingContainer.SpellingSuggestions(query, null, null, null, null, null);

            var completeResults = autoCompleteQuery.Execute();

            return completeResults.Select(m => m.Value);
        }
    }
}