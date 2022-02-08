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

        public void OrdenarPorNombre(List<Clientes> ListCliente)
        {
            int i, j, min;
            int Aux;
            Clientes temp;

            for (i = 0; i < ListCliente.Count() - 1; i++)
            {
                min = i;
                for (j = i+1; j < ListCliente.Count(); j++)
                {
                    Aux = ListCliente[j].Nombre.CompareTo(ListCliente[min].Nombre);
                    if (Aux == -1)
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    temp = ListCliente[i];
                    ListCliente[i] = ListCliente[min];
                    ListCliente[min] = temp;
                }
            }
        }
        public void OrdenarPorApellido(List<Clientes> ListCliente)
        {
            int i, j, min;
            int Aux;
            Clientes temp;

            for (i = 0; i < ListCliente.Count() - 1; i++)
            {
                min = i;
                for (j = i + 1; j < ListCliente.Count(); j++)
                {
                    Aux = ListCliente[j].Apellido.CompareTo(ListCliente[min].Apellido);
                    if (Aux == -1)
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    temp = ListCliente[i];
                    ListCliente[i] = ListCliente[min];
                    ListCliente[min] = temp;
                }
            }
        }

    }
}
//Comentario