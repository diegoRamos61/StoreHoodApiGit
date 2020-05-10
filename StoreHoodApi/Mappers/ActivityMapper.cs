using StoreHood.Api.Business.Models;
using StoreHood.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace StoreHood.Api.Mappers
{
    public static class ActivityMapper
    {
        public static Activity Map(ActivityModel model)
        {
            return new Activity()
            {
                Id = model.Id,
                Name = model.Name,
                Address = model.Address,
                CloseHour = model.CloseHour,
                Desc1 = model.Desc1,
                Desc2 = model.Desc2,
                Desc3 = model.Desc3,
                Desc4 = model.Desc4,
                Facebook = model.Facebook,
                Instagram = model.Instagram,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Mail = model.Mail,
                OpenHour = model.OpenHour,
                Telephone  = model.Telephone                
            };
        }

        public static ActivityModel Map(Activity dto)
        {
            return new ActivityModel()
            {
                Id = dto.Id,
                Name = dto.Name,
                Address = dto.Address,
                CloseHour = dto.CloseHour,
                Desc1 = dto.Desc1,
                Desc2 = dto.Desc2,
                Desc3 = dto.Desc3,
                Desc4 = dto.Desc4,
                Facebook = dto.Facebook,
                Instagram = dto.Instagram,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                Mail = dto.Mail,
                OpenHour = dto.OpenHour,
                Telephone = dto.Telephone
            };
        }

    }
}
