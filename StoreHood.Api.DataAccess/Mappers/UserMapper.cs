using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Mappers
{
    public static class UserMapper
    {
        public static UserEntity Map(User dto)
        {
            return new UserEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname1 = dto.Surname1,
                Surname2 = dto.Surname2,
                Mail = dto.Mail,
                Address = dto.Address,
                City = dto.City,
                Province = dto.Province,
                Country = dto.Country,
                Active = dto.Active
            //No pasaríamos entidades enteras, si no los ID de otras entidades.
            };
        }

        public static User Map(UserEntity entity)
        {
            return new User()
            {
                Id = entity.Id,
                Name = entity.Name,
                Surname1 = entity.Surname1,
                Surname2 = entity.Surname2,
                Mail = entity.Mail,
                Address = entity.Address,
                City = entity.City,
                Province = entity.Province,
                Country = entity.Country,
                Active = entity.Active
                //No pasaríamos entidades enteras, si no los ID de otras entidades.
            };
        }

        public static IEnumerable<User> MapAll(IEnumerable<UserEntity> entityList)
        {
            List<User> users = new List<User>();
            
            foreach (var userEntity in entityList)
            {
                users.Add(Map(userEntity));
            }            

            return users;
        }

        public static IEnumerable<UserEntity> MapAll(IEnumerable<User> dtoList)
        {
            List<UserEntity> users = new List<UserEntity>();

            foreach (var userDto in dtoList)
            {
                users.Add(Map(userDto));
            }

            return users;
        }

    }
}
