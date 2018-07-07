using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Infraestructura.Data.SqlServer;
using Dominio.Core.Entidades;

namespace Dominio.MainModule
{
    public class ProductoManager
    {
        ProductoDALS objP = new ProductoDALS();

        public List<Productos> Listado_Todo_Productos()
        {
            return objP.Listado_Todo_Productos();
        }
    }
}
