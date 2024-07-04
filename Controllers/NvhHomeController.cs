using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvhK22cntt3Lession11_2210900031.Controllers
{
    public class NvhHomeController : Controller
    {
        public ActionResult NvhIndex()
        {
            return View();
        }

        public ActionResult NvhAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NvhContact()
        {
            ViewBag.msv = "2210900031";
            ViewBag.fullname = "nguyễn văn huỳnh";

            return View();
        }
    }
}