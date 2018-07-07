using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyDSW_Cibertec2018.Models
{
    public class usp_listar_productos
    {
        public string codpro { get; set; }
        public string nompro { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public string codtipo { get; set; }
        public string eliminado { get; set; }


    }
}