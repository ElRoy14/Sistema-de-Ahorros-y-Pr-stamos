using Proyecto_final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_final.Controllers
{
    public class AccederController: Controller
    {

        // GET: Acceder
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Enter(string usuario, string password, string tipoUsuario)
        {
            try
            {
                using (ahorros_prestamosEntities db = new ahorros_prestamosEntities())
                {
                    var read = from d in db.clientes
                               where d.nombre_usuario == usuario
                                  && d.contraseña == password
                                  && d.tipo_usuario == tipoUsuario
                               select d;
                    if (read.Count() > 0)
                    {
                        Session["Usuario"] = read.First();
                        return Content("1");
                    }
                    else
                    {
                        return Content("Revisa usuario y password...");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :(" + ex.Message);
            }
        }

    }
}