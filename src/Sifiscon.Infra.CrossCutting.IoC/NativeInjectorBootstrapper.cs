using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Sifiscon.Application.AppServices;
using Sifiscon.Application.AppServices.Interfaces;
using Sifiscon.Domain.DataInterfaces.Repositories;
using Sifiscon.Domain.DataInterfaces.UoW;
using Sifiscon.Domain.Entities;
using Sifiscon.Domain.Services;
using Sifiscon.Domain.Services.Interfaces;
using Sifiscon.Infra.Data.Context;
using Sifiscon.Infra.Data.Repositories;
using Sifiscon.Infra.Data.UoW;

namespace Sifiscon.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootstrapper
    {

        public static void RegisterServices(IServiceCollection services)
        {
            // 2 - Application AppServices
            services.AddScoped<IAutoDeInfracaoAppService, AutoDeInfracaoAppService>();
            services.AddScoped<IEnderecoAppService, EnderecoAppService>();
            services.AddScoped<IFornecedorAppService, FornecedorAppService>();
            services.AddScoped<IProcessoAppService, ProcessoAppService>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();

            // 3 - Domain Services
            services.AddScoped<IAutoDeInfracaoService, AutoDeInfracaoService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProcessoService, ProcessoService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            // 3 - Domain Repositories
            services.AddScoped<IAutoDeInfracaoRepository, AutoDeInfracaoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProcessoRepository, ProcessoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // 4.1 - Infra.Data
            services.AddScoped<SifisconContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
