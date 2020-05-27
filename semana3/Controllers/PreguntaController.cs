using System;
using System.Collections.Generic;
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
    public class PreguntaController : Controller
    {
        public IActionResult Index(int temaId)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var context = new AppPruebaContex();
            var model = context.Tema
                //.Include(x => x.Preguntas)
                .Include("Preguntas.Alternativas")
                .Include(x => x.Categoria)
                .Where(x => x.Id == temaId && x.UsuarioId == userLogged.Id)
                .FirstOrDefault();
            return View(model);
        }

        [HttpGet]
        public IActionResult Crear(int temaId)
        {

            ViewBag.TemaId = temaId;
            return View();



        }

        [HttpPost]
        public IActionResult Crear(Pregunta pregunta)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();


            pregunta.Tema.UsuarioId= userLogged.Id;
            contex.Pregunta.Add(pregunta);
            contex.SaveChanges();
            return RedirectToAction("Index", new { temaId = pregunta.TemaId });
        }
    }
}