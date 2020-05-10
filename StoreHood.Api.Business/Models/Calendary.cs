using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Calendary
    {
        //Lógica de negocio de la entidad Categories.
        // Tendremos las propiedadas de nuestra entidad.
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Holiday { get; set; }

    }
}
