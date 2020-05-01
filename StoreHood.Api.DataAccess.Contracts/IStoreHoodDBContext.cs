using Microsoft.EntityFrameworkCore;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts
{
    public interface IStoreHoodDBContext
    {

        DbSet<UserEntity> Users { get; set; }
        DbSet<DealerEntity> Dealers { get; set; }
        DbSet<ShopEntity> Shops { get; set; }
        DbSet<ProductEntity> Products { get; set; }
        DbSet<CategoriesEntity> Categories { get; set; }
        DbSet<OpinionEntity> Opinions { get; set; }
        DbSet<ProfessionalEntity> Professionals { get; set; }
        DbSet<ActivityEntity> Activities { get; set; }
        DbSet<ServiceEntity> Services { get; set; }
        DbSet<CalendaryEntity> Calendaries { get; set; }
    }
}
