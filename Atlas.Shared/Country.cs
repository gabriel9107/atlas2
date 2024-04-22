using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Shared
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name="Pais")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
