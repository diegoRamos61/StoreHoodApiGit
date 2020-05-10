using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Activity
    {
        //Lógica de negocio de la entidad Activity.
        // Tendremos las propiedadas de nuestra entidad.
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

        public int IdProfessional { get; set; }
        public int IdCalendary { get; set; }

    }
}
