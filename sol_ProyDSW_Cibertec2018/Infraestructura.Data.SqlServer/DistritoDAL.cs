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
        public List<Distrito> Listado_Todo_Distrito()
        {
            List<Distrito> lista = new List<Distrito>();

            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_DISTRITOS");

            while (lector.Read())
            {
                Distrito d = new Distrito();

                d.coddis = lector.GetString(0);
                d.nomdis = lector.GetString(1);

                lista.Add(d);
            }

            lector.Close();

            return lista;
        }


    }
}
