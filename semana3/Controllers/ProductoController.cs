using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using semana3.BD;
using semana3.Models;

namespace semana3.Controllers
{
    public class ProductoController : Controller
    {
        public ViewResult Index()
        {
            var context = new AppPruebaContex();
            var produc = context.Productos.ToList();
            return View(produc);

        }

        [HttpGet]
        public ViewResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Producto p)
        {
            var context = new AppPruebaContex();

            if (ModelState.IsValid)
            {
                context.Productos.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Crear");
            
        }

        [HttpGet]

        public RedirectToActionResult Eliminar(int id)
        {
            var context = new AppPruebaContex();
            var proDB = context.Productos.Where(o => o.Id == id).First();
            context.Productos.Remove(proDB);
            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}