using ShirtlessAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtlessAPI.Data.DAL
{
    public class SearchInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SearchContext>
    {
        protected override void Seed(SearchContext context)
        {
            var searches = new List<Search>
            {
            new Search (){SearchTerm="Channing Tatum", Count =2, DateCreated=DateTime.Now.AddDays(-3), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Stephen Amell", Count =5, DateCreated=DateTime.Now.AddDays(-2), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Colton Haynes", Count =3, DateCreated=DateTime.Now.AddDays(-1), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Zayn Malik", Count =3, DateCreated=DateTime.Now.AddDays(-3), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Soccer Players", Count =1, DateCreated=DateTime.Now.AddDays(-2), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Steph Curry", Count =1, DateCreated=DateTime.Now.AddDays(-1), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Tim Tebow", Count =2, DateCreated=DateTime.Now.AddDays(-3), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="The Game", Count =1, DateCreated=DateTime.Now.AddDays(-2), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Chris Helmsworth", Count =2, DateCreated=DateTime.Now.AddDays(-4), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Dave Franco", Count =3, DateCreated=DateTime.Now.AddDays(-1), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="The Rock", Count =4, DateCreated=DateTime.Now.AddDays(-1), LastModified=DateTime.Now.AddDays(-1) },
            new Search (){SearchTerm="Ricky Martin", Count =1, DateCreated=DateTime.Now.AddDays(-1), LastModified=DateTime.Now.AddDays(-1) }
            };

            searches.ForEach(s => context.Searches.Add(s));
            context.SaveChanges();
        }
    }
}
