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
    public class SlackController : ApiController
    {
        protected SearchProvider _searchProvider { get; set; }
        protected LogProvider _logProvider { get; set; }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public SlackSearchResult Get(string text)
        {
            _logProvider.Log(text);
            var images = _searchProvider.Get(text);

            SearchResult image = images.FirstOrDefault();
            SlackSearchResult slackResult = new SlackSearchResult(image.Title, image.MediaUrl, image.ThumbnailImage.MediaUrl);

            return slackResult;
        }

        [HttpPost]
        public SearchResult Post(string text)
        {
            return _searchProvider.Post(text);
        }

        #region Constructors

        public SlackController()
        {
            _searchProvider = new SlackSearchProvider();
            _logProvider = new EntityLogProvider();
        }
        #endregion
    }
}