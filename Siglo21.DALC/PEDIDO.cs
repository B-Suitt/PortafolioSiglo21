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
    
    public partial class PEDIDO
    {
        public PEDIDO()
        {
            this.DETALLE_PEDIDO = new HashSet<DETALLE_PEDIDO>();
            this.PLATO = new HashSet<PLATO>();
        }
    
        public decimal NRO_PEDIDO { get; set; }
        public System.DateTime FECHA_PEDIDO { get; set; }
        public string ESTADO_PEDIDO { get; set; }
        public decimal NRO_MESA { get; set; }
        public decimal ID_USUARIO { get; set; }
    
        public virtual ICollection<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }
        public virtual MESA MESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PLATO> PLATO { get; set; }
    }
}