using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
    public class Detalle_Boleta
    {
        // NROBOL,CODPRO,CANTIDAD,PRECIO
        [DisplayName("Número de Boleta")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Número de Boleta")]
        public string NROBOL { get; set; }

        [DisplayName("Código de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Código de Producto")]
        public string CODPRO { get; set; }

        [DisplayName("Cantidad a adquirir")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cantidad a adquirir")]
        public int CANTIDAD { get; set; }

        [DisplayName("Precio del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Precio del Producto")]
        public double PRECIO { get; set; }
    }
}
