using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreHood.Api.DataAccess.Contracts;
using StoreHood.Api.DataAccess.Contracts.Entities;
using StoreHood.Api.DataAccess.EntityConfig;
using System;
using System.IO;

namespace StoreHood.Api.DataAccess
{
    public class StoreHoodDBContext: DbContext, IStoreHoodDBContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<DealerEntity> Dealers { get; set; }
        public DbSet<ShopEntity> Shops { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoriesEntity> Categories { get; set; }
        public DbSet<OpinionEntity> Opinions { get; set; }        
        public DbSet<ProfessionalEntity> Professionals { get; set; }
        public DbSet<ActivityEntity> Activities { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<CalendaryEntity> Calendaries { get; set; }

        //Para poder instanciar el contexto
        // public StoreHoodDBContext(DbContextOptions options) : base(options) {  }
        public StoreHoodDBContext(DbContextOptions<StoreHoodDBContext> options) : base(options) { }

        //Constructor por defecto.
        public StoreHoodDBContext() 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //Sustituir por Configuration string y así lo coge del APPSETINGS.
            builder.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=StoreHood;Trusted_Connection=True;");
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            DealerEntityConfig.SetEntityBuilder(modelBuilder.Entity<DealerEntity>());
            ShopEntityConfig.SetEntityBuilder(modelBuilder.Entity<ShopEntity>());
            ProductEntityConfig.SetEntityBuilder(modelBuilder.Entity<ProductEntity>());
            OpinionEntityConfig.SetEntityBuilder(modelBuilder.Entity<OpinionEntity>());
            CategoriesEntityConfig.SetEntityBuilder(modelBuilder.Entity<CategoriesEntity>());
            ProfessionalEntityConfig.SetEntityBuilder(modelBuilder.Entity<ProfessionalEntity>());
            ActivityEntityConfig.SetEntityBuilder(modelBuilder.Entity<ActivityEntity>());
            ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServiceEntity>());
            CalendaryEntityConfig.SetEntityBuilder(modelBuilder.Entity<CalendaryEntity>());

            base.OnModelCreating(modelBuilder);
        }

    }
}
