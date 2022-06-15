using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TCC_Tela_Inicial.Models;

namespace TCC_Tela_Inicial.Controllers
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
        public IActionResult formulario()
        {
            return View();
        }
        public IActionResult confirmaDados()
        {
            return View();
        }
        public IActionResult localizar()
        {
            return View();
        }
        public IActionResult dadosReserva()
        {
            return View();
        }
        public IActionResult reservaCancelar()
        {
            return View();
        }
        public IActionResult editaDados()
        {
            return View();
        }
        public IActionResult reservaEditar()
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
