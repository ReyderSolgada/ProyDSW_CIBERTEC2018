using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class ProductoDALS:Variable
    {


        public List<Productos> Listado_Todo_Productos()
        {
            List<Productos> lista = new List<Productos>();

            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_PRODUCTOS");

            while (lector.Read())
            {
                Productos e = new Productos();
                e.codpro = lector.GetString(0);
                e.nompro = lector.GetString(1);
                e.stock = lector.GetInt32(2);
                e.precio = lector.GetDecimal(3);
                e.codtipo = lector.GetString(4);
                e.eliminado = lector.GetString(5);

                if (e.eliminado.Equals("NO"))
                    lista.Add(e);
            }

            lector.Close();

            return lista;
        }


    }
}
