using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;


namespace ProyectoCrud.Model
{

    public class Usuario
    {

        public int IdUsuario { get; set; }

        public String? Nombre { get; set; }

        public String fechaNacimiento { get; set; }

        public String OtroUsuario { get; set; }

    }
}
