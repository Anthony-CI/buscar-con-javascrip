using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using semana3.BD;
using semana3.Models;

namespace semana3.Controllers
{
    public class AlternativaController : Controller
    {
        [HttpGet]
        public IActionResult Crear(int preguntaId)
        {
            var context = new AppPruebaContex();
            ViewBag.Pregunta = context.Pregunta
                .Include(o => o.Tema)
                .First(o => o.Id == preguntaId);

            return View();
        }

        [HttpPost]
        public IActionResult Crear(Alternativa alternativa, int temaId)
        {
            var context = new AppPruebaContex();
            context.Alternativas.Add(alternativa);
            context.SaveChanges();

            return RedirectToAction("Index", "Pregunta", new { temaId = temaId });
        }



        [HttpGet]
        public ViewResult Editar(int id)
        {
            var context = new AppPruebaContex();
            
            var alternativa = context.Alternativas.Where(o => o.Id == id).First();
            ViewBag.Pregunta = context.Pregunta.Find(alternativa.PreguntaId);
            return View(alternativa);
        }

        [HttpPost]
        public IActionResult Editar(Alternativa alternativa, int temaId)
        {
            var context = new AppPruebaContex();

            ViewBag.Pregunta = context.Pregunta.Find(alternativa.PreguntaId);
            var userDB = context.Alternativas.Where(o => o.Id == alternativa.Id).First();
            userDB.Resumen = alternativa.Resumen;
            userDB.EsCorrecto = alternativa.EsCorrecto;
            context.SaveChanges();

            return RedirectToAction("Index", "Pregunta", new { temaId = temaId });
        }



    }


}