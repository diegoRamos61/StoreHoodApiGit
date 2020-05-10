using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Primitives;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        //Operaciones que realiza el contexto.
        //No hace falta definirlo en la clase de mi contexto por sobreescribe lo heredado de DBContext
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);

    }
}
