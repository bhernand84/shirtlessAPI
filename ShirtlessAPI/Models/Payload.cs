using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ShirtlessAPI.Models
{
    public class Payload
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("response_url")]
        public string ResponseUrl { get; set; }

        public Payload() { }

        public Payload(string text, string responseUrl)
        {
            Text = text;
            ResponseUrl = responseUrl;
        }
    }
}