﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Entidades
{
    public class Productos
    {

        public string codpro { get; set; }
        public string nompro{ get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public string codtipo { get; set; }
        public string eliminado { get; set; }
    }
}
