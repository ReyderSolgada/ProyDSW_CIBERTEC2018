using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using Dominio.MainModule;
using Dominio.Core.Entidades;

namespace ProyDSW_Cibertec2018.Controllers
{
    public class EmpleadoController : Controller
    {
        

        EmpleadoManager em = new EmpleadoManager();
       
        // GET: Listado Empleado
        public ActionResult ListaTodoEmpleados()
        {
            return View(em.Listado_Todo_Emleado().ToList());
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Insertar Empleado
        public ActionResult InsertarEmpleado()
        {
            return View(new Empleado());
        }

        [HttpPost]
        public ActionResult Create(Empleado emp)
        {
            try
            {
                string mensaje = em.InsertaEmpleado(emp);
                EnviarCorreo objEnvio = new EnviarCorreo("jose_uno2014@hotmail.com","Envio de Correo","Esta es una prueba de envio electronico");

                if(objEnvio.Estado)
                    Console.Write("Exito al Envio de correo");
                else
                    Console.Write("Error al Envio de correo");

                return RedirectToAction("ListaTodoEmpleados");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleado/Edit/5
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

        // GET: EliminarEmpleado
        public ActionResult EliminarEmpleado(string xcodemp)
        {
            var filtracod = em.Listado_Todo_Emleado().Where(x => x.codemp.Equals(xcodemp)).FirstOrDefault();
            return View(filtracod);
        }

        // POST: EliminarEmpleado
        [HttpPost]
        public ActionResult EliminarEmpleado(string xcodemp, Empleado emp)
        {
            try
            {
                emp = new Empleado();
                emp= em.Listado_Todo_Emleado().Where(x => x.codemp.Equals(xcodemp)).FirstOrDefault();

                string mensaje = em.EliminaEmpleado(emp);

                return RedirectToAction("ListaTodoEmpleados");
            }
            catch
            {
                return View();
            }
        }
    }
}
