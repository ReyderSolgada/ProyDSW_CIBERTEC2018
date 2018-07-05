using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Core.Entidades;
using Dominio.MainModule;

namespace ProyDSW_Cibertec2018.Controllers
{
    public class ClientesController : Controller
    {
        ClienteManager cm = new ClienteManager();
        DistritoManager dm = new DistritoManager();
        // GET: Clientes
        public ActionResult ListarCliente()
        {
            ViewBag.MENSAJE = "";
            if (TempData["MENSAJE"] != null)
                ViewBag.MENSAJE = TempData["MENSAJE"].ToString();
            return View(cm.ListarCliente());
        }

        // GET: Clientes/Details/5
        public ActionResult DetalleCliente(string xcod)
        {
            return View(cm.BuscarCliente(xcod));
        }

        // GET: Clientes/Create
        public ActionResult CreateCliente()
        {
            ViewBag.DISTRITO = new SelectList(dm.ListarDistrito(), "coddis", "nomdis");
            return View(new Clientes());
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult CreateCliente(Clientes obj)
        {
            try
            {
                ViewBag.DISTRITO = new SelectList(dm.ListarDistrito(), "coddis", "nomdis",obj.coddis);
                string mensaje = cm.InsertarCliente(obj);
                TempData["MENSAJE"] = mensaje;
                //return View(obj);
                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
