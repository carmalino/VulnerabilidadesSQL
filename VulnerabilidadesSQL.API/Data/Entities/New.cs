using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VulnerabilidadesSQL.API.Data.Entities
{
    public class New
    {
        public int Id { get; set; }

        [Display(Name ="Titulo")]
        [MaxLength(50,ErrorMessage ="El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage ="El titulo es obligatorio")]
        public string Title { get; set; }

        [Display(Name = "Mensaje")]
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        public string Body { get; set; }

        [Display(Name = "Fecha Creación")]
        public DateTime DateTime { get; set; }
    }
}
