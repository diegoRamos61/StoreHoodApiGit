using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IDealerRepository : IRepository<DealerEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<DealerEntity> UpdateMail(int idEntity, string mail);

        //Añadir tiendas al comerciante.
        Task<DealerEntity> AddShops(int idEntity, ICollection<ShopEntity> shops);
    }
}
