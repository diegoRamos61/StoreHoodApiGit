using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using StoreHood.Api.Application;
using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Application.Services;
using StoreHood.Api.DataAccess.Contracts.Repositories;
using StoreHood.Api.DataAccess.Repositories;

namespace StoreHood.Api.CrossCutting
{
    public static class IocRegister
    {
        //Inyección de dependencias.
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {

            AddRegisterServices(services); 
            AddRegisterRepositories(services);

            return services;
        }

        /// <summary>
        /// Todos los métodos nuevos que desarrollemos deben estar implementados en esta interfaz para ser visibles.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IShopService, ShopService>();
            services.AddTransient<IServiceService, ServiceService>();
            //services.AddTransient<IProfessionalService, ProfessionalService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOpinionService, OpinionService>();
            services.AddTransient<IDealerService, DealerService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<ICalendaryService, CalendaryService>();
            services.AddTransient<IActivityService, ActivityService>();

            return services;

        }

        private static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IDealerRepository, DealerRepository>();
            services.AddTransient<IShopRepository, ShopRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProfessionalRepository, ProfessionalRepository>();
            services.AddTransient<IActivityRepository, ActivityRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<ICategoriesRepository, CategoriesRepository>();
            services.AddTransient<ICalendaryRepository, CalendaryRepository>();
            services.AddTransient<IOpinionRepository, OpinionRepository>();

            return services;
        }

    }
}
