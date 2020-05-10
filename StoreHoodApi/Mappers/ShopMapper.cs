using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class ShopMapper
    {
        public static Shop Map(ShopModel model)
        {
            return new Shop()
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                CloseHour = model.CloseHour,
                Facebook = model.Facebook,
                Instagram = model.Instagram,
                Mail = model.Mail,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                OpenHour = model.OpenHour,
                Telephone = model.Telephone,
                IdCalendary = model.IdCalendary,
                IdDealer = model.IdDealer
            };    
        }

        public static ShopModel Map(Shop dto)
        {
            return new ShopModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Address = dto.Address,
                CloseHour = dto.CloseHour,
                Facebook = dto.Facebook,
                Instagram = dto.Instagram,
                Mail = dto.Mail,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                OpenHour = dto.OpenHour,
                Telephone = dto.Telephone,
                IdCalendary = dto.IdCalendary,
                IdDealer = dto.IdDealer
            };
        }
    }
}
