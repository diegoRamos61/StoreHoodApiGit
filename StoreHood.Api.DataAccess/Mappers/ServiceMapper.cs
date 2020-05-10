using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Mappers
{
    public static class ServiceMapper
    {
        public static ServiceEntity Map(Service dto)
        {
            return new ServiceEntity()
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

        public static Service Map(ServiceEntity entity)
        {
            return new Service()
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

        public static IEnumerable<Service> MapAll(IEnumerable<ServiceEntity> entityList)
        {
            List<Service> services = new List<Service>();
            
            foreach (var serviceEntity in entityList)
            {
                services.Add(Map(serviceEntity));
            }            

            return services;
        }

        public static IEnumerable<ServiceEntity> MapAll(IEnumerable<Service> dtoList)
        {
            List<ServiceEntity> services = new List<ServiceEntity>();

            foreach (var serviceDto in dtoList)
            {
                services.Add(Map(serviceDto));
            }

            return services;
        }

    }
}
