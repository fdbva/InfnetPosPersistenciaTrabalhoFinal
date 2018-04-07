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
    public class ProcessosController : Controller
    {
        private readonly IProcessoAppService _appService;

        public ProcessosController(IProcessoAppService appService)
        {
            _appService = appService;
        }

        // GET: Processos
        public IActionResult Index()
        {
            return View(_appService.GetAll());
        }

        // GET: Processos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _appService.FindAsync(id.Value);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // GET: Processos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Processos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cnpj,NumeroProcesso,RelatoFiscalizacao,DataRelato,FiscalResposavel,Id")] ProcessoViewModel processo)
        {
            if (ModelState.IsValid)
            {
                processo.Id = Guid.NewGuid();
                await _appService.AddAsync(processo);
                return RedirectToAction(nameof(Index));
            }
            return View(processo);
        }

        // GET: Processos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _appService.FindAsync(id.Value);
            if (processo == null)
            {
                return NotFound();
            }
            return View(processo);
        }

        // POST: Processos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Cnpj,NumeroProcesso,RelatoFiscalizacao,DataRelato,FiscalResposavel,Id")] ProcessoViewModel processo)
        {
            if (id != processo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.Update(processo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessoExists(processo.Id))
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
            return View(processo);
        }

        // GET: Processos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _appService.FindAsync(id.Value);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // POST: Processos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessoExists(Guid id)
        {
            return _appService.QueryAllAsNoTracking().Any(e => e.Id == id);
        }
    }
}
