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
    
    public partial class AlquilerDetalle
    {
        public int Id { get; set; }
        public int habitacion { get; set; }
        public string precioCategoria { get; set; }
        public string precioTipoHabitacion { get; set; }
        public Nullable<int> alquiler_id { get; set; }
    
        public virtual Alquiler Alquiler { get; set; }
        public virtual Habitacion Habitacion1 { get; set; }
    }
}
