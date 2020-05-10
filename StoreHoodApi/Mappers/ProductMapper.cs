using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class ProductMapper
    {
        public static Product Map(ProductModel model)
        {
            return new Product()
            {
                Id = model.Id,
                Name = model.Name,
                Desc1 = model.Desc1,
                Desc2 = model.Desc2,
                Desc3 = model.Desc3,
                Desc4 = model.Desc4,
                Discount = model.Discount,
                DiscountAvaible = model.DiscountAvaible,
                Color = model.Color,
                Price = model.Price,
                Image = model.Image,
                Weight = model.Weight,
                Active = model.Active,
                Size = model.Size
            };
        }

        public static ProductModel Map(Product dto)
        {
            return new ProductModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Desc1 = dto.Desc1,
                Desc2 = dto.Desc2,
                Desc3 = dto.Desc3,
                Desc4 = dto.Desc4,
                Discount = dto.Discount,
                DiscountAvaible = dto.DiscountAvaible,
                Color = dto.Color,
                Price = dto.Price,
                Image = dto.Image,
                Weight = dto.Weight,
                Active = dto.Active,
                Size = dto.Size
            };
        }


    }
}
