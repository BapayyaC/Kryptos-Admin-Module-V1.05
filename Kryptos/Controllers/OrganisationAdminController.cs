using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kryptos.Controllers
{
    public class OrganisationAdminController : Controller
    {
        //
        // GET: /OrganisationAdmin/

        public ActionResult NewUser()
        {
            ViewData["current view"] = "Organization List";
            if (LoginController.ActiveUser != null)
            {
                ViewData["CURRENTUSER"] = LoginController.ActiveUser;
            }
            else
            {
                TempData["errormsg"] = "Please Login and Proceed!";
                return RedirectToAction("Login", "Login");
            }

            return View();
        }

       

    }
}
