using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FarmaciaMVC.Models;

namespace FarmaciaMVC.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Lista()
        {
            MedicamentoRepository medicamentoRepo = new MedicamentoRepository();
            List<Medicamento> medicamentos = medicamentoRepo.Lista();

            return View(medicamentos);
        }
    }
}