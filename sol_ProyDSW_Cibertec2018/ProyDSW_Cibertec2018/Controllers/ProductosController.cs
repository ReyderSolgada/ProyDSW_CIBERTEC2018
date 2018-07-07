using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProyDSW_Cibertec2018.Models;
using Dominio.MainModule;
using Dominio.Core.Entidades;

namespace ProyDSW_Cibertec2018.Controllers
{
    public class ProductosController : Controller
    {
        CarritoDAO objDAO = new CarritoDAO();
        // GET: Producto
        public ActionResult ListaProductos(String prod_nom="")
        {
            if (Session["carrito"] == null)
            {
                List<producto_carrito> carrito = new List<producto_carrito>();
                Session["carrito"] = carrito;
            }
            ViewBag.PROD_NOM = prod_nom;
            return View(objDAO.usp_listar_productos(prod_nom));
        }

        // GET: Producto/Details/5
        public ActionResult Seleccionar_Producto(String id="")
        {
            usp_listar_productos un_art = objDAO.usp_listar_productos("").Where(x => x.prod_cod.Equals(id)).FirstOrDefault();

            usp_listar_productos art2 = (from z in objDAO.usp_listar_productos("")
                                         where z.prod_cod.Equals(id)
                                         select z).FirstOrDefault();
            /*
            foreach (var item in objDAO.usp_listar_articulos(""))
            {
                if (item.art_cod.Equals(id))
                {
                    un_art3 = item;
                }
            }
            */
            return View(un_art);
        }

        // GET: Empleado/Create
        public ActionResult Agregar_Carrito(String prod_cod)
        {
            usp_listar_productos un_art2 = (from z in objDAO.usp_listar_productos("")
                                            where z.prod_cod.Equals(prod_cod)
                                            select z).FirstOrDefault();
            producto_carrito x = new producto_carrito();
            x.prod_cod = un_art2.prod_cod;
            x.prod_nom = un_art2.prod_nom;
            x.cant = 1;
            x.prod_precio = un_art2.prod_pre;

            List<producto_carrito> carrito = (List<producto_carrito>)Session["carrito"];
            carrito.Add(x);

            Session["Carrito"] = carrito;


            return RedirectToAction("ListaProductos");

        }

        // POST: Empleado/Create
      

      

        // POST: Empleado/Edit/5
      

        // GET: Empleado/Delete/5
        public ActionResult Comprar()
        {
            List<producto_carrito> carrito = (List<producto_carrito>)Session["carrito"];

            if (carrito.Count == 0)
            {
                return RedirectToAction("ListaProductos");
            }
            return View(carrito);
        }

        // POST: Empleado/Delete/5
        
    }
}
