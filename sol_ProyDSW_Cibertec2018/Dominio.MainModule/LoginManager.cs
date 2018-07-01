using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infraestructura.Data.SqlServer;
using Dominio.Core.Entidades;

namespace Dominio.MainModule
{
    public class LoginManager
    {

        LoginDAL objL = new LoginDAL();

        public List<Login> listar_Login()
        {
            return objL.listar_Login();
        }

    }
}
