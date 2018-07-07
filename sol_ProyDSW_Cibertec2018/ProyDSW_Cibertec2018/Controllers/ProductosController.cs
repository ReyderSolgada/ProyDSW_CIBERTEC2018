using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Dominio.Core.Entidades;
using Dominio.MainModule;
using ProyDSW_Cibertec2018.Models;

namespace ProyDSW_Cibertec2018.Controllers
{
    public class ProductosController : Controller
    {
        ProductoManager pm = new ProductoManager();

        // GET: Productos
        public ActionResult ListadoProductos()
        {

            if (Session["carrito"] == null)
            {
                List<Item> carrito = new List<Item>();
                Session["carrito"] = carrito;
            }

            return View(pm.Listado_Todo_Productos().ToList());
        }

        // GET: Productos/Details/5
        public ActionResult Seleccionar_Articulo(String id = "")
        {
            Productos usp = pm.Listado_Todo_Productos().Where(x => x.codpro.Equals(id)).FirstOrDefault();
            return View(usp);
        }

        // GET: Productos/Create
        public ActionResult Agregar_Carrito(String codpro)
        {
            Productos usp2 = pm.Listado_Todo_Productos().Where(c => c.codpro.Equals(codpro)).FirstOrDefault();

            Item a = new Item();
            a.codpro = usp2.codpro;
            a.nompro = usp2.nompro;
            a.cantidad = 1;
            a.precio = usp2.precio;


            List<Item> carrito = (List<Item>)Session["carrito"];

            carrito.Add(a);
            Session["Carrito"] = carrito;


            return RedirectToAction("ListadoProductos");
        }

  
        // GET: Productos/Edit/5
        public ActionResult Comprar()
        {

            List<Item> carrito = (List<Item>)Session["carrito"];
            if(carrito.Count==0)
            {
                return RedirectToAction("ListadoProductos");

            }

            return View(carrito);
        }

      
    }
}
