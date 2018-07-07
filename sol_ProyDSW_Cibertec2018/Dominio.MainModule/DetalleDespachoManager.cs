using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Dominio.Core.Entidades;
using Infraestructura.Data.SqlServer;
using System.Data.SqlClient;

namespace Dominio.MainModule
{
    class DetalleDespachoManager
    {
        DetalleDespachoDAL objA = new DetalleDespachoDAL();
        public List<DetalleDespacho> ListarDetalleDespacho()
        {
            return objA.ListarDetalleDespacho();
        }

        public DetalleDespacho BuscarDetalleDespacho(string xcod)
        {
            return objA.BuscarDetalleDespacho(xcod);

        }

        public string ActualizarDetalleDespacho(DetalleDespacho obj)
        {
            return objA.ActualizarDetalleDespacho(obj);

        }
        public string InsertarDetalleDespacho(DetalleDespacho obj)
        {
            return objA.InsertarDetalleDespacho(obj);
        }
        public string EliminarDetalleDespacho(DetalleDespacho obj)
        {
            return objA.EliminarDetalleDespacho(obj);
        }

    }
}
