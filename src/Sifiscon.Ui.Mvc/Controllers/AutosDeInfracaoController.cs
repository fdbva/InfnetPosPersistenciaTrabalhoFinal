using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sifiscon.Application.AppServices.Interfaces;
using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;
using Sifiscon.Infra.Data.Context;

namespace Sifiscon.Ui.Mvc.Controllers
{
    public class AutosDeInfracaoController : Controller
    {
        private readonly IAutoDeInfracaoAppService _appService;

        public AutosDeInfracaoController(IAutoDeInfracaoAppService appService)
        {
            _appService = appService;
        }

        // GET: AutosDeInfracao
        public IActionResult Index()
        {
            return View(_appService.GetAll());
        }

        // GET: AutosDeInfracao/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoDeInfracao = await _appService.FindAsync(id.Value);
            if (autoDeInfracao == null)
            {
                return NotFound();
            }

            return View(autoDeInfracao);
        }

        // GET: AutosDeInfracao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AutosDeInfracao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GravidadeInfracao,Atenuante,Agravante,Id")] AutoDeInfracaoViewModel autoDeInfracao)
        {
            if (ModelState.IsValid)
            {
                autoDeInfracao.Id = Guid.NewGuid();
                await _appService.AddAsync(autoDeInfracao);
                return RedirectToAction(nameof(Index));
            }
            return View(autoDeInfracao);
        }

        // GET: AutosDeInfracao/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoDeInfracao = await _appService.FindAsync(id.Value);
            if (autoDeInfracao == null)
            {
                return NotFound();
            }
            return View(autoDeInfracao);
        }

        // POST: AutosDeInfracao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("GravidadeInfracao,Atenuante,Agravante,Id")] AutoDeInfracaoViewModel autoDeInfracao)
        {
            if (id != autoDeInfracao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.Update(autoDeInfracao);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoDeInfracaoExists(autoDeInfracao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(autoDeInfracao);
        }

        // GET: AutosDeInfracao/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoDeInfracao = await _appService.FindAsync(id.Value);
            if (autoDeInfracao == null)
            {
                return NotFound();
            }

            return View(autoDeInfracao);
        }

        // POST: AutosDeInfracao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AutoDeInfracaoExists(Guid id)
        {
            return _appService.QueryAllAsNoTracking().Any(e => e.Id == id);
        }
    }
}
