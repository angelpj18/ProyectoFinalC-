//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Reserva_Alquiler_Habi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alquiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alquiler()
        {
            this.AlquilerDetalle = new HashSet<AlquilerDetalle>();
        }
    
        public int Id { get; set; }
        public System.DateTime FechaAlquilerDesde { get; set; }
        public System.DateTime FechaAlquilerHasta { get; set; }
        public string TipoAlquiler { get; set; }
        public int reserva_id { get; set; }
    
        public virtual Reserva Reserva { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlquilerDetalle> AlquilerDetalle { get; set; }
    }
}
