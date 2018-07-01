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

        LoginManager lm = new LoginManager();
        // GET: Login
        public ActionResult Inicio_Sesion()
        {
            return View(new Login());
        }


        

        
        public ActionResult Cerrar_Sesion()
        {
            try
            {
                Session.Clear();
                return RedirectToAction("Inicio_Sesion");
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult Inicio_Sesion(Login l)
        {
            try
            {
                var lista = lm.listar_Login().Where(x => x.Usuario.Equals(l.Usuario.ToString()) && x.Contraseña.Equals(l.Contraseña.ToString())).FirstOrDefault();


                if(lista !=null)
                {
                    Session["LogUser"] = l.Usuario.ToString();
                   

                    return RedirectToAction("Listado_Cliente");
                }
                else
                {
                    return View(new Login());
                }
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Listado_Cliente()
        {
            if(Session["LogUser"]!=null)
            {
                return View(lm.listar_Login().ToList());
            }
            else
            {
                return RedirectToAction("Inicio_Sesion");
            }
            
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
