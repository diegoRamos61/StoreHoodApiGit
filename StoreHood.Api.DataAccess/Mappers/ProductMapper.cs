using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;


namespace StoreHood.Api.DataAccess.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity Map(Product dto)
        {
            return new ProductEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Desc1 = dto.Desc1,
                Desc2 = dto.Desc2,
                Desc3 = dto.Desc3,
                Desc4 = dto.Desc4,
                Discount = dto.Discount,
                Price = dto.Price,
                Active = dto.Active,
                Image = dto.Image,
                DiscountAvaible = dto.DiscountAvaible     
            };
        }

        public static Product Map(ProductEntity entity)
        {
            return new Product()
            {
                Id = entity.Id,
                Name = entity.Name,
                Desc1 = entity.Desc1,
                Desc2 = entity.Desc2,
                Desc3 = entity.Desc3,
                Desc4 = entity.Desc4,
                Discount = entity.Discount,
                Price = entity.Price,
                Active = entity.Active,
                Image = entity.Image,
                DiscountAvaible = entity.DiscountAvaible                             
            };
        }

        public static IEnumerable<Product> MapAll(IEnumerable<ProductEntity> entityList)
        {
            List<Product> products = new List<Product>();
            
            foreach (var productEntity in entityList)
            {
                products.Add(Map(productEntity));
            }            

            return products;
        }

        public static IEnumerable<ProductEntity> MapAll(IEnumerable<Product> dtoList)
        {
            List<ProductEntity> products = new List<ProductEntity>();

            foreach (var productDto in dtoList)
            {
                products.Add(Map(productDto));
            }

            return products;
        }

    }
}
