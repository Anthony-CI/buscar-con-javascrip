using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using semana3.BD;
using semana3.Extensions;
using semana3.Models;

namespace semana3.Controllers
{
    public class ExamenController : Controller
    {
        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var model = contex.Examenes
                .Include(o => o.Tema)
                .Where(o => o.UsuarioId == userLogged.Id)
                .ToList();
            return View(model);
        }


        [HttpGet]
        public IActionResult Crear()
        {
            
            var contex = new AppPruebaContex();
            
            ViewBag.Tema = contex.Tema.ToList();
            return View(new Examen());
        }

        [HttpPost]
        public IActionResult Crear(Examen examen)
        {

            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            if (!ModelState.IsValid)
            {
                ViewBag.Tema = contex.Tema.ToList();
                return View(examen);
            }

            examen.UsuarioId = userLogged.Id;
            contex.Examenes.Add(examen);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}