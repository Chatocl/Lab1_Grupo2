using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Grupo2.Models
{
    // Class Cliente Almacena Nombre, Apellido, Telefono, Descripcion
    public class Clientes
    {
        [Required]
        public int? Id {get;set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Telefono { get; set; }
        public string Descripcion { get; set; }

        
    }
}
//Comentario