//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fiadores
    {
        public int ID_Fiador { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> ID_Prestatario { get; set; }
    
        public virtual Prestatarios Prestatarios { get; set; }
        public virtual clientes clientes { get; set; }
    }
}