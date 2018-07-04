using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Core.Entidades;
using Infraestructura.Data.SqlServer;

namespace Dominio.MainModule
{
   public class ClienteManager
    {
        ClientesDAL objC = new ClientesDAL();
        public List<Clientes> ListarCliente()
        {
            return objC.ListarCliente();
        }
        public Clientes BuscarCliente(string xcod)
        {
            return objC.BuscarCliente(xcod);
        }
        public string ActualizarCliente(Clientes obj)
        {
            return objC.ActualizarCliente(obj);
        }
        public string InsertarCliente(Clientes obj)
        {
            return objC.InsertarCliente(obj);
        }
        public string EliminarCliente(Clientes obj)
        {
            return objC.EliminarCliente(obj);
        }

    }
}
