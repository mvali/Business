using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SearchResults
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public SearchResults() { }
        public SearchResults(string name, string content, string type, int id)
        {
            Name = name;
            Content = content;
            Type = type;
            Id = id;
        }

        public IEnumerable<SearchResults> GetList()
        {
            var items = new List<SearchResults>();
            int i = 1;
            bool bOk = true;

            var resx = Resources.Search.SearchSource.ResourceManager;
            while (bOk)
            {
                try
                {
                    var name = resx.GetString("Name" + i);
                    if (name == null) bOk = false;
                    else
                    {
                        var content = resx.GetString("Content" + i);
                        var type = resx.GetString("Type" + i);

                        items.Add(new SearchResults(name, content, type, i));
                    }
                    i++;
                }
                catch (Exception)
                {
                    bOk = false;
                }
            }
            return items;
        }

    }
}
