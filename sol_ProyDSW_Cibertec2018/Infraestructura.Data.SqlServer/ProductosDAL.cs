using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Core.Entidades;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class ProductosDAL:Variable
    {

        public List<Productos> ListarProducto()
        {
     
            List<Productos> lista = new List<Productos>();
            SqlDataReader lector = SqlHelper.ExecuteReader(CAD_CN, "USP_LISTAR_PRODUCTOS");
            while (lector.Read())
            {
                Productos obj = new Productos();
                obj.codpro = lector.GetString(0);
                obj.nompro = lector.GetString(1);
                obj.stock = lector.GetInt32(2);
                obj.precio = lector.GetDouble(3);
                obj.codtipo = lector.GetString(4);
                obj.eliminado = lector.GetString(5);
                if (obj.eliminado.Equals("NO"))
                    lista.Add(obj);
            }
            lector.Close();
            return lista;
        }

        public Productos BuscarProducto(string xnom)
        {
            Productos obj = new Productos();
            SqlDataReader lector = SqlHelper.ExecuteReader("USP_LISTAR_PRODUCTOS_X_DESCRIPCION", xnom);
            while (lector.Read())
            {
                obj.codpro = lector.GetString(0);
                obj.nompro = lector.GetString(1);
                obj.stock = lector.GetInt32(2);
                obj.precio = lector.GetDouble(3);
                obj.codtipo = lector.GetString(4);
                obj.eliminado = lector.GetString(5);
            }
            lector.Close();
            return obj;
        }
        public string ActualizarProducto(Productos obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ACTUALIZAR_PRODUCTOS",obj.nompro,obj.stock,
                obj.precio, obj.codtipo, obj.eliminado);
            if (registro == 1)
                mensaje = "Producto " + obj.nompro + " actualizado correctamente";
            return mensaje;
        }
        public string InsertarProducto(Productos obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_INSERTAR_PRODUCTOS", obj.codpro, obj.nompro,obj.stock,
                obj.precio, obj.codtipo, obj.eliminado);
            if (registro == 1)
                mensaje = "Producto " + obj.nompro + " agregado correctamente";
            return mensaje;
        }

        public string EliminarProducto(Productos obj)
        {
            string mensaje = "";
            int registro = SqlHelper.ExecuteNonQuery("USP_ELIMINAR_CLIENTES_LOGIC", obj.codpro);
            if (registro == 1)
                mensaje = "Producto " + obj.nompro + " agregado correctamente";
            return mensaje;
        }
    }
}
