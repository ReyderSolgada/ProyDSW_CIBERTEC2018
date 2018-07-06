using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.Data.SqlServer;
using Dominio.Core.Entidades;

namespace Dominio.MainModule
{
    public class DistritoManager
    {
        DistritoDAL objD = new DistritoDAL();

        public List<Distrito> Listado_Todo_Distrito()
        {
            return objD.Listado_Todo_Distrito();
        }

    }
}
