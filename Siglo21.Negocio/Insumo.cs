using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siglo21.DALC;


namespace Siglo21.Negocio
{
    public class Insumo
    {
        public decimal Id_Insumo { get; set; }

        [Display(Name = "Nombre_Insumo")]
        public string Nombre_Insumo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio_Unitario { get; set; }

        public decimal Stock { get; set; }


    }
}
