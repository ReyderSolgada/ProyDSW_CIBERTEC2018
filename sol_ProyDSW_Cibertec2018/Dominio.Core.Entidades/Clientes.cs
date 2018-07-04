using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
   public class Clientes
    {
        [DisplayName("Código Cliente")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Código Obligatorio")]
        public string codcli { get; set; }
        [DisplayName("Nombre Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre Obligatorio")]
        public string nomcli { get; set; }
        [DisplayName("Codigo distrito Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Distrito Obligatorio")]
        public string coddis { get; set; }
        [DisplayName("Dirección Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Dirección Obligatorio")]
        public string direccioncli { get; set; }
        [DisplayName("DNI Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "DNI Obligatorio")]
        public string dnicli { get; set; }
        [DisplayName("Correo Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Correo Obligatorio")]
        public string emailcli { get; set; }
        [DisplayName("Teléfono Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Teléfono Obligatorio")]
        public string celcli { get; set; }
        public string contracli { get; set; }
        public string eliminado { get; set; }
    }
}
