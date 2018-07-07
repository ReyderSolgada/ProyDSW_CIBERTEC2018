using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Dominio.Core.Entidades
{
    public class detalledespacho
    {
        [DisplayName("Numero de despacho")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero de despacho Obligatorio")]
        public string nrodespacho { get; set; }

        [DisplayName("Numero de boleta")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero de boleta Obligatorio")]
        public string nroboleta { get; set; }

        [DisplayName("Numero de cajas")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero de cajas Obligatorio")]
        public int nrocajas { get; set; }
    }
}
