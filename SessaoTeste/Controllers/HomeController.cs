using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessaoTeste.Models;
using Microsoft.AspNetCore.Http;

namespace SessaoTeste.Controllers
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
            string nomeUsuario = HttpContext.Session.GetString("nome_user");
            if (nomeUsuario != null)
            {
                ViewData["pessoa"] = nomeUsuario + " você já está logado";
            }

            return View();
        }
        [HttpPost]

        public IActionResult Login(string nome)
        {
            HttpContext.Session.SetString("nome_user", nome);
           
            return View();

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
        public IActionResult Privacy()
        {
            string nomeUsuario = HttpContext.Session.GetString("nome_user");
             if (nomeUsuario == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
