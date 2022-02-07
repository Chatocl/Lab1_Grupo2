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
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int? Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Teléfono es requerido.")]
        public int? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Descripción es requerido.")]
        public string Descripcion { get; set; }

        
    }
}
//Comentario