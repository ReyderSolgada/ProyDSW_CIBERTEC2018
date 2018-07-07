using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class CargoDAL:Variable
    {
        public List<Cargo> Listado_Todo_Cargo()
        {
            List<Cargo> lista = new List<Cargo>();

            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_CARGOS");

            while (lector.Read())
            {
                Cargo c = new Cargo();

                c.codcargo = lector.GetString(0);
                c.nomcargo = lector.GetString(1);

                lista.Add(c);
            }

            lector.Close();

            return lista;
        }

    }
}
