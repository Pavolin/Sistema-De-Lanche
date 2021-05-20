using Microsoft.AspNetCore.Mvc;
using SistemaDeLanche.BLL.Models;
using SistemaDeLanche.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeLanche.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;
        public LancheController(ILancheRepositorio lancheRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _lancheRepositorio.PegarTodos());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Lanche lanche = new Lanche
            {

            };

            return View(lanche);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LancheId,NomeLanche,Ingredientes,ValorLanche")] Lanche lanche)
        {
            if (ModelState.IsValid)
            {
                await _lancheRepositorio.Inserir(lanche);
                TempData["NovoRegistro"] = $"Lanche {lanche.NomeLanche} inserido com sucesso";
                return RedirectToAction(nameof(Index));
            }

            return View(lanche);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Lanche lanche = await _lancheRepositorio.PegarPeloId(id);
            if (lanche == null)
            {
                return NotFound();
            }

            return View(lanche);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LancheId,NomeLanche,Ingredientes,ValorLanche")] Lanche lanche)
        {
            if (id != lanche.LancheId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _lancheRepositorio.Atualizar(lanche);
                TempData["Atualizacao"] = $"Lanche {lanche.NomeLanche} inserido com sucesso";
                return RedirectToAction(nameof(Index));
            }

            return View(lanche);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _lancheRepositorio.Excluir(id);
            TempData["Exclusao"] = $"Lanche excluído";
            return Json("Evento excluído");
        }
    }
}
