using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public  class LoginDAL:Variable
    {

        public List<Login>listar_Login()
        {
            List<Login> lista = new List<Login>();

            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "usp_lista_login");

            while(lector.Read())
            {
                Login l = new Login();
                l.Usuario = lector.GetString(0);
                l.Contraseña = lector.GetString(1);

                lista.Add(l);
            }
            lector.Close();

            return lista;
        }
    }
}
