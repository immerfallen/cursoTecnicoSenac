using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoDB.Models;



namespace ProjetoDB.Controllers
{
    public class SetorController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(Setor s)
        {
            //Gravar no banco de dados
            Repository repositorio = new Repository();
            repositorio.Cadastra(s);


            return RedirectToAction("Listar");
        }

        public IActionResult Salvar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            List<Setor> setores = new List<Setor>();
            Repository repositorio = new Repository();
            setores = repositorio.ListaSetores();

            return View(setores);
        }

        public IActionResult Detalhar(int id)
        {

            Repository repositorio = new Repository();
            Setor s = repositorio.ListaPorId(id);
            return View(s);
        }

        public IActionResult Atualizar(int id)
        {
            Repository repositorio = new Repository();
            Setor s = repositorio.ListaPorId(id);
            return View(s);
        }

        [HttpPost]
        public IActionResult SalvarAtualizar(Setor s)
        {
            //Gravar no banco de dados
            Repository repositorio = new Repository();
            repositorio.Atualiza(s);


            return RedirectToAction("Listar");
        }

        public IActionResult Excluir(int id)
        {
             Repository repositorio = new Repository();
            Setor s = repositorio.ListaPorId(id);
            repositorio.Delete(s);
            return RedirectToAction("Listar");
        }

    }
}