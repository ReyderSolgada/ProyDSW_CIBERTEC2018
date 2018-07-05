using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
   public class DistritoDAL:Variable
    {
        public List<Distrito> ListarDistrito()
        {
            List<Distrito> lista = new List<Distrito>();
            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_DISTRITOS");
            while (lector.Read())
            {
                Distrito obj = new Distrito();
                obj.coddis = lector.GetString(0);
                obj.nomdis = lector.GetString(1);
               lista.Add(obj);
            }
            lector.Close();
            return lista;
        }

    }
}
