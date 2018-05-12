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
    public abstract class BaseCrudController<TIAppService, TEntityViewModel> : Controller
        where TEntityViewModel : BaseViewModel
        where TIAppService : IBaseAppService<TEntityViewModel>
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
            return await GetEntityViewModel(id);
        }

        public virtual IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Create(TEntityViewModel entityViewModel)
        {
            if (ModelState.IsValid)
            {
                entityViewModel.Id = Guid.NewGuid();
                await _appService.AddAsync(entityViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(entityViewModel);
        }

        public virtual async Task<IActionResult> Edit(Guid? id)
        {
            return await GetEntityViewModel(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Edit(Guid id, TEntityViewModel entityViewModel)
        {
            if (id != entityViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.Update(entityViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntityViewModelExists(entityViewModel.Id))
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
            return View(entityViewModel);
        }

        public virtual async Task<IActionResult> Delete(Guid? id)
        {
            return await GetEntityViewModel(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<IActionResult> GetEntityViewModel(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entityViewModel = await _appService.FindAsync(id.Value);
            if (entityViewModel == null)
            {
                return NotFound();
            }

            return View(entityViewModel);
        }

        private bool EntityViewModelExists(Guid id)
        {
            return _appService.QueryAllAsNoTracking().Any(e => e.Id == id);
        }
    }
}
