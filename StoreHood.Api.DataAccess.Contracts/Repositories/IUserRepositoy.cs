using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<UserEntity> UpdateNameSurname(int idEntity, string name, string surname1, string surname2);
    }
}
