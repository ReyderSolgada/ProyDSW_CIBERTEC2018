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
        CargoManager cm = new CargoManager();
        DistritoManager dm = new DistritoManager();
       
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
            ViewBag.CARGO = new SelectList(cm.Listado_Todo_Cargo(), "CODCARGO", "NOMCARGO");
            ViewBag.DISTRITO = new SelectList(dm.Listado_Todo_Distrito(), "CODDIS", "NOMDIS");

            return View(new Empleado());
        }

        [HttpPost]
        public ActionResult InsertarEmpleado(Empleado emp)
        {
            try
            {
                string mensaje = em.InsertaEmpleado(emp);

                return RedirectToAction("ListaTodoEmpleados");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult ActualizaEmpleados(string codemp)
        {
           

            var filtra = em.Listado_Todo_Emleado().Where(x => x.codemp.Equals(codemp)).FirstOrDefault();
            ViewBag.CARGO = new SelectList(cm.Listado_Todo_Cargo().ToList(), "CODCARGO", "NOMCARGO", "CAR04");
            ViewBag.DISTRITO = new SelectList(dm.Listado_Todo_Distrito().ToList(), "CODDIS",filtra.coddis);

            return View(filtra);
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult ActualizaEmpleados(string codemp, Empleado emp)
        {
            try
            {
                string mensaje = em.ActualizaEmpleado(emp);

                return RedirectToAction("ListaTodoEmpleados");
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
