using Proyecto_final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_final.Models.ViewModels;
using Calendario.Models.ViewModels;

namespace Proyecto_final.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult registrar()
        {
            return View();
        }

        public ActionResult casos()
        {
            return View();
        }

        public ActionResult RegistroPrestamo()
        {
            return View();
        }

        public ActionResult Inversionista()
        {
            return View();
        }

        /* public ActionResult About()
         {
             ViewBag.Message = "Your application description page.";

             return View();
         }

         public ActionResult Contact()
         {
             ViewBag.Message = "Your contact page.";

             return View();
         }*/
    }
}