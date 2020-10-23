using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trabalho2_Banco_De_Dados.Models;
using MySql.Data.MySqlClient;

namespace Trabalho2_Banco_De_Dados.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Pacote> pacotes = new List<Pacote>();
            PacoteRepository repositorio = new PacoteRepository();
            pacotes = repositorio.ListaPacotes();

            return View(pacotes);
        }
        

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRespository ur = new UsuarioRespository();
            Usuario usuario = ur.QueryLogin(u);
            if (usuario != null)
            {
                ViewBag.Mensagem = "Você está logado";
                HttpContext.Session.SetInt32("IdUser", usuario.IdUser);
                HttpContext.Session.SetString("NomeUser", usuario.NomeUser);

                return Redirect("Index");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";

                return View();
            }
        }

        public IActionResult Listagem()
        {
            return View();
        }

            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return View();
            }

        public IActionResult Listar()
        {

            List<Pacote> pacotes = new List<Pacote>();
            PacoteRepository repositorio = new PacoteRepository();
            pacotes = repositorio.ListaPacotes();

            return View(pacotes);
        }




    }
}
