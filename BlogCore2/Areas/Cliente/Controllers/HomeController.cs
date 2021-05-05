using BlogCore2.AccesoDatos.Data.Repository;
using BlogCore2.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore2.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public HomeController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HomeVM homevm = new HomeVM()
            {
                Slider = _contenedorTrabajo.Slider.GetAll(),
                Articulo = _contenedorTrabajo.Articulo.GetAll()
            };

            return View(homevm);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var articuloDesdeDb = _contenedorTrabajo.Articulo.GetFirstOrDefault(a => a.Id == id);
            return View(articuloDesdeDb);
        }
    }
}
