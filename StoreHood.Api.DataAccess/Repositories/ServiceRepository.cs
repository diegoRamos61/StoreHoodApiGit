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
    public class ServiceRepository : IServiceRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public ServiceRepository(IStoreHoodDBContext serviceRepository)
        {
            _storeHoodDBContext = serviceRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ServiceEntity> Add(ServiceEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Services.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ServiceEntity> Update(ServiceEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Services.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }


        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceEntity> GetById(int idEntity)
        {
            //Podemos añadir más parámetros de filtro. Include + .ThenInclude...e ir filtrando por el resto de relaciones que tenga.
            //Por ejemplo será util cuando tengamos la relacion de usuario con tarjetas.
            var result = await _storeHoodDBContext.Services.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ServiceEntity>> GetWhere(Expression<Func<ServiceEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<ServiceEntity>().Where(predicate).ToListAsync();
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
            var entityDelete = await _storeHoodDBContext.Services.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Services.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }
            return false;
        }
    

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ServiceEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<ServiceEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<ServiceEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<ServiceEntity, bool>> predicate)
            => _storeHoodDBContext.Set<ServiceEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios

        public async Task<ServiceEntity> AddCategories(int idEntity, ICollection<CategoriesEntity> categories)
        {
            var entity = await GetById(idEntity);

            foreach (var category in categories)
            {
                entity.Categories.Add(category);
            }

            _storeHoodDBContext.Services.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ServiceEntity> AddOpinions(int idEntity, ICollection<OpinionEntity> opinions)
        {
            var entity = await GetById(idEntity);

            foreach (var opinion in opinions)
            {
                entity.Opinions.Add(opinion);
            }

            _storeHoodDBContext.Services.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ServiceEntity> UpdateActivity(int idEntity, ActivityEntity activity)
        {
            var entity = await GetById(idEntity);
            entity.Activity = activity;

            _storeHoodDBContext.Services.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        #endregion

    }
}
