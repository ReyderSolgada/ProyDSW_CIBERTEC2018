using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
   public class ClientesDAL:Variable
    {
        public List<Clientes> ListarCliente()
        {
            List<Clientes> lista = new List<Clientes>();
            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_CLIENTES");
            while (lector.Read())
            {
                Clientes obj = new Clientes();
                obj.codcli = lector.GetString(0);
                obj.nomcli = lector.GetString(1);
                obj.coddis = lector.GetString(2);
                obj.direccioncli = lector.GetString(3);
                obj.dnicli = lector.GetString(4);
                obj.emailcli = lector.GetString(5);
                obj.celcli = lector.GetString(6);
                obj.eliminado = lector.GetString(7);
                if(obj.eliminado.Equals("NO"))
                lista.Add(obj);
            }
            lector.Close();
            return lista;
        }

        public Clientes BuscarCliente(string xcod)
        {
            Clientes obj = new Clientes();
            SqlDataReader lector = SqlHelper.ExecuteReader("USP_LISTAR_CLIENTES_X_CODIGO", xcod);
            while (lector.Read())
            {
                obj.codcli = lector.GetString(0);
                obj.nomcli = lector.GetString(1);
                obj.coddis = lector.GetString(2);
                obj.direccioncli = lector.GetString(3);
                obj.dnicli = lector.GetString(4);
                obj.emailcli = lector.GetString(5);
                obj.celcli = lector.GetString(6);
                obj.eliminado = lector.GetString(7);
            }
            lector.Close();
            return obj;
        }
        public string ActualizarCliente(Clientes obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ACTUALIZAR_CLIENTES", obj.codcli, obj.nomcli, obj.coddis,
                obj.direccioncli, obj.dnicli,obj.emailcli,obj.celcli);
            if (registro == 1)
                mensaje = "Cliente "+obj.nomcli+" actualizado correctamente";
            return mensaje;
        }
        public string InsertarCliente(Clientes obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_INSERTAR_CLIENTES", obj.codcli, obj.nomcli, obj.coddis,
                obj.direccioncli, obj.dnicli, obj.emailcli, obj.celcli);
            if (registro == 1)
                mensaje = "Cliente " + obj.nomcli + " insertado correctamente";
            return mensaje;
        }
        public string EliminarCliente(Clientes obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ELIMINAR_CLIENTES_LOGIC", obj.codcli);
            if (registro == 1)
                mensaje = "Cliente " + obj.nomcli + " agregado correctamente";
            return mensaje;
        }


    }
}
