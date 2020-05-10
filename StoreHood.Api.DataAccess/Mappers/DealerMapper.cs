using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;


namespace StoreHood.Api.DataAccess.Mappers
{
    public static class DealerMapper
    {
        public static DealerEntity Map(Dealer dto)
        {
            return new DealerEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Cif = dto.Cif,
                Mail = dto.Mail,
                Surname1 = dto.Surname1,
                Surname2 = dto.Surname2,                
                Active = dto.Active                               
            };
        }

        public static Dealer Map(DealerEntity entity)
        {
            return new Dealer()
            {
                Id = entity.Id,
                Name = entity.Name,
                Cif = entity.Cif,
                Mail = entity.Mail,
                Surname1 = entity.Surname1,
                Surname2 = entity.Surname2,
                Active = entity.Active
            };
        }

        public static IEnumerable<Dealer> MapAll(IEnumerable<DealerEntity> entityList)
        {
            List<Dealer> dealers = new List<Dealer>();
            
            foreach (var dealerEntity in entityList)
            {
                dealers.Add(Map(dealerEntity));
            }            

            return dealers;
        }

        public static IEnumerable<DealerEntity> MapAll(IEnumerable<Dealer> dtoList)
        {
            List<DealerEntity> dealers = new List<DealerEntity>();

            foreach (var dealerDto in dtoList)
            {
                dealers.Add(Map(dealerDto));
            }

            return dealers;
        }

    }
}
