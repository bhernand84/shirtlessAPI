using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.Ajax.Utilities;
using ShirtlessAPI.Models;

namespace ShirtlessAPI.Helpers
{
    public class ControllerHelpers
    {
        public static int GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, maxNumber);
            return randomNumber;
        }

        public static IEnumerable<SlackAttachment> CreateSlackAttachments(string title, string mediaUrl)
        {
            List<SlackAttachment> attachments = new List<SlackAttachment>();
            SlackAttachment attachment = new SlackAttachment(title, mediaUrl);
            attachments.Add(attachment);

            return attachments;
        }

        public static HttpWebRequest CreateSlackResponseRequest(string responseUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(responseUrl);
            request.ContentType = "application/json";
            request.Method = "POST";

            return request;
        }

        public static string CreateResponseString(HttpWebRequest request)
        {
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}