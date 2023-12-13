using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_final.Models.TableViewModel
{
    public class UserTableViewModel
    {
        public int id_cliente
        {
            get; set;
        }

        public int nombre_usuario
        {
            get; set;
        }

        public int contraseña
        {
            get; set;
        }
        public int tipo_usuario
        {
            get; set;
        }
        public int num_cedula
        {
            get; set;
        }
        public int nombres
        {
            get; set;
        }

        public int apellidos
        {
            get; set;
        }

        public int direccion
        {
            get; set;
        }

        public int telefono
        {
            get; set;
        }

        public int tipo_cliente
        {
            get; set;
        }
    }
}