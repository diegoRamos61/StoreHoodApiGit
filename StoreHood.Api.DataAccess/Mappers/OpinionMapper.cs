using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;


namespace StoreHood.Api.DataAccess.Mappers
{
    public static class OpinionMapper
    {
        public static OpinionEntity Map(Opinion dto)
        {
            return new OpinionEntity()
            {
                Id = dto.Id,
                Description = dto.Description,
                Rank = dto.Rank,
                UserId = dto.IdUser                
            };
        }

        public static Opinion Map(OpinionEntity entity)
        {
            return new Opinion()
            {
                Id = entity.Id,
                Description = entity.Description,
                Rank = entity.Rank,
                IdUser = entity.UserId
            };
        }

        public static IEnumerable<Opinion> MapAll(IEnumerable<OpinionEntity> entityList)
        {
            List<Opinion> opinions = new List<Opinion>();
            
            foreach (var opinionEntity in entityList)
            {
                opinions.Add(Map(opinionEntity));
            }            

            return opinions;
        }

        public static IEnumerable<OpinionEntity> MapAll(IEnumerable<Opinion> dtoList)
        {
            List<OpinionEntity> opinions = new List<OpinionEntity>();

            foreach (var opinionDto in dtoList)
            {
                opinions.Add(Map(opinionDto));
            }

            return opinions;
        }

    }
}
