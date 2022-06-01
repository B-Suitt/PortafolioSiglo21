using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglo21.Negocio
{
    class Pedido
    {
        public int Nro_Pedido { get; set; }

        public DateTime Fecha_Pedido { get; set; }

        public bool Estado_Pedido { get; set; }
    }
}
