using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;


namespace StoreHood.Api.DataAccess.Mappers
{
    public static class CalendaryMapper
    {
        public static CalendaryEntity Map(Calendary dto)
        {
            return new CalendaryEntity()
            {
                Date = dto.Date,
                Holiday = dto.Holiday,
                Id = dto.Id
            };
        }

        public static Calendary Map(CalendaryEntity entity)
        {
            return new Calendary()
            {
                Date = entity.Date,
                Holiday = entity.Holiday,
                Id = entity.Id               
            };
        }

        public static IEnumerable<Calendary> MapAll(IEnumerable<CalendaryEntity> entityList)
        {
            List<Calendary> calendaries = new List<Calendary>();
            
            foreach (var calendaryEntity in entityList)
            {
                calendaries.Add(Map(calendaryEntity));
            }            

            return calendaries;
        }

        public static IEnumerable<CalendaryEntity> MapAll(IEnumerable<Calendary> dtoList)
        {
            List<CalendaryEntity> calendaries = new List<CalendaryEntity>();

            foreach (var calendaryDto in dtoList)
            {
                calendaries.Add(Map(calendaryDto));
            }

            return calendaries;
        }

    }
}
