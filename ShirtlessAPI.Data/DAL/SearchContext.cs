using ShirtlessAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtlessAPI.Data.DAL
{
    public class SearchContext : DbContext
    {
        public SearchContext() : base("SearchContext")
        {

        }

        public DbSet<Search> Searches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
