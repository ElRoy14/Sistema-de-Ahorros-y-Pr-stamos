using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_final.Controllers
{
    public class CerrarSession: Controller
    {
        // GET: CerrarSession
        public ActionResult Logoff()
        {
            Session["Usuario"] = null;
            return RedirectToAction("login", "Home");
        }

    }
}