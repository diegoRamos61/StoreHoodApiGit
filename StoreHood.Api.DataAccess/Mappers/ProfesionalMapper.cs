using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;
using System.Xml;

namespace StoreHood.Api.DataAccess.Mappers
{
    public static class ProfessionalMapper
    {
        public static ProfessionalEntity Map(Professional dto)
        {
            return new ProfessionalEntity()
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

        public static Professional Map(ProfessionalEntity entity)
        {
            return new Professional()
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

        public static IEnumerable<Professional> MapAll(IEnumerable<ProfessionalEntity> entityList)
        {
            List<Professional> professional = new List<Professional>();
            
            foreach (var professionalEntity in entityList)
            {
                professional.Add(Map(professionalEntity));
            }            

            return professional;
        }

        public static IEnumerable<ProfessionalEntity> MapAll(IEnumerable<Professional> dtoList)
        {
            List<ProfessionalEntity> professional = new List<ProfessionalEntity>();

            foreach (var professionaltDto in dtoList)
            {
                professional.Add(Map(professionaltDto));
            }

            return professional;
        }

    }
}
