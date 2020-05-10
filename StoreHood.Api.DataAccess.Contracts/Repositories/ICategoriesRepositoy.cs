using Microsoft.EntityFrameworkCore.Internal;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface ICategoriesRepository : IRepository<CategoriesEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<CategoriesEntity> UpdateStatus(int idEntity, bool status);
                
    }
}
