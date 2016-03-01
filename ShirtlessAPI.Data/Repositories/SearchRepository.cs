using ShirtlessAPI.Data.DAL;
using ShirtlessAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShirtlessAPI.Data.Repositories
{
    public class SearchRepository
    {
        private SearchContext db = new SearchContext();

        public IEnumerable<Search> GetSearchListings()
        {
            return db.Searches.ToList();
        }

        public void Add(string query)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            var result = db.Searches.FirstOrDefault(m => m.SearchTerm.ToLower() == query.ToLower());
            if (result == null)
            {
                var search  = new Search() { DateCreated = DateTime.Now, LastModified = DateTime.Now, SearchTerm = textInfo.ToTitleCase(query) };
                db.Searches.Add(search);
                db.SaveChanges();
            }
            else
            {
                result.Count++;
                result.LastModified = DateTime.Now;
                db.SaveChanges();

            }
        }
    }
}
