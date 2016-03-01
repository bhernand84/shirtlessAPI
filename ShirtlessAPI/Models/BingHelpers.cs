using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public static class BingHelpers
    {
        public static SearchResult ToSearchResult(this Bing.ImageResult imageResult)
        {
            Thumbnail thumbnail = null;
            if (imageResult.Thumbnail != null)
            {
                thumbnail = new Thumbnail(imageResult.Thumbnail.MediaUrl, imageResult.Thumbnail.Width.ConvertToInt(), imageResult.Thumbnail.Height.ConvertToInt(), imageResult.Thumbnail.FileSize.ConvertToInt());
            }

            return new SearchResult(imageResult.ID, imageResult.Title, imageResult.MediaUrl, imageResult.SourceUrl, imageResult.DisplayUrl, imageResult.Width.ConvertToInt(), imageResult.Height.ConvertToInt(), imageResult.FileSize.ConvertToInt(), thumbnail);

        }

        public static int ConvertToInt(this int? val)
        {
            if (val.HasValue)
            {
                return val.Value;
            }
            return 0;
        }

        public static int ConvertToInt(this long? val)
        {
            if (val.HasValue)
            {
                return (int)val.Value;
            }
            return 0;
        }
    }
}