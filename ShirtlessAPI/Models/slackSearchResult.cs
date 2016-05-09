using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class SlackSearchResult
    {
        public string text { get; set; }
        public string image_url { get; set; }
        public string thumb_url { get; set; }

        public SlackSearchResult() {}

        public SlackSearchResult(string Text, string MediaUrl, string ThumbUrl)
        {
            text = Text;
            image_url = MediaUrl;
            thumb_url = ThumbUrl;
        }
    }
}