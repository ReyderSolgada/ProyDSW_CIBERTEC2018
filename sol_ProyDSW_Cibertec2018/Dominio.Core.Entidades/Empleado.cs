using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entidades
{
    public class Empleado
    {

        [Display(Name = "Codigo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Codigo Requerido")]
        public string codemp { get; set; }

        [Display(Name = "Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre Requerido")]
        public string nomemp { get; set; }

        [Display(Name = "Distrito")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Distrito Requerido")]
        public string coddis { get; set; }

        [Display(Name = "Direccion")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Direccion Requerido")]
        public string direccion { get; set; }

        [Display(Name = "Dni")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Dni Requerido")]
        public string dni { get; set; }

        [Display(Name = "Correo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Correo Requerido")]
        public string correo { get; set; }

        [Display(Name = "Turno")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Turno Requerido")]
        public string turno { get; set; }

        [Display(Name = "Celular")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Celular Requerido")]
        public string celular { get; set; }

        [Display(Name = "Fecha Ingreso")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fecha Ingreso Requerido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true,NullDisplayText ="")]
        public DateTime fecha_ing { get; set; }

        [Display(Name = "Cargo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cargo Requerido")]
        public string codcargo { get; set; }

        [Display(Name = "Contraseña")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contraseña Requerido")]
        public string contra { get; set; }

        [Display(Name = "Eliminado")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Eliminado Requerido")]
        public string eliminado { get; set; }


    }
}
