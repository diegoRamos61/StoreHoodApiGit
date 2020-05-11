using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IActivityRepository : IRepository<ActivityEntity>
    {
        //Iremos implementado en cada interfaz los métodos propios de cada entity
        //Task<ActivityEntity> AddServices(int idEntity, ICollection<ServiceEntity> services);
        //Task<ActivityEntity> AddOpinions(int idEntity, ICollection<OpinionEntity> opinions);
        //Task<ActivityEntity> AddCategories(int idEntity, ICollection<CategoriesEntity> categories);
        Task<ActivityEntity> UpdateCalendary(int idEntity, CalendaryEntity calendary);
        Task<ActivityEntity> UpdateProfessional(int idEntity, ProfessionalEntity professional);

    }
}
