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
    public class CategoriesRepository : ICategoriesRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public CategoriesRepository(IStoreHoodDBContext categoriesRepository)
        {
            _storeHoodDBContext = categoriesRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<CategoriesEntity> Add(CategoriesEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Categories.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<CategoriesEntity> Update(CategoriesEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Categories.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoriesEntity> GetById(int idEntity)
        {
            //Podemos añadir más parámetros de filtro. Include + .ThenInclude...e ir filtrando por el resto de relaciones que tenga.
            //Por ejemplo será util cuando tengamos la relacion de usuario con tarjetas.
            var result = await _storeHoodDBContext.Categories.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<CategoriesEntity>> GetWhere(Expression<Func<CategoriesEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<CategoriesEntity>().Where(predicate).ToListAsync();
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
            var entityDelete = await _storeHoodDBContext.Categories.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Categories.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CategoriesEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<CategoriesEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<CategoriesEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<CategoriesEntity, bool>> predicate)
            => _storeHoodDBContext.Set<CategoriesEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios

        
        public async Task<CategoriesEntity> UpdateStatus(int idEntity, bool status)
        {
            var entity = await GetById(idEntity);
            entity.Active = status;
            
            _storeHoodDBContext.Categories.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }
       
        #endregion
    }
}
