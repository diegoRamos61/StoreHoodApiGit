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
    public class OpinionRepository : IOpinionRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public OpinionRepository(IStoreHoodDBContext opinionRepository)
        {
            _storeHoodDBContext = opinionRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<OpinionEntity> Add(OpinionEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Opinions.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();
            
            return entity;
        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<OpinionEntity> Update(OpinionEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Opinions.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }


        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<OpinionEntity> GetById(int idEntity)
        {
            //Podemos añadir más parámetros de filtro. Include + .ThenInclude...e ir filtrando por el resto de relaciones que tenga.
            //Por ejemplo será util cuando tengamos la relacion de usuario con tarjetas.
            var result = await _storeHoodDBContext.Opinions.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OpinionEntity>> GetWhere(Expression<Func<OpinionEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<OpinionEntity>().Where(predicate).ToListAsync();
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
            var entityDelete = await _storeHoodDBContext.Opinions.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Opinions.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OpinionEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<OpinionEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<OpinionEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<OpinionEntity, bool>> predicate)
            => _storeHoodDBContext.Set<OpinionEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios
  
        public async Task<OpinionEntity> UpdateCommentary(int idEntity, string commentary)
        {
            var entity = await GetById(idEntity);
            
            entity.Description = commentary;           

            return entity;
        }

        public async Task<OpinionEntity> UpdateRank(int idEntity, int rank)
        {
            var entity = await GetById(idEntity);

            entity.Rank = rank;     

            return entity;
        }

        #endregion

    }
}
