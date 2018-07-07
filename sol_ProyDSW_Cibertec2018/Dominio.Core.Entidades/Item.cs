using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Entidades
{
    public class Item
    {


        public string codpro { get; set; }
        public string nompro { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public string codtipo { get; set; }
        public string eliminado { get; set; }

        public decimal importe
        {
            get { return cantidad * precio; }
        }


    }
}
