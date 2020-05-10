using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Shop
    {
        //Lógica de negocio de la entidad shop.
        public int Id { get; set; }
        public string Name { get; set; }
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

        public int IdDealer { get; set; }
        public int IdCalendary { get; set; }

        /* Podemos tener entidades necesarias en la entidad de negocio.
         * Desde los services nos pediran los entitys, pero para ello tendremos los mappers, que será lo que utilicemos desde el service
        */

    }
}
