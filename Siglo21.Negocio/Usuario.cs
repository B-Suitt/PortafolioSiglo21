using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siglo21.DALC;

namespace Siglo21.Negocio
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Rut { get; set; }

        public int Telefono { get; set; }

        public bool Estado { get; set; }


        public int TipoUsuario { get; set; }

        SigloXXIEntities db = new SigloXXIEntities();

    }


}
