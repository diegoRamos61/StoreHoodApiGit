using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<ProductEntity> UpdateShop(int idEntity, ShopEntity shop);
        Task<ProductEntity> AddCategories(int idEntity, ICollection<CategoriesEntity> categories);
        Task<ProductEntity> AddOpinions(int idEntity, ICollection<OpinionEntity> opinions);

    }
}
