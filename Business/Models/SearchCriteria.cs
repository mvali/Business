using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SearchCriteria
    {
        public string Name { get; set; }
        public SearchCriteria(){ }

        public SearchCriteria(string name)
        {
            Name = name;
        }
    }
}
