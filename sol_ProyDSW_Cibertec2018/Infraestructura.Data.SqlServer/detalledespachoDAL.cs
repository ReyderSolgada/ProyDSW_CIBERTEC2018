using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class DetalleDespachoDAL : Variable
    {
        public List<DetalleDespacho> ListarDetalleDespacho()
        {
            List<DetalleDespacho> lista = new List<DetalleDespacho>();
            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_DETALLEDESPACHO");
            while (lector.Read())
            {
                DetalleDespacho obj = new DetalleDespacho();
                obj.nrodespacho = lector.GetString(0);
                obj.nroboleta = lector.GetString(1);
                obj.nrocajas = lector.GetInt32(2);
                lista.Add(obj);
            }
            lector.Close();
            return lista;
        }

        public DetalleDespacho BuscarDetalleDespacho(string xcod)
        {
            DetalleDespacho obj = new DetalleDespacho();
            SqlDataReader lector = SqlHelper.ExecuteReader("USP_LISTAR_DETALLEDESPACHO_X_NUMERO", xcod);
            while (lector.Read())
            {
                obj.nrodespacho = lector.GetString(0);
                obj.nroboleta = lector.GetString(1);
                obj.nrocajas = lector.GetInt32(2);
            }
            lector.Close();
            return obj;
        }

        public string ActualizarDetalleDespacho(DetalleDespacho obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ACTUALIZAR_DETALLEDESPACHO", obj.nrodespacho, obj.nroboleta, obj.nrocajas
               );
            if (registro == 1)
                mensaje = "DetalleDespacho " + obj.nrodespacho + " actualizado correctamente";
            return mensaje;
        }
        public string InsertarDetalleDespacho(DetalleDespacho obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_INSERTAR_DETALLEDESPACHO", obj.nrodespacho, obj.nroboleta, obj.nrocajas
                );
            if (registro == 1)
                mensaje = "Detalle Despacho " + obj.nrodespacho + " insertado correctamente";
            return mensaje;
        }
        public string EliminarDetalleDespacho(DetalleDespacho obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ELIMINAR_DETALLEDESPACHO", obj.nrodespacho);
            if (registro == 1)
                mensaje = "Detalle Despacho " + obj.nrodespacho + " eliminado correctamente";
            return mensaje;
        }

   


    }
}
