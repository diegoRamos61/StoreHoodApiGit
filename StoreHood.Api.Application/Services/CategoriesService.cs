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
    public class CategoriesService : ICategoriesService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public async Task<Categories> GetCategoriesId(int id)
        {
            var entidad = CategoriesMapper.Map(await _categoriesRepository.GetById(id));

            return entidad;
        }

        public async Task<Categories> AddCategories(Categories categories)
        {
            var addedEntity = await _categoriesRepository.Add(CategoriesMapper.Map(categories));

            return CategoriesMapper.Map(addedEntity);
        }

        public async Task<Categories> UpdateCategories(Categories categories)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _categoriesRepository.Update(CategoriesMapper.Map(categories));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return CategoriesMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _categoriesRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Categories>> GetAll()
        {
            var allCategoriess = await _categoriesRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allCategoriess.Select(CategoriesMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _categoriesRepository.CountAll();
            return countAll;
        }

    }
}
