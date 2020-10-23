
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Trabalho2_Banco_De_Dados.Models;


namespace Trabalho2_Banco_De_Dados.Controllers
{
    public class PacoteController : Controller
    {
        public IActionResult Cadastro()
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(Pacote p)
        {
             if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            ViewBag.Mensagem = "Pacote cadastrado com sucesso";
            //Gravar no banco de dados
            PacoteRepository repositorio = new PacoteRepository();
            repositorio.Cadastra(p);


            return RedirectToAction("Listar");
        }

        public IActionResult Salvar()
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            
            return View();
        }

        public IActionResult Listar()
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            List<Pacote> pacotes = new List<Pacote>();
            PacoteRepository repositorio = new PacoteRepository();
            pacotes = repositorio.ListaPacotes();

            return View(pacotes);
        }

        public IActionResult Detalhar(int id)
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");

            PacoteRepository repositorio = new PacoteRepository();
            Pacote p = repositorio.ListaPorId(id);
            return View(p);
        }

        public IActionResult Atualizar(int id)
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            
            PacoteRepository repositorio = new PacoteRepository();
            Pacote p = repositorio.ListaPorId(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult SalvarAtualizar(Pacote p)
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            //Gravar no banco de dados
            PacoteRepository repositorio = new PacoteRepository();
            repositorio.Atualiza(p);


            return Redirect("Listar");
        }

        public IActionResult Excluir(int id)
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            
            PacoteRepository repositorio = new PacoteRepository();
            Pacote p = repositorio.ListaPorId(id);
            repositorio.Delete(p);
            return RedirectToAction("Listar");
        }
    }
}