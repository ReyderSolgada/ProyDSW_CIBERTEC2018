using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
   public class Distrito
    {
        [DisplayName("Código Distrito")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Código Obligatorio")]
        public string coddis { get; set; }
        [DisplayName("Nombre Distrito")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre Obligatorio")]
        public string nomdis { get; set; }
    }
}
