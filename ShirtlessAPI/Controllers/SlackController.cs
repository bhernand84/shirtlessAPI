using ShirtlessAPI.Helpers;
using ShirtlessAPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

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
        public void Get(string text, string response_url)
        {
            _logProvider.Log(text);

            Payload payload = new Payload(text, response_url);
            Get(payload);
        }

        public string Get(Payload payload)
        {
            List<SearchResult> images = _searchProvider.Get(payload.Text).ToList();
            int randomNumber = ControllerHelpers.GetRandomNumber(images.Count);
            SearchResult image = images[randomNumber];

            SlackSearchResult slackResult = new SlackSearchResult(ControllerHelpers.CreateSlackAttachments(payload.Text, image.MediaUrl));

            var request = (HttpWebRequest)WebRequest.Create(payload.ResponseUrl);
            request.ContentType = "application/json";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(slackResult);

                streamWriter.Write(json);
            }

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
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