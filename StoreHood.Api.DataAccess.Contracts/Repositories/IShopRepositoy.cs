using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IShopRepository : IRepository<ShopEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
                
        //Actualizar calendario.
        Task<ShopEntity> UpdateCalendary(int idEntity, CalendaryEntity calendary);
        //Asignar otro comerciante como asignado a la tienda.
        Task<ShopEntity> UpdateDealer(int idEntity, DealerEntity dealer);
        //Asignar nuevos productos.
        Task<ShopEntity> AddProducts(int idEntity, ICollection<ProductEntity> products);
    }
}
