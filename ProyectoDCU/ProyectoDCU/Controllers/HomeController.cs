using Microsoft.AspNetCore.Mvc;
using ProyectoDCU.Models;
using System.Diagnostics;
using System.Net;

namespace ProyectoDCU.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Historias()
        {
            return View();
        }
        public IActionResult MedioA()
        {
            return View();
        }
        public IActionResult RecursosE()
        {
            return View();
        }
        public IActionResult Unete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostUnete(UsuarioViewModel model)
        {
            try
            {
                var modelData = new Usuario() { 
                    Nombre = model.Nombre ?? "",
                    Celular = model.Celular ?? "",
                    Correo = model.Correo ?? ""
                    
                };

                Datos.CrearRegistro(modelData);
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
            
        }

        [HttpPost]
        public IActionResult upload(IFormFile image)
        {
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}