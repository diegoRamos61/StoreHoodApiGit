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
    public class UserRepository : IUserRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public UserRepository(IStoreHoodDBContext userRepository)
        {
            _storeHoodDBContext = userRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<UserEntity> Add(UserEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Users.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;

        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<UserEntity> Update(UserEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Users.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserEntity> GetById(int idEntity)
        {
            //Podemos añadir más parámetros de filtro. Include + .ThenInclude...e ir filtrando por el resto de relaciones que tenga.
            //Por ejemplo será util cuando tengamos la relacion de usuario con tarjetas.
            var result = await _storeHoodDBContext.Users.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<UserEntity>> GetWhere(Expression<Func<UserEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<UserEntity>().Where(predicate).ToListAsync();
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
            try
            {
                var entityDelete = await _storeHoodDBContext.Users.SingleAsync(x => x.Id == idEntity);

                if (entityDelete != null)
                {
                    _storeHoodDBContext.Users.Remove(entityDelete);
                    await _storeHoodDBContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UserEntity>> GetAll()
        {           
            return await _storeHoodDBContext.Set<UserEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<UserEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<UserEntity, bool>> predicate)
            => _storeHoodDBContext.Set<UserEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios

        /// <summary>
        /// Actualización por id. Le pasaríamos los campos que queríamos que se actualicen. Podemos hacer diferentes métodos de update ID
        /// </summary>
        /// <param name="idEntity"></param>
        /// <param name="name"></param>
        /// <param name="surname1"></param>
        /// <param name="surname2"></param>
        /// <returns></returns>
        public async Task<UserEntity> UpdateNameSurname(int idEntity, string name, string surname1, string surname2)
        {

            var entity = await GetById(idEntity);
            entity.Name = name;
            entity.Surname1 = surname1;
            entity.Surname2 = surname2;

            _storeHoodDBContext.Users.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        #endregion
    }
}
