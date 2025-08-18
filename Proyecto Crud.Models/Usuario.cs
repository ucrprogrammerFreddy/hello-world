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

        public string otroUsuario2 { get; set; }

        public string perfilesFreddy { get; set; }


        public String Titulacion { get; set; }

        public String FechaRegistro { get; set; }

        public string FechaUltimoAcceso { get; set; }

        public string rol { get; set; }

        public string? email { get; set; }




    }
}
