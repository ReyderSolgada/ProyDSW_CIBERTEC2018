using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyDSW_Cibertec2018.Models
{
    public class producto_carrito
    {

        public String prod_cod { get; set; }

        public String prod_nom { get; set; }
        
        public double prod_precio { get; set; }
        public int cant { get; set; }

        public double importe
        {
            get { return cant * prod_precio; }
        }
    }
}