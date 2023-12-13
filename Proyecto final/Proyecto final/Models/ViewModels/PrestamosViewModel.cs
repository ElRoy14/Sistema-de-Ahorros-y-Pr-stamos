using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;


namespace Calendario.Models.ViewModels
{

    public class AddPrestamosViewModels
    {

        [Required]
        [Display(Name = "codigo_prestamo")]
        public int codigo_prestamo { get; set; }


        [Required]
        [Display(Name = "monto_prestamo")]
        public int monto_prestamo { get; set; }

        [Required]
        [Display(Name = "tasa_interes ")]
        public int tasa_interes { get; set; }




    }

}