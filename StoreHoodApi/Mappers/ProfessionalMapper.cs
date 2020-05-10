using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class ProfessionalMapper
    {
        public static Professional Map(ProfessionalModel model)
        {
            return new Professional()
            {
                Id = model.Id,
                Name = model.Name,
                Surname1 = model.Surname1,
                Surname2 = model.Surname2,
                Mail = model.Mail,
                Active = model.Active,
                Cif = model.Cif 
            };
        }


        public static ProfessionalModel Map(Professional dto)
        {
            return new ProfessionalModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname1 = dto.Surname1,
                Surname2 = dto.Surname2,
                Mail = dto.Mail,
                Active = dto.Active,
                Cif = dto.Cif
            };
        }

    }
}
