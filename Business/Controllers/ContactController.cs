using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Main.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactAjax()
        {
            return PartialView(new Models.Contact());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ContactAjax(Models.Contact task)
        {
            if (ModelState.IsValid)
            {
                var data1 = task.Name + ", " + task.Email;

                var bRet = task.SendEmail();
                TempData["Status"] = "emailSent";// itime request session object

                return PartialView("ContactAjax", task);
                //return RedirectToAction("ContactAjax", task);// the page will be opened with get
            }
            else
            {
                TempData["Status"] = "Message err from controller";
                return PartialView("ContactAjax", task);
                //return PartialView("contactResult", task);
            }
        }

    }
}