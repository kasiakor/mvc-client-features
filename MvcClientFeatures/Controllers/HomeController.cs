using MvcClientFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClientFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult MakeBooking()
        {
            return View(new Appointment
            { ClientName = "Adam",
            TermsAccepted = true    
           });
        }

        [HttpPost]
        public JsonResult MakeBooking(Appointment appo)
        {
            return Json(appo, JsonRequestBehavior.AllowGet);
        }
    }
}