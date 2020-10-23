using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteMVC.Models;

namespace SiteMVC.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fale()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarContato(Contato c)
        {

            ContatoRepository repositorio = new ContatoRepository();
            repositorio.Cadastra(c);


            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult SalvarRegistro(Registro r)
        {

            RegistroRepository repositorio = new RegistroRepository();
            repositorio.Cadastra(r);

            


            return RedirectToAction("Index");

        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Loja()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }



        public IActionResult Sobre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Registro r)
        {
            RegistroRepository rr = new RegistroRepository();
            Registro registro = rr.QueryLogin(r);
            if (registro != null)
            {
                ViewBag.Mensagem = "Você está logado";

                HttpContext.Session.SetString("EMail", registro.EMail);

                return Redirect("Index");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";

                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
