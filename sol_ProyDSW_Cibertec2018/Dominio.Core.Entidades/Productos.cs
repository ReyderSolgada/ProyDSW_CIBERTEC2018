using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
    public class Productos
    {

        [DisplayName("Código de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Código Obligatorio")]
        public int codpro { get; set; }
        [DisplayName("Nombre de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre Obligatorio")]
        public String  nompro { get; set; }
        [DisplayName("Stock de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Stock Obligatorio")]
        public int stock { get; set; }
        [DisplayName("Precio de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Precio Obligatorio")]
        public double precio { get; set; }
        [DisplayName("Tipo de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tipo de producto obligatorio")]
        public int codtipo { get; set; }
        [DisplayName("estado")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Estado Obligatorio")]
        public int eliminado { get; set; }

    }
}
