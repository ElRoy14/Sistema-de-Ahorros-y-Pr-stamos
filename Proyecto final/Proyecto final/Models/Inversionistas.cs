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
    
    public partial class Inversionistas
    {
        public int ID_Inversionista { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> Monto_Invertido { get; set; }
        public Nullable<int> Tasa_Interes { get; set; }
    
        public virtual clientes clientes { get; set; }
    }
}
