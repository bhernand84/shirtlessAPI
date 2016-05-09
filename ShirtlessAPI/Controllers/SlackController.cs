using ShirtlessAPI.Helpers;
using ShirtlessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Ajax.Utilities;

namespace ShirtlessAPI.Controllers
{
    [EnableCors(origins: "http://shirtless.azurewebsites.net/api/slack", headers: "*", methods: "*")]
    public class SlackController : ApiController
    {
        protected SearchProvider _searchProvider { get; set; }
        protected LogProvider _logProvider { get; set; }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public SlackSearchResult Post(string text)
        {
            _logProvider.Log(text);
            List<SearchResult> images = _searchProvider.Post(text).ToList();

            Random random = new Random();
            int randomNumber = random.Next(0, images.Count());

            SearchResult image = images[randomNumber];
            List<SlackAttachment> attachments = new List<SlackAttachment>();
            SlackAttachment attachment = new SlackAttachment(image.Title, image.MediaUrl);
            attachments.Add(attachment);
            SlackSearchResult slackResult = new SlackSearchResult(image.Title, attachments);

            return slackResult;
        }

        [HttpGet]
        public IEnumerable<SearchResult> Get(string text)
        {
            return _searchProvider.Get(text);
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