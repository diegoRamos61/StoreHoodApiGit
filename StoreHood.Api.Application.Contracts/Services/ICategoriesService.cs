using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface ICategoriesService
    {
        Task<Categories> GetCategoriesId(int id);
        Task<Categories> AddCategories(Categories categories);
        Task<Categories> UpdateCategories(Categories categories);
        Task<bool> Delete(int id);
        Task<IEnumerable<Categories>> GetAll();
        Task<int> CountAll();
    }
}
