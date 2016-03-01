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
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IEnumerable<SearchResult> Get(string query)
        {
            // Create a Bing container.

            string rootUri = "https://api.datamarket.azure.com/Bing/Search";

            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUri));

            // Replace this value with your account key.

            var accountKey = APIKeys.BingKey;

            // Configure bingContainer to use your credentials.

            bingContainer.Credentials = new NetworkCredential(accountKey, accountKey);

            // Build the query.

            var imageQuery = bingContainer.Image(query + " shirtless", null, null, null, null, null, null);

            var imageResults = imageQuery.Execute();

            return imageResults.Select(m => m.ToSearchResult());    
            
        }
    }
}