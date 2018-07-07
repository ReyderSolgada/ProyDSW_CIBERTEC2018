using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.SqlClient;
using ProyDSW_Cibertec2018.Models;
using System.Configuration;

namespace ProyDSW_Cibertec2018.Controllers
{
    public class CarritoDAO
    {
        String CAD_CN =
          ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;
        public List<usp_listar_productos> usp_listar_productos(String prod_nom)
        {
            List<usp_listar_productos> lista = new List<usp_listar_productos>();
            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_PRODUCTOS", prod_nom);

            while (lector.Read())
            {
                usp_listar_productos x = new Models.usp_listar_productos();
                x.prod_cod = lector.GetString(0);
                x.prod_nom = lector.GetString(1);
                x.prod_pre = lector.GetDouble(2);
                x.prod_stk = lector.GetInt32(3);
                lista.Add(x);
            }
            lector.Close();

            return lista;
        }


    }
}