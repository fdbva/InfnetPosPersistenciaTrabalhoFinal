using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
    public static class NativeInjectorBootstrapper
    {

        public static void RegisterServices(IServiceCollection services)
        {
            // 2 - Application AutoMapper
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            // 2 - Application AppServices
            services.AddScoped(typeof(IAutoDeInfracaoAppService), typeof(AutoDeInfracaoAppService));
            services.AddScoped(typeof(IEnderecoAppService), typeof(EnderecoAppService));
            services.AddScoped(typeof(IFornecedorAppService), typeof(FornecedorAppService));
            services.AddScoped(typeof(IProcessoAppService), typeof(ProcessoAppService));
            services.AddScoped(typeof(IProdutoAppService), typeof(ProdutoAppService));

            // 3 - Domain Services
            services.AddScoped(typeof(IAutoDeInfracaoService), typeof(AutoDeInfracaoService));
            services.AddScoped(typeof(IEnderecoService), typeof(EnderecoService));
            services.AddScoped(typeof(IFornecedorService), typeof(FornecedorService));
            services.AddScoped(typeof(IProcessoService), typeof(ProcessoService));
            services.AddScoped(typeof(IProdutoService), typeof(ProdutoService));

            // 3 - Domain Repositories
            services.AddScoped(typeof(IAutoDeInfracaoRepository), typeof(AutoDeInfracaoRepository));
            services.AddScoped(typeof(IEnderecoRepository), typeof(EnderecoRepository));
            services.AddScoped(typeof(IFornecedorRepository), typeof(FornecedorRepository));
            services.AddScoped(typeof(IProcessoRepository), typeof(ProcessoRepository));
            services.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));

            // 4.1 - Infra.Data
            services.AddScoped<SifisconContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
