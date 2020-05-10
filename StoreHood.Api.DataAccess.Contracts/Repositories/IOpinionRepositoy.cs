using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IOpinionRepository : IRepository<OpinionEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<OpinionEntity> UpdateCommentary(int idEntity, string commentary);
        Task<OpinionEntity> UpdateRank(int idEntity, int rank);
    }
}
