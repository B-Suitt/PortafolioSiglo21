//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Siglo21.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESERVA
    {
        public RESERVA()
        {
            this.MESA = new HashSet<MESA>();
        }
    
        public decimal NRO_RESERVA { get; set; }
        public System.DateTime FECHA_RESERVA { get; set; }
        public System.DateTime HORA_RESERVA { get; set; }
        public decimal ID_USUARIO { get; set; }
    
        public virtual ICollection<MESA> MESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}