using System.Collections.Generic;
using System.Web.Mvc;
using WepAppMVC.ViewModels;

namespace WepAppMVC.Controllers
{
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Admin()
        {
            ViewBag.Status = new List<SelectListItem>
            {
                new SelectListItem { Text="Enable", Value="1" },
                new SelectListItem { Text="Postpone", Value="2" },
                new SelectListItem { Text="Disable", Value="0" }
            };
            return View(new AccountUserVM() { AccountStatus = "", });
        }
    }
}