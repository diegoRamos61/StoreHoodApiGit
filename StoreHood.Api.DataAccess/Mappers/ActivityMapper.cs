using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;


namespace StoreHood.Api.DataAccess.Mappers
{
    public static class ActivityMapper
    {
        public static ActivityEntity Map(Activity dto)
        {
            return new ActivityEntity()
            {                
                Id = dto.Id,
                Address = dto.Address,
                CloseHour = dto.CloseHour,
                Desc1 = dto.Desc1,
                Desc2 = dto.Desc2,
                Desc3 = dto.Desc3,
                Desc4 = dto.Desc4,
                Facebook = dto.Facebook,
                Instagram = dto.Instagram,
                CalendaryId = dto.IdCalendary,
                ProfessionalId = dto.IdProfessional,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                Mail = dto.Mail,
                Name = dto.Name,
                OpenHour = dto.OpenHour,
                Telephone = dto.Telephone                

            };
        }

        public static Activity Map(ActivityEntity entity)
        {
            return new Activity()
            {
                Id = entity.Id,
                Address = entity.Address,
                CloseHour = entity.CloseHour,
                Desc1 = entity.Desc1,
                Desc2 = entity.Desc2,
                Desc3 = entity.Desc3,
                Desc4 = entity.Desc4,
                Facebook = entity.Facebook,
                Instagram = entity.Instagram,
                //IdCalendary = entity.CalendaryId,
                IdCalendary = entity.Calendary.Id,
                IdProfessional = entity.ProfessionalId,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                Mail = entity.Mail,
                Name = entity.Name,
                OpenHour = entity.OpenHour,
                Telephone = entity.Telephone
            };
        }

        public static IEnumerable<Activity> MapAll(IEnumerable<ActivityEntity> entityList)
        {
            List<Activity> activities = new List<Activity>();
            
            foreach (var activityEntity in entityList)
            {
                activities.Add(Map(activityEntity));
            }            

            return activities;
        }

        public static IEnumerable<ActivityEntity> MapAll(IEnumerable<Activity> dtoList)
        {
            List<ActivityEntity> activities = new List<ActivityEntity>();

            foreach (var activitiesDto in dtoList)
            {
                activities.Add(Map(activitiesDto));
            }

            return activities;
        }

    }
}
