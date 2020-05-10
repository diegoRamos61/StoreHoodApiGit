using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class OpinionMapper
    {
        public static Opinion Map(OpinionModel model)
        {
            return new Opinion()
            {
                Id = model.Id,
                Description = model.Description,
                IdUser = model.Id,
                Rank = model.Rank                
            };
        }

        public static OpinionModel Map(Opinion dto)
        {
            return new OpinionModel()
            {
                Id = dto.Id,
                Description = dto.Description,
                IdUser = dto.Id,
                Rank = dto.Rank
            };
        }
    }
}
