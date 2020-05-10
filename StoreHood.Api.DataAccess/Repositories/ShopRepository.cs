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
    public class ShopRepository : IShopRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public ShopRepository(IStoreHoodDBContext shopRepository)
        {
            _storeHoodDBContext = shopRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ShopEntity> Add(ShopEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Shops.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;

        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ShopEntity> Update(ShopEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Shops.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }


        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ShopEntity> GetById(int idEntity)
        {
            //Podemos añadir más parámetros de filtro. Include + .ThenInclude...e ir filtrando por el resto de relaciones que tenga.
            //Por ejemplo será util cuando tengamos la relacion de usuario con tarjetas.
            var result = await _storeHoodDBContext.Shops.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ShopEntity>> GetWhere(Expression<Func<ShopEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<ShopEntity>().Where(predicate).ToListAsync();
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
            var entityDelete = await _storeHoodDBContext.Shops.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Shops.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }
            return false;
        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShopEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<ShopEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<ShopEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<ShopEntity, bool>> predicate)
            => _storeHoodDBContext.Set<ShopEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios
  
        public async Task<ShopEntity> UpdateCalendary(int idEntity, CalendaryEntity calendary)
        {
            var entity = await GetById(idEntity);
            
            entity.Calendary = calendary;
            entity.IdCalendary = calendary.Id;

            return entity;
        }

        public async Task<ShopEntity> UpdateDealer(int idEntity, DealerEntity dealer)
        {
            var entity = await GetById(idEntity);

            entity.Dealer = dealer;
            entity.IdDealer = dealer.Id;

            return entity;
        }

        public async Task<ShopEntity> AddProducts(int idEntity, ICollection<ProductEntity> products)
        {
            var entity = await GetById(idEntity);

            foreach (var product in products)
            {
                entity.Products.Add(product);
            }

            _storeHoodDBContext.Shops.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }
        #endregion

    }
}
