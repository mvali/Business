using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SearchVM // ViewModel
    {
        public Models.SearchCriteria param{ get; set; }
        public IEnumerable<SearchResults> results { get; set; }
    }
}
