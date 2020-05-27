using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using semana3.BD;
using semana3.Models;

namespace semana3.Controllers
{
    public class HomeController : Controller
    {
        

        [HttpGet]
        public ViewResult Index()
        {
            var context = new AppPruebaContex();
            var users = context.Usuarios.ToList();
            return View(users);
        }
        [HttpGet]
        public ViewResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(string username)
        {
            var context = new AppPruebaContex();
            var user = new Usuario();
            user.NombreUsuario = username;

            if (ModelState.IsValid)
            {
                
                context.Usuarios.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Crear");
        }


        [HttpGet]
        public ViewResult Editar(int id)
        {
            var context = new AppPruebaContex();
            var user = context.Usuarios.Where(o=>o.Id ==id).First();
            return View(user);
        }

        [HttpPost]
        public RedirectToActionResult Editar(Usuario  user)
        {
            var context = new AppPruebaContex();
            var userDB = context.Usuarios.Where(o=>o.Id==user.Id).First();
            userDB.NombreUsuario = user.NombreUsuario;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public RedirectToActionResult Eliminar(int id)
        {
            var context = new AppPruebaContex();
            var userDB = context.Usuarios.Where(o => o.Id == id).First();
            context.Usuarios.Remove(userDB);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
