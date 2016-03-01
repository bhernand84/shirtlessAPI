using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShirtlessAPI.Models
{
    public class SearchResult
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string MediaUrl { get; set; }
        public string SourceUrl { get; set; }
        public string DisplayUrl { get; set; }
        public int Width{ get; set; }
        public int Height { get; set; }
        public int FileSize { get; set; }
        public Thumbnail ThumbnailImage { get; set; }

        public SearchResult() { }

        public SearchResult(Guid id, string title, string mediaUrl, string sourceUrl, string displayUrl, int width, int height, int filesize, Thumbnail thumbnail)
        {
            ID = id;
            Title = title;
            MediaUrl = mediaUrl;
            SourceUrl = sourceUrl;
            DisplayUrl = displayUrl;
            Width = width;
            Height = height;
            FileSize = filesize;
            ThumbnailImage = thumbnail;
        }
    }

    public class Thumbnail
    {
        public string MediaUrl { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int FileSize { get; set; }

        public Thumbnail() { }
        public Thumbnail(string mediaurl, int width, int height, int fileSize)
        {
            MediaUrl = mediaurl;
            Width = width;
            Height = height;
            FileSize = fileSize;
        }
    }
}