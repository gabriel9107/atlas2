using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Shared
{
    public class Cliente
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(20)]
        public string Cedula_RNC { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(100)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(100)]
        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]

        public bool Credito { get; set; }


    }
}
