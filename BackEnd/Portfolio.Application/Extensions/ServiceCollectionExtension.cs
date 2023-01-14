﻿using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Services;
using Portfolio.Application.Services.Interfaces;

namespace Portfolio.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IDadosPortfolioService, DadosPortfolioService>();
        }
    }
}
