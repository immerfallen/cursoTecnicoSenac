using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConfirmaPresencaMVC.Models;

namespace ConfirmaPresencaMVC.Controllers
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
        public IActionResult Confirma()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirma(Convidado convidado)
        {
            if (ListaConvidados.Incluir(convidado))
            {
               
                return View("Concluido");
            }
            else
            {
                return View("NaoConcluido");
            }
        }

        public IActionResult Listagem()
        {
            List<Convidado> convidados = ListaConvidados.Listar();
            return View(convidados);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
