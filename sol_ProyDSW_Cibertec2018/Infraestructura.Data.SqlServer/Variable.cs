using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Importar
using System.Configuration;

namespace Infraestructura.Data.SqlServer
{
    public class Variable
    {   

        public string CAD_CN = ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;

    }
}
