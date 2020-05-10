using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class ServiceMapper
    {
        public static Service Map(ServiceModel model)
        {
            return new Service()
            {
                Id = model.Id,
                Name = model.Name,
                Desc1 = model.Desc1,
                Desc2 = model.Desc2,
                Desc3 = model.Desc3,
                Desc4 = model.Desc4,
                Discount = model.Discount,
                DiscountAvaible = model.DiscountAvaible,
                Image = model.Image,
                Price = model.Price,
                Active = model.Active                
            };
        }

        public static ServiceModel Map(Service dto)
        {
            return new ServiceModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Desc1 = dto.Desc1,
                Desc2 = dto.Desc2,
                Desc3 = dto.Desc3,
                Desc4 = dto.Desc4,
                Discount = dto.Discount,
                DiscountAvaible = dto.DiscountAvaible,
                Image = dto.Image,
                Price = dto.Price,
                Active = dto.Active
            };
        }

    }
}
