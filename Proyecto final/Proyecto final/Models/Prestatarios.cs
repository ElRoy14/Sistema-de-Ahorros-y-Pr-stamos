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
    
    public partial class Prestatarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestatarios()
        {
            this.Fiadores = new HashSet<Fiadores>();
        }
    
        public int ID_Prestatario { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> Monto_Prestado { get; set; }
        public Nullable<int> Tasa_Interes { get; set; }
        public string Fecha_Solicitud { get; set; }
        public string Fecha_Aprobacion { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Termino { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fiadores> Fiadores { get; set; }
        public virtual clientes clientes { get; set; }
    }
}
