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
    public class ProductRepository : IProductRepository
    {
        //Montamos las operaciones CRUD.

        private readonly IStoreHoodDBContext _storeHoodDBContext;
        
        //Constructor
        public ProductRepository(IStoreHoodDBContext productRepository)
        {
            _storeHoodDBContext = productRepository;
        }

        #region Métodos genéricos.
        /// <summary>
        /// Método para añadir usuarios.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ProductEntity> Add(ProductEntity entity)
        {
            //Siempre que sea un task hay que utilizar un await, para que el hilo espere el resultado.
            await _storeHoodDBContext.Products.AddAsync(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }


        /// <summary>
        /// Actualización por objeto.  Devuelve el objeto actualizado.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ProductEntity> Update(ProductEntity entity)
        {
            var updateEntity = _storeHoodDBContext.Products.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }


        /// <summary>
        /// Actualización por id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ProductEntity> GetById(int idEntity)
        {
            //Podemos añadir más parámetros de filtro. Include + .ThenInclude...e ir filtrando por el resto de relaciones que tenga.
            //Por ejemplo será util cuando tengamos la relacion de usuario con tarjetas.
            var result = await _storeHoodDBContext.Products.FirstOrDefaultAsync(x => x.Id == idEntity);

            await _storeHoodDBContext.SaveChangesAsync();

            return result;
        }

        /// <summary>
        /// Obtener Usuarios por query por parámetro.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ProductEntity>> GetWhere(Expression<Func<ProductEntity, bool>> predicate)
        {
            return await _storeHoodDBContext.Set<ProductEntity>().Where(predicate).ToListAsync();
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
            var entityDelete = await _storeHoodDBContext.Products.SingleAsync(x => x.Id == idEntity);

            if (entityDelete != null)
            {
                _storeHoodDBContext.Products.Remove(entityDelete);

                await _storeHoodDBContext.SaveChangesAsync();

                return true;
            }
            return false;

        }

        /// <summary>
        /// Devolver todos los Usuarios.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            return await _storeHoodDBContext.Set<ProductEntity>().ToListAsync();
        }

        /// <summary>
        /// Contar todos los usuarios
        /// </summary>
        /// <returns></returns>
        public Task<int> CountAll() => _storeHoodDBContext.Set<ProductEntity>().CountAsync();

        /// <summary>
        /// Contador de usuarios por condición.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<int> CountWhere(Expression<Func<ProductEntity, bool>> predicate)
            => _storeHoodDBContext.Set<ProductEntity>().CountAsync(predicate);

        #endregion

        #region Métodos propios
               
        public async Task<ProductEntity> AddCategories(int idEntity, ICollection<CategoriesEntity> categories)
        {
            var entity = await GetById(idEntity);

            foreach (var category in categories)
            {
                entity.Categories.Add(category);
            }

            _storeHoodDBContext.Products.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ProductEntity> AddOpinions(int idEntity, ICollection<OpinionEntity> opinions)
        {
            var entity = await GetById(idEntity);

            foreach (var opinion in opinions)
            {
                entity.Opinions.Add(opinion);
            }

            _storeHoodDBContext.Products.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }


        public async Task<ProductEntity> UpdateShop(int idEntity, ShopEntity shop)
        {
            var entity = await GetById(idEntity);
            entity.Shop = shop;

            _storeHoodDBContext.Products.Update(entity);

            await _storeHoodDBContext.SaveChangesAsync();

            return entity;
        }

        #endregion

    }
}
