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

        public ActionResult ListaTodoEmpleados()
        {
            if (TempData["MENSAJE"] != null)
                ViewBag.MUESTRA = TempData["MENSAJE"].ToString();

            if (Session["LogUser"] != null)
            {
                return View(em.Listado_Todo_Emleado().ToList());
            }
            else
            {
                return   RedirectToAction("Inicio_Sesion_Empleado", "Login");
            }     
        }

        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult InsertarEmpleado()
        {
            ViewBag.CARGO = new SelectList(cm.Listado_Todo_Cargo(), "CODCARGO", "NOMCARGO");
            ViewBag.DISTRITO = new SelectList(dm.Listado_Todo_Distrito(), "CODDIS", "NOMDIS");

            if (Session["LogUser"] != null)
                return View(new Empleado());
            else
                return RedirectToAction("Inicio_Sesion_Empleado", "Login");
        }

        [HttpPost]
        public ActionResult InsertarEmpleado(Empleado emp)
        {
            try
            {
                string alerta = em.InsertaEmpleado(emp);
                string alerta2 = "Usuario " + emp.nomemp +" Creado Correctamemte";
                TempData["MENSAJE"] = alerta2;
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
            ViewBag.CARGO = new SelectList(cm.Listado_Todo_Cargo().ToList(), "CODCARGO", "NOMCARGO",filtra.codcargo);
            ViewBag.DISTRITO = new SelectList(dm.Listado_Todo_Distrito().ToList(), "CODDIS", "NOMDIS",filtra.coddis);

            if (Session["LogUser"] != null)
                return View(filtra);

            else
                return RedirectToAction("Inicio_Sesion_Empleado", "Login");
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult ActualizaEmpleados(string codemp, Empleado emp)
        {
            try
            {
                string alerta = em.ActualizaEmpleado(emp);
                TempData["MENSAJE"] = alerta;
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

            if (Session["LogUser"] != null)
                return View(filtracod);
       
              else
                return RedirectToAction("Inicio_Sesion_Empleado", "Login");
        }

        // POST: EliminarEmpleado
        [HttpPost]
        public ActionResult EliminarEmpleado(string xcodemp, Empleado emp)
        {
            try
            {
                emp = new Empleado();
                emp= em.Listado_Todo_Emleado().Where(x => x.codemp.Equals(xcodemp)).FirstOrDefault();


                string alerta = em.EliminaEmpleado(emp);

                TempData["MENSAJE"] = alerta;

                return RedirectToAction("ListaTodoEmpleados");
            }
            catch
            {
                return View();
            }
        }
    }
}
