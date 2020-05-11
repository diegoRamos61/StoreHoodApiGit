using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Mappers
{
    public static class ShopMapper
    {
        public static ShopEntity Map(Shop dto)
        {
            return new ShopEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Mail = dto.Mail,
                Address = dto.Address,
                Telephone = dto.Telephone,
                Facebook = dto.Facebook,
                Instagram = dto.Instagram,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                DealerId = dto.IdDealer,
                CloseHour = dto.CloseHour,
                OpenHour = dto.OpenHour                
            //No pasaríamos entidades enteras, si no los ID de otras entidades.
            };
        }

        public static Shop Map(ShopEntity entity)
        {
            return new Shop()
            {
                Id = entity.Id,
                Name = entity.Name,
                Mail = entity.Mail,
                Address = entity.Address,
                Telephone = entity.Telephone,
                Facebook = entity.Facebook,
                Instagram = entity.Instagram,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                IdDealer = entity.DealerId,
                CloseHour = entity.CloseHour,
                OpenHour = entity.OpenHour                
            };
        }

        public static IEnumerable<Shop> MapAll(IEnumerable<ShopEntity> entityList)
        {
            List<Shop> shops = new List<Shop>();
            
            foreach (var shopEntity in entityList)
            {
                shops.Add(Map(shopEntity));
            }            

            return shops;
        }

        public static IEnumerable<ShopEntity> MapAll(IEnumerable<Shop> dtoList)
        {
            List<ShopEntity> shops = new List<ShopEntity>();

            foreach (var shopDto in dtoList)
            {
                shops.Add(Map(shopDto));
            }

            return shops;
        }

    }
}
