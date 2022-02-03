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
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int? Telefono { get; set; }
        [Required]
        public string Descripcion { get; set; }

        
    }
}
//Comentario