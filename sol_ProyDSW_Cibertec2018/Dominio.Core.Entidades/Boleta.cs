using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
    public class Boleta
    {
        // NROBOL,CODCLI,CODEMP,FECHAEMICION,FECHAVENC,ESTADO
        [DisplayName("Número de Boleta")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Número de Boleta")]
        public string NROBOL { get; set; }

        [DisplayName("Código de Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Código de Cliente")]
        public string CODCLI { get; set; }

        [DisplayName("Código de Empleado")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Código de Empleado")]
        public string CODEMP { get; set; }

        [DisplayName("Fecha de Emision")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fecha de Emision")]
        public DateTime FECHAEMICION { get; set; }

        [DisplayName("Fecha de Vencimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fecha de Vencimiento")]
        public DateTime FECHAVENC { get; set; }

        [DisplayName("Estado")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Estado")]
        public int ESTADO { get; set; }
    }
}
