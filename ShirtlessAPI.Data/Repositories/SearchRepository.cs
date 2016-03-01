using ShirtlessAPI.Data.DAL;
using ShirtlessAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
