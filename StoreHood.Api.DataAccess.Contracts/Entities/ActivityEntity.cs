using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class ActivityEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
        public string Desc4 { get; set; }
        //Info para google maps, dirección, latitud y longitud
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string OpenHour { get; set; }
        public string CloseHour { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        
        //Foreing key.
        public int ProfessionalId { get; set; }
        public int? CalendaryId { get; set; }

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }


        /* Navigation Properties
         * Una Actividad pertenece a un único profesional.
         * Una professional tendrá 0 o muchas actividades que desarrollar.
         * Una actividad tendrá un calendario asociado. (Puede ser nullable)
         */

        //Tendrá asociado un profesional.
        public virtual ProfessionalEntity Professional { get; set; }
        public virtual CalendaryEntity Calendary { get; set; }
        public virtual ICollection<ServiceEntity> Services { get; set; }
       
    }
}
