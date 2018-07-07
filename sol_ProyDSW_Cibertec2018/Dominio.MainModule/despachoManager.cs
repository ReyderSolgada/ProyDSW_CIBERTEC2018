using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Dominio.Core.Entidades;
using Infraestructura.Data.SqlServer;

namespace Dominio.MainModule
{
    public class despachoManager
    {
        despachoDAL objA = new despachoDAL();

        public List<despacho> ListarDespacho()
        {
            return objA.ListarDespacho();
        }
        public despacho BuscarDespacho(string xcod)
        {
            return objA.BuscarDespacho(xcod);
        }
        public string ActualizarDespacho(despacho obj)
        {
            return objA.ActualizarDespacho(obj);
        }
        public string InsertarDespacho(despacho obj)
        {
            return objA.InsertarDespacho(obj);
        }
        public string EliminarDespacho(despacho obj)
        {
            return objA.EliminarDespacho(obj);
        }

    }
}
