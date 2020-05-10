using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IProfessionalRepository : IRepository<ProfessionalEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        Task<ProfessionalEntity> UpdateStatus(int idEntity, bool status);
        Task<ProfessionalEntity> UpdateMail(int idEntity, string mail);       
    }
}
