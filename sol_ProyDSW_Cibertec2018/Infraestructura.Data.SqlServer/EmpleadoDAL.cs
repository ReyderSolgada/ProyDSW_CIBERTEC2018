using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Dominio.Core.Entidades;
using System.Data.SqlClient;


namespace Infraestructura.Data.SqlServer
{
    public class EmpleadoDAL:Variable
    {


        public List<Empleado> Listado_Todo_Emleado()
        {
            List<Empleado> lista = new List<Empleado>();

            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_EMPLEADOS");

            while (lector.Read())
            {
                Empleado e = new Empleado();

                e.codemp = lector.GetString(0);
                e.nomemp = lector.GetString(1);
                e.coddis = lector.GetString(2);
                e.direccion = lector.GetString(3);
                e.dni = lector.GetString(4);
                e.correo = lector.GetString(5);
                e.turno = lector.GetString(6);
                e.celular = lector.GetString(7);
                e.fecha_ing= lector.GetDateTime(8);
                e.codcargo = lector.GetString(9);
                e.eliminado = lector.GetString(10);
                e.contra = lector.GetString(11);
                if(e.eliminado.Equals("NO"))
                    lista.Add(e);
            }

            lector.Close();

            return lista;
        }

        public string EliminaEmpleado(Empleado emp)
        {
            string mensaje = "";
            int cuenta = SqlHelper.ExecuteNonQuery(CAD_CN, "USP_ELIMINAR_EMPLEADOS_LOGIC", emp.codemp);
            if (cuenta == 1)
                mensaje = "Empleado " + emp.nomemp + " Eliminado Correctamente";
            return mensaje;
        }


        public string InsertaEmpleado(Empleado emp)
        {
            string mensaje = "";
            int cuenta = SqlHelper.ExecuteNonQuery(CAD_CN, "USP_INSERTAR_EMPLEADOS", emp.codemp, emp.nomemp,
                                                 emp.coddis, emp.direccion, emp.dni,emp.correo, emp.turno, emp.celular, emp.fecha_ing, emp.codcargo);

            if (cuenta == 1)
                mensaje = "Empleado " + emp.nomemp + " Insertado Correctamente";
            return mensaje;
        }

        public string ActualizaEmpleado(Empleado emp)
        {
            string mensaje = "";
            int cuenta = SqlHelper.ExecuteNonQuery(CAD_CN, "USP_ACTUALIZAR_EMPLEADOS", emp.codemp, emp.nomemp,
                                                 emp.coddis, emp.direccion, emp.dni, emp.correo, emp.turno, emp.celular, emp.fecha_ing, emp.codcargo,emp.contra);
            if (cuenta == 1)
                mensaje = " Empleado  " + emp.nomemp + " Actualizado Correctamente";

            return mensaje;
        }

    }
}
