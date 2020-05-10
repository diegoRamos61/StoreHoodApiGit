using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class DealerMapper
    {
        public static Dealer Map(DealerModel model)
        {
            return new Dealer()
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

        public static DealerModel Map(Dealer model)
        {
            return new DealerModel()
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
    }
}
