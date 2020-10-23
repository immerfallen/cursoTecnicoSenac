using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasAlunosMVC.Models;

namespace NotasAlunosMVC.Controllers
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

        public IActionResult Detalhe()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Maro";
            aluno.Idade = 15;
            aluno.Disciplina = "Ingles";
            aluno.Nota = 8.5;

            return View(aluno);
        }
            [HttpPost]
            public IActionResult Cadastro(Aluno aluno)
            {
                BaseDados.Incluir(aluno);
                return View("Concluido");
            }

            public IActionResult Cadastro()
            {
                return View();
            }

            public IActionResult Listagem()
            {
                List<Aluno> alunos = BaseDados.Listar();
                return View(alunos);
            }
        
           

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
