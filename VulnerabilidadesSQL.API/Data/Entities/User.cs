using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VulnerabilidadesSQL.API.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(64, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        public string Email { get; set; }

        [MaxLength(128, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        public string Name { get; set; }

        [MaxLength(16, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        public string Password { get; set; }

        [MaxLength(24, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        public string AccountId { get; set; }
    }
}
