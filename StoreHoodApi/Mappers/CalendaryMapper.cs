using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class CalendaryMapper
    {
        public static Calendary Map(CalendaryModel model)
        {
            return new Calendary()
            {
                Id = model.Id,
                Date = model.Date,
                Holiday = model.Holiday
            };
        }

        public static CalendaryModel Map(Calendary dto)
        {
            return new CalendaryModel()
            {
                Id = dto.Id,
                Date = dto.Date,
                Holiday = dto.Holiday
            };
        }
    }
}
