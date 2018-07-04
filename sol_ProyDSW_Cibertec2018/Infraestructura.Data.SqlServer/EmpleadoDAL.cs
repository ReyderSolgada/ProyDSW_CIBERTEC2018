using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data.SqlServer
{

    using Dominio.Core.Entidades;
    using System.Data.SqlClient;



    public class EmpleadoDAL:Variable
    {
        public List<Empleado>Listado_Todo_Emleado()
        {
            List<Empleado> lista = new List<Empleado>();

            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_EMPLEADOS");

            while(lector.Read())
            {
                Empleado e = new Empleado();

                e.codemp = lector.GetString(0);
                e.nomemp = lector.GetString(1);
                e.coddis = lector.GetString(2);
                e.direccion = lector.GetString(3);
                e.dni = lector.GetString(4);
                e.turno = lector.GetString(5);
                e.celular = lector.GetString(6);
                e.fecha_ing = lector.GetDateTime(7);
                e.codcargo = lector.GetString(8);
                e.eliminado = lector.GetString(9);

                lista.Add(e);
            }

            lector.Close();

            return lista;
        }



        String EliminarTodoEmpleados(Empleado obj)
        {
            int numero = SqlHelper.ExecuteNonQuery(CAD_CN,"");

            return "";
        }







    }
}
