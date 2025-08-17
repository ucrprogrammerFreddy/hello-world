using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoCrud.Model
{

    public class Usuario
    {
        public int IdUsuario { get; set; }

        public String? Nombre { get; set; }

        public String fechaNacimiento { get; set; }

        public String Email { get; set; }


    }
}
