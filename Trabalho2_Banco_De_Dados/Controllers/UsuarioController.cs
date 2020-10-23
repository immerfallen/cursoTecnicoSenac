using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trabalho2_Banco_De_Dados.Models;

namespace Trabalho2_Banco_De_Dados.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            Usuario u = new Usuario();
            
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(Usuario u)
        {
           
            //Gravar no banco de dados
            UsuarioRespository repositorio = new UsuarioRespository();
            repositorio.Cadastra(u);


            return RedirectToAction("Listar");
        }

        public IActionResult Salvar()
        {
            
            return View();
        }

        public IActionResult Listar()
        {
            if (HttpContext.Session.GetInt32("NomeUser") == null)
                return Redirect("/Home/Login");
            List<Usuario> usuarios = new List<Usuario>();
            UsuarioRespository repositorio = new UsuarioRespository();
            usuarios = repositorio.ListaUsuarios();

            return View(usuarios);
        }

        public IActionResult Detalhar(int id)
        {

            
            UsuarioRespository repositorio = new UsuarioRespository();
            Usuario u = repositorio.ListaPorId(id);
            return View(u);
        }

        public IActionResult Atualizar(int id)
        {
            
            UsuarioRespository repositorio = new UsuarioRespository();
            Usuario u = repositorio.ListaPorId(id);
            return View(u);
        }

        [HttpPost]
        public IActionResult SalvarAtualizar(Usuario u)
        {
            //Gravar no banco de dados
            UsuarioRespository repositorio = new UsuarioRespository();
            repositorio.Atualiza(u);


            return RedirectToAction("Listar");
        }

        public IActionResult Excluir(int id)
        {
           
            UsuarioRespository repositorio = new UsuarioRespository();
            Usuario u = repositorio.ListaPorId(id);
            repositorio.Delete(u);
            return RedirectToAction("Listar");
        }
    }
}