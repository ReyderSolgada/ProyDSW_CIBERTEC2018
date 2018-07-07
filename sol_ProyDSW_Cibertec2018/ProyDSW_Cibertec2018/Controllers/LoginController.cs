using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Dominio.MainModule;
using Dominio.Core.Entidades;

namespace ProyDSW_Cibertec2018.Controllers
{
    public class LoginController : Controller
    {
        
        EmpleadoManager em = new EmpleadoManager();

        public ActionResult Cerrar_Sesion()
        {
            try
            {
                Session.Clear();
                return RedirectToAction("Inicio_Sesion_Empleado");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Inicio_Sesion_Empleado()
        {
            return View(new Empleado());
        }

        [HttpPost]
        public ActionResult Inicio_Sesion_Empleado(Empleado l)
        {
            try
            {
                var lista = em.Listado_Todo_Emleado().Where(x => x.dni.Equals(l.dni.ToString()) && x.contra.Equals(l.contra.ToString())).FirstOrDefault();


                if (lista != null)
                {
                    Session["LogUser"] = lista.contra.ToString();
                    

                    return RedirectToAction("ListaTodoEmpleados", "Empleado");
                }
                else
                {
                    return View(new Empleado());
                }
            }
            catch
            {
                return View();
            }
        }


        
    }
}
