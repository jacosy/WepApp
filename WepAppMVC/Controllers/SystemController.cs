using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.Common.Models;
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
            ViewBag.Roles = new List<SelectListItem>
            {
                new SelectListItem { Text="Admin", Value="1" },
                new SelectListItem { Text="User", Value="2" },
                new SelectListItem { Text="Anonymous", Value="0" }
            };
            return View(new AccountUserVM("") { AccountStatus = "", });
        }


        public ActionResult GetData(int id = -1)
        {
            var data = new AjaxData<IEnumerable<AccountUserVM>>
            {
                isSucceeded = true,
                data = new List<AccountUserVM>
                {
                //    //draw = 0,
                //    recordsTotal = 2,
                //    recordsFiltered = 2,
                //    data = new List<AccountUserVM>
                //        {
                            new AccountUserVM("LongoriaYu")
                            {
                                UserName ="Longoria.You",
                                Email = "longoria.you@gmail.com",
                                Role="Admin",
                                AccountStatus ="Enable",
                                ValidStartTime = "2019-01-01",
                                ValidEndTime = "2019-12-31",
                                LastLoginIP = "127.0.0.1",
                                LastLoginTime = "2019-03-24"
                            },
                            new AccountUserVM("MarkLin")
                            {
                                UserName ="Mark  Lin",
                                Email = "tadas.you@gmail.com",
                                Role="User",
                                AccountStatus ="Postpone",
                                ValidStartTime = "2019-01-01",
                                ValidEndTime = "2019-12-31",
                            }
                //        }
                }
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}