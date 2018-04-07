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
    public class ProdutosController : BaseCrudController<IProdutoAppService, Produto, ProdutoViewModel>
    {
        public ProdutosController(IProdutoAppService context) : base(context)
        {
        }
    }
}
