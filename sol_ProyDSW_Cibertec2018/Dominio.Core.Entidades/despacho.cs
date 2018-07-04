using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
    class despacho
    {
        [DisplayName("Código de Despacho")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero de despacho Obligatorio")]
        public string nrodespacho { get; set; }

        public DateTime fechatraslado { get; set; }

        public DateTime fechaentrega { get; set; }
        public string destino { get; set; }
        public string transporte { get; set; }
        public int estado { get; set; }



    }
}
