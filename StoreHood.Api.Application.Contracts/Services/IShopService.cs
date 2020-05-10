using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IShopService
    {
        Task<Shop> GetShopId(int id);
        Task<Shop> AddShop(Shop shop);
        Task<Shop> UpdateShop(Shop shop);
        Task<bool> Delete(int id);
        Task<IEnumerable<Shop>> GetAll();
        Task<int> CountAll();

    }
}
