using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.Data.SqlServer;
using Dominio.Core.Entidades;

namespace Dominio.MainModule
{
    public class CargoManager
    {
        CargoDAL objC = new CargoDAL();

        public List<Cargo> Listado_Todo_Cargo()
        {
            return objC.Listado_Todo_Cargo();
        }
    }
}
