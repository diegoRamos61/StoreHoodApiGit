using System;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class CalendaryEntity
    {
        //Cargaremos en bbdd los distintos calendarios laborables de las ciudades.
        public DateTime Date { get; set; }        
        public bool Holiday { get; set; } 

    }
}