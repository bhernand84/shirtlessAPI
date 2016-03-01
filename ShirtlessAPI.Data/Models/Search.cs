using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtlessAPI.Data.Models
{
    public class Search
    {
        public int ID { get; set; }
        public string SearchTerm { get; set; }
        public int Count { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
