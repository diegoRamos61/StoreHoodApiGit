using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IServiceRepository : IRepository<ServiceEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<ServiceEntity> UpdateActivity(int idEntity, ActivityEntity activity);
        Task<ServiceEntity> AddCategories(int idEntity, ICollection<CategoriesEntity> categories);
        Task<ServiceEntity> AddOpinions(int idEntity, ICollection<OpinionEntity> opinions);
    }
}
