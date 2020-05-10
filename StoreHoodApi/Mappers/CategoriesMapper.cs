using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class CategoriesMapper
    {
        public static Categories Map(CategoriesModel model)
        {
            return new Categories()
            {
                Id = model.Id,
                Name = model.Name,
                Active = model.Active              
            };
        }

        public static CategoriesModel Map(Categories dto)
        {
            return new CategoriesModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Active = dto.Active
            };
        }

    }
}
