using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class despachoDAL : Variable
    {
        public List<despacho> ListarDespacho()
        {
            List<despacho> lista = new List<despacho>();
            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_DESPACHO");
            while (lector.Read())
            {
                despacho obj = new despacho();
                obj.nrodespacho = lector.GetString(0);
                obj.fechatraslado = lector.GetDateTime(1);
                obj.fechaentrega = lector.GetDateTime(2);
                obj.destino = lector.GetString(3);
                obj.transporte = lector.GetString(4);
                obj.estado = lector.GetInt32(5);
                lista.Add(obj);
            }
            lector.Close();
            return lista;
        }

        public despacho BuscarDespacho(string xcod)
        {
            despacho obj = new despacho();
            SqlDataReader lector = SqlHelper.ExecuteReader("USP_LISTAR_DESPACHO_X_NUMERO", xcod);
            while (lector.Read())
            {
                obj.nrodespacho = lector.GetString(0);
                obj.fechatraslado = lector.GetDateTime(1);
                obj.fechaentrega = lector.GetDateTime(2);
                obj.destino = lector.GetString(3);
                obj.transporte = lector.GetString(4);
                obj.estado = lector.GetInt32(5);
            }
            lector.Close();
            return obj;
        }

        public string ActualizarDespacho(despacho obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ACTUALIZAR_DESPACHO", obj.nrodespacho, obj.fechatraslado, obj.fechaentrega,
                obj.destino, obj.transporte, obj.estado);
            if (registro == 1)
                mensaje = "Despacho " + obj.nrodespacho + " actualizado correctamente";
            return mensaje;
        }
        public string InsertarDespacho(despacho obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_INSERTAR_DESPACHO", obj.nrodespacho, obj.fechatraslado, obj.fechaentrega,
                obj.destino, obj.transporte, obj.estado);
            if (registro == 1)
                mensaje = "Despacho " + obj.nrodespacho + " insertado correctamente";
            return mensaje;
        }
        public string EliminarDespacho(despacho obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ELIMINAR_DESPACHO", obj.nrodespacho);
            if (registro == 1)
                mensaje = "Despacho " + obj.nrodespacho + " eliminado correctamente";
            return mensaje;
        }


    }
}
