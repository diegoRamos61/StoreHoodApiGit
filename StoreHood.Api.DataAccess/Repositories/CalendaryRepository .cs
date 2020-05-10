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
    public class CalendaryRepository : ICalendaryRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public CalendaryRepository(IStoreHoodDBContext calendaryRepository)
        {
            _storeHoodDBContext = calendaryRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<CalendaryEntity> Add(CalendaryEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Calendaries.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<CalendaryEntity> Update(CalendaryEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Calendaries.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }


        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CalendaryEntity> GetById(int idEntity)
        {                      
            var result = await _storeHoodDBContext.Calendaries.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<CalendaryEntity>> GetWhere(Expression<Func<CalendaryEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<CalendaryEntity>().Where(predicate).ToListAsync();
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
            var entityDelete = await _storeHoodDBContext.Calendaries.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Calendaries.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }

            return false;

        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CalendaryEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<CalendaryEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<CalendaryEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<CalendaryEntity, bool>> predicate)
            => _storeHoodDBContext.Set<CalendaryEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios
        
        #endregion

    }
}
