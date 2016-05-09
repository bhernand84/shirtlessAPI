using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class SlackSearchResult
    {
        public string Text { get; set; }
        public string MediaUrl { get; set; }
        public string ThumbUrl { get; set; }

        public SlackSearchResult() {}

        public SlackSearchResult(string text, string mediaUrl, string thumbUrl)
        {
            Text = text;
            MediaUrl = mediaUrl;
            ThumbUrl = thumbUrl;
        }
    }
}