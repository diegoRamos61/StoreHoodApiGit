using System;
using System.Collections;
using System.Collections.Generic;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class CalendaryEntity
    {
        //Cargaremos en bbdd los distintos calendarios laborables de las ciudades.
        public int Id { get; set; }
        public DateTime Date { get; set; }        
        public bool Holiday { get; set; } 
        public virtual ICollection<ShopEntity> Shops { get; set; }
        public virtual ICollection<ActivityEntity> Activities { get; set; }

    }
}