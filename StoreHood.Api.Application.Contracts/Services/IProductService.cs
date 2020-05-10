using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IProductService
    {
        Task<Product> GetProductId(int id);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<bool> Delete(int id);
        Task<IEnumerable<Product>> GetAll();
        Task<int> CountAll();
    }
}
