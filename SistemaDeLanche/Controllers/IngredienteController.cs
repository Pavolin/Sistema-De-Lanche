using Microsoft.AspNetCore.Mvc;
using SistemaDeLanche.BLL.Models;
using SistemaDeLanche.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeLanche.Controllers
{
    public class IngredienteController : Controller
    {
        private readonly IIngredienteRepositorio _ingredienteRepositorio;
        public IngredienteController(IIngredienteRepositorio ingredienteRepositorio)
        {
            _ingredienteRepositorio = ingredienteRepositorio;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _ingredienteRepositorio.PegarTodos());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Ingrediente ingrediente = new Ingrediente
            {

            };

            return View(ingrediente);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IngredienteId,NomeIngrediente,ValorIngrediente,NomeMontado,IngredientesUsados,ValorMontado")] Ingrediente ingrediente)
        {
            if (ModelState.IsValid)
            {
                if (ingrediente.NomeIngrediente != null)
                {
                    await _ingredienteRepositorio.Inserir(ingrediente);
                    TempData["NovoRegistro"] = $"Ingrediente {ingrediente.NomeIngrediente} inserido com sucesso";
                    return RedirectToAction(nameof(Index));
                }
                else if(ingrediente.NomeMontado != null)
                {
                    await _ingredienteRepositorio.Inserir(ingrediente);
                    TempData["NovoRegistro"] = $"Lanche montado {ingrediente.NomeIngrediente} inserido com sucesso";
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(ingrediente);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Ingrediente ingrediente = await _ingredienteRepositorio.PegarPeloId(id);
            if (ingrediente == null)
            {
                return NotFound();
            }

            return View(ingrediente);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IngredienteId,NomeIngrediente,ValorIngrediente,NomeMontado,IngredientesUsados,ValorMontado")] Ingrediente ingrediente)
        {
            if (id != ingrediente.IngredienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (ingrediente.NomeIngrediente != null)
                {
                    await _ingredienteRepositorio.Atualizar(ingrediente);
                    TempData["Atualizacao"] = $"Ingrediente {ingrediente.NomeIngrediente} inserido com sucesso";
                    return RedirectToAction(nameof(Index));
                }
                else if (ingrediente.NomeMontado != null)
                {
                    await _ingredienteRepositorio.Atualizar(ingrediente);
                    TempData["Atualizacao"] = $"Lanche montado {ingrediente.NomeIngrediente} inserido com sucesso";
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(ingrediente);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _ingredienteRepositorio.Excluir(id);
            TempData["Exclusao"] = $"Lanche excluído";
            return Json("Evento excluído");
        }
    }
}
