using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Core.Entidades;
using Infraestructura.Data.SqlServer;

namespace Dominio.MainModule
{
    public class ProductoManager
    {

        ProductosDAL objC = new ProductosDAL();
        public List<Productos> ListarProductos()
        {
            return objC.ListarProducto();
        }
        public Productos BuscarProducto(string xnom)
        {
            return objC.BuscarProducto(xnom);
        }
        public string ActualizarProducto(Productos obj)
        {
            return objC.ActualizarProducto(obj);
        }
        public string InsertarProducto(Productos obj)
        {
            return objC.InsertarProducto(obj);
        }
        public string EliminarProducto(Productos obj)
        {
            return objC.EliminarProducto(obj);
        }

    }
}
