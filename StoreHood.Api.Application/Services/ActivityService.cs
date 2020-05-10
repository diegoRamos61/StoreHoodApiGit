using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Repositories;
using StoreHood.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Services
{
    public class ActivityService : IActivityService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task<Activity> GetActivityId(int id)
        {
            var entidad = ActivityMapper.Map(await _activityRepository.GetById(id));

            return entidad;
        }

        public async Task<Activity> AddActivity(Activity activity)
        {
            var addedEntity = await _activityRepository.Add(ActivityMapper.Map(activity));

            return ActivityMapper.Map(addedEntity);
        }

        public async Task<Activity> UpdateActivity(Activity activity)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _activityRepository.Update(ActivityMapper.Map(activity));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return ActivityMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _activityRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Activity>> GetAll()
        {
            var allActivitys = await _activityRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allActivitys.Select(ActivityMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _activityRepository.CountAll();
            return countAll;
        }

    }
}
