using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Business.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View("SearchTop");
        }
        public ActionResult SearchTop(Models.SearchCriteria ts)
        {
            return PartialView("SearchTop", ts);
        }

        [HttpGet]
        public ActionResult SearchResults()
        {
            var resultsAll = new Models.SearchResults().GetList();
            var items = new Models.SearchVM()
            {
                param = new Models.SearchCriteria(),
                results = resultsAll
            };
            return View("SearchResults", items);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchResults(Models.SearchCriteria ts)
        {
            var resultsAll = new Models.SearchResults().GetList();
            IEnumerable<Models.SearchResults> resultsFiltterd = resultsAll;
            if (ts.Name != null)
            {
                resultsFiltterd = resultsAll.Where(x => x.Name.Contains(ts.Name) || x.Content.Contains(ts.Name))
                    .Select(x => x);

                var resultsFiltterd2 = (from x in resultsAll
                                        where x.Name.Contains(ts.Name) || x.Content.Contains(ts.Name)
                                        select x
                                   );
            }


            var items = new Models.SearchVM()
            {
                param = ts,
                results = resultsFiltterd
            };
            TempData["name"] = ts.Name;
            return View("SearchResults", items);
        }
    }
}