//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PandaHotelWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alquiler
    {
        public int Id { get; set; }
        public System.DateTime FechaAlquilerDesde { get; set; }
        public System.DateTime FechaAlquilerHasta { get; set; }
        public string TipoAlquiler { get; set; }
        public int reserva_id { get; set; }
    }
}
