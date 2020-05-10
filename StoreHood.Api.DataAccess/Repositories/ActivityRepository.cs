using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreHood.Api.DataAccess.Contracts;
using StoreHood.Api.DataAccess.Contracts.Entities;
using StoreHood.Api.DataAccess.Contracts.Repositories;

namespace StoreHood.Api.DataAccess.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public ActivityRepository(IStoreHoodDBContext ActivitiesRepository)
        {
            _storeHoodDBContext = ActivitiesRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ActivityEntity> Add(ActivityEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Activities.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();
            
            return entity;
        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ActivityEntity> Update(ActivityEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Activities.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }


        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActivityEntity> GetById(int idEntity)
        {                      
            var result = await _storeHoodDBContext.Activities.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ActivityEntity>> GetWhere(Expression<Func<ActivityEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<ActivityEntity>().Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Método para eliminar usuarios.
        /// </summary>
        /// <param name="idEntity"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int idEntity)
        {
            //var entity = await Get(idEntity);
            //Podemos hacer el get o single, lo mismo es. Por variar..
            var entityDelete = await _storeHoodDBContext.Activities.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Activities.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ActivityEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<ActivityEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<ActivityEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<ActivityEntity, bool>> predicate)
            => _storeHoodDBContext.Set<ActivityEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios
        public async Task<ActivityEntity> UpdateProfessional(int idEntity, ProfessionalEntity professional)
        {
            var entity = await GetById(idEntity);
            entity.Professional = professional;

            _storeHoodDBContext.Activities.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ActivityEntity> UpdateCalendary(int idEntity, CalendaryEntity calendary)
        {
            var entity = await GetById(idEntity);

            entity.Calendary = calendary;
            entity.IdCalendary = calendary.Id;

            _storeHoodDBContext.Activities.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }


        public async Task<ActivityEntity> AddServices(int idEntity, ICollection<ServiceEntity> services)
        {
            var entity = await GetById(idEntity);

            foreach (var service in services)
            {
                entity.Services.Add(service);
            }

            _storeHoodDBContext.Activities.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ActivityEntity> AddOpinions(int idEntity, ICollection<OpinionEntity> opinions)
        {
            var entity = await GetById(idEntity);

            foreach (var opinion in opinions)
            {
                entity.Opinions.Add(opinion);
            }

            _storeHoodDBContext.Activities.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ActivityEntity> AddCategories(int idEntity, ICollection<CategoriesEntity> categories)
        {
            var entity = await GetById(idEntity);

            foreach (var category in categories)
            {
                entity.Categories.Add(category);
            }

            _storeHoodDBContext.Activities.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        #endregion

    }
}
