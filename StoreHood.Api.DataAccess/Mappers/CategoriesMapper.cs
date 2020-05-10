using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;


namespace StoreHood.Api.DataAccess.Mappers
{
    public static class CategoriesMapper
    {
        public static CategoriesEntity Map(Categories dto)
        {
            return new CategoriesEntity()
            {
                Id = dto.Id,
                Name = dto.Name,                    
                Active = dto.Active                
            };
        }

        public static Categories Map(CategoriesEntity entity)
        {
            return new Categories()
            {
                Id = entity.Id,
                Name = entity.Name,
                Active = entity.Active
            };
        }

        public static IEnumerable<Categories> MapAll(IEnumerable<CategoriesEntity> entityList)
        {
            List<Categories> categories = new List<Categories>();
            
            foreach (var categoriesEntity in entityList)
            {
                categories.Add(Map(categoriesEntity));
            }            

            return categories;
        }

        public static IEnumerable<CategoriesEntity> MapAll(IEnumerable<Categories> dtoList)
        {
            List<CategoriesEntity> categories = new List<CategoriesEntity>();

            foreach (var categoriesDto in dtoList)
            {
                categories.Add(Map(categoriesDto));
            }

            return categories;
        }

    }
}
