using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioEmail;

        public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail)
        {
            _logger = logger;
            this.servicioEmail = servicioEmail;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyecto().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };

            return View(modelo);
        }

        public IActionResult Proyectos()

        {
            var proyectos = repositorioProyectos.ObtenerProyecto();
            return View(proyectos);
        }
        [HttpGet]
        public IActionResult Contacto()

        {

            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Contacto(ContactoViewModelcs contactoViewModelcs)
        {
            await servicioEmail.Enviar(contactoViewModelcs);
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}