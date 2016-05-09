using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class SlackSearchResult
    {
        public string response_type { get; set; }
        public string text { get; set; }
        public IEnumerable<SlackAttachment> attachments { get; set; }

        public SlackSearchResult() {}

        public SlackSearchResult(string Text, IEnumerable<SlackAttachment> Attachments)
        {
            text = Text;
            attachments = Attachments;
        }
    }

    public class SlackAttachment
    {
        public string title { get; set; }
        public string image_url { get; set; }
        public string thumb_url { get; set; }

        public SlackAttachment() { }

        public SlackAttachment(string Title, string ImageUrl, string ThumbUrl)
        {
            title = Title;
            image_url = ImageUrl;
            thumb_url = ThumbUrl;
        }
    }
}