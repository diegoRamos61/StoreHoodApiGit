﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class ActivityEntity
    {
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
        

        //Tendrá asociado un comerciante.
        public virtual ProfessionalEntity Professional { get; set; }
              
        //Tendrá una lista de categorias.
        public virtual ICollection<CategorieActEntity> Categories { get; set; }
        // Un calendario asociado de la provincia al que pertenezca
        public virtual CalendaryEntity Calendary { get; set; }

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}