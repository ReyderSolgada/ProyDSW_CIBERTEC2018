using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Infraestructura.Data.SqlServer;
using Dominio.Core.Entidades;

namespace Dominio.MainModule
{
     public class EmpleadoManager
    {

        EmpleadoDAL objL = new EmpleadoDAL();
        public List<Empleado> Listado_Todo_Emleado()
        {
            return objL.Listado_Todo_Emleado();
        }

        public string EliminaEmpleado(Empleado emp)
        {
            return objL.EliminaEmpleado(emp);
        }

        public string InsertaEmpleado(Empleado emp)
        {
            return objL.InsertaEmpleado(emp);
        }

        public string ActualizaEmpleado(Empleado emp)
        {
            return objL.ActualizaEmpleado(emp);
        }

    }
}
