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

        [DisplayName("Fecha de traslado")]
        public DateTime fechatraslado { get; set; }

        [DisplayName("Fecha de entrega")]
        public DateTime fechaentrega { get; set; }

        [DisplayName("Destino")]
        public string destino { get; set; }

        [DisplayName("Transporte")]
        public string transporte { get; set; }

        [DisplayName("Estado")]
        public int estado { get; set; }



    }
}
