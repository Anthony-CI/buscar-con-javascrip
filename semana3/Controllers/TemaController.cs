using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using semana3.BD;
using semana3.Extensions;
using semana3.Models;

namespace semana3.Controllers
{
    [Authorize]

    public class TemaController : Controller
    {

        public IActionResult Index(string query)
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var model = contex.Tema
                .Include(o => o.Categoria)
                .Where(o => o.UsuarioId == userLogged.Id);

            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(o=>o.Titulo.Contains(query));
            }
            ViewBag.Query = query;    
            return View(model.ToList());
        }
        
        [HttpGet]
        public IActionResult Crear()
        {
            var contex = new AppPruebaContex();
            ViewBag.Categoria = contex.Categoria.ToList();
            return View(new Tema());
        }

        [HttpPost]
        public IActionResult Crear(Tema Tema)
        {

            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            if (!ModelState.IsValid)
            {
                ViewBag.Categoria = contex.Categoria.ToList();
                return View(Tema);
            }

            Tema.UsuarioId = userLogged.Id;
            contex.Tema.Add(Tema);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Eliminar(int id)
        {
            var context = new AppPruebaContex();
            var proDB = context.Tema.Where(o => o.Id == id).First();
            context.Tema.Remove(proDB);
            context.SaveChanges();

            return RedirectToAction("Index");

        }



        [HttpGet]
        public ViewResult Editar(int id)
        {
            var context = new AppPruebaContex();
            var te = context.Tema.Where(o => o.Id == id).First();
            ViewBag.Categoria = context.Categoria.ToList();
            return View(te);
        }

        [HttpPost]
        public IActionResult Editar(Tema tema)
        {
            var context = new AppPruebaContex();
            if (!ModelState.IsValid)
            {
                ViewBag.Categoria = context.Categoria.ToList();
                return View(tema);
            }

            var userDB = context.Tema.Where(o => o.Id == tema.Id).First();
            userDB.Titulo = tema.Titulo;
            userDB.CategoriaId = tema.CategoriaId;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Mostar()
        {
            var userLogged = HttpContext.Session.Get<Usuario>("SessionLoggedUser");
            var contex = new AppPruebaContex();
            var model = contex.Tema
                .Include(o => o.Categoria)
                .Where(o => o.UsuarioId == userLogged.Id)
                .ToList();
            return View(model);
        }
    }
}