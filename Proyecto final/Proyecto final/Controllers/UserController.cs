using Proyecto_final.Models;
using Proyecto_final.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using static Proyecto_final.Models.ViewModels.AddUserViewModels;
using Proyecto_final.Models.TableViewModel;

namespace Proyecto_final.Controllers
{
    public class UserController: Controller
    {
        // ----------------------------------------------------------------------
        // Abre la pagina de usuario
        // ----------------------------------------------------------------------
        [HttpGet]
        public ActionResult registrar()
        {
            return View();
        }
        // ----------------------------------------------------------------------
        // Agrega un usuario
        // ----------------------------------------------------------------------
        [HttpPost]
        public ActionResult registrar(AddUserViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new ahorros_prestamosEntities())
            {
                clientes oUser = new clientes();
                
                oUser.num_cedula = model.cedula;
                oUser.nombres = model.nombres;
                oUser.apellidos = model.apellidos;
                oUser.direccion = model.direccion;
                oUser.telefono = model.telefono;
                oUser.tipo_cliente = model.tipo_cliente;

                db.clientes.Add(oUser);
                db.SaveChanges();
            }

            /*Aqui debemos de poner el nombre de la vista que va despues del registro*/
            return Redirect(Url.Content("~/User/"));
        }
    }
}