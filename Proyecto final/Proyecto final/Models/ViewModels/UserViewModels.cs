using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Proyecto_final.Models.ViewModels
{
        public class AddUserViewModels
        {
            [Required]
            [Display(Name = "Cedula")]
            [StringLength(100, ErrorMessage = "El {0} debe tener al menos {1} caracter", MinimumLength = 1)]
            public string cedula { get; set; }

            [Required]
            [Display(Name = "Nombres")]
            public string nombres { get; set; }

            [Required]
            [Display(Name = "Apellidos")]
            public string apellidos { get; set; }

            [Required]
            [Display(Name = "Direccion")]
            public string direccion { get; set; }

            [Required]
            [Display(Name = "Telefono")]
            public string telefono { get; set; }

            [Required]
            [Display(Name = "Tipo de cliente")]
            public string tipo_cliente { get; set; }

        [Required]
        [Display(Name = "Nombre de usuario")]
        public string nombre_usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "contraseña")]
        public string contraseña { get; set; }

    }
    
}