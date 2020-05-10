using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class UserMapper
    {
        public static UserModel Map(User dto)
        {
            return new UserModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname1 = dto.Surname1,
                Surname2 = dto.Surname2,
                Mail = dto.Mail,
                Address = dto.Address,
                City = dto.City,
                Active = dto.Active,
                Country = dto.Country,
                Province = dto.Province
            };
        }
        public static User Map(UserModel model)
        {
            return new User()
            {
                Id = model.Id,
                Name = model.Name,
                Surname1 = model.Surname1,
                Surname2 = model.Surname2,
                Mail = model.Mail,
                Address = model.Address,
                City = model.City,
                Active = model.Active,
                Country = model.Country,
                Province = model.Province
            };
        }
    }
}
