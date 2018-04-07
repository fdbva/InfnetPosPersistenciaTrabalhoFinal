using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sifiscon.Application.AppServices.Interfaces;
using Sifiscon.Application.ViewModels;
using Sifiscon.Domain.Entities;

namespace Sifiscon.Ui.Mvc.Controllers
{
    //TODO: passar a usar o BaseCrudController e praticamente esvaziar os outros
    public abstract class BaseCrudController<TIAppService, TEntity, TEntityViewModel> : Controller
        where TEntity : BaseEntity
        where TEntityViewModel : BaseViewModel
        where TIAppService : IBaseAppService<TEntity, TEntityViewModel>
    {
        private readonly TIAppService _appService;

        protected BaseCrudController(TIAppService context)
        {
            _appService = context;
        }

        public virtual IActionResult Index()
        {
            return View(_appService.GetAll());
        }

        public virtual async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _appService.FindAsync(id.Value);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        public virtual IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Create(TEntityViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                fornecedor.Id = Guid.NewGuid();
                await _appService.AddAsync(fornecedor);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        public virtual async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _appService.FindAsync(id.Value);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Edit(Guid id, TEntityViewModel fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.Update(fornecedor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.Id))
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
            return View(fornecedor);
        }

        public virtual async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _appService.FindAsync(id.Value);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(Guid id)
        {
            return _appService.QueryAllAsNoTracking().Any(e => e.Id == id);
        }
    }
}
