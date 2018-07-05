using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entidades;
using Infraestructura.Data.SqlServer;

namespace Dominio.MainModule
{
    public class DistritoManager
    {
        DistritoDAL objD = new DistritoDAL();
        public List<Distrito> ListarDistrito()
        {
            return objD.ListarDistrito();
        }

    }
}
