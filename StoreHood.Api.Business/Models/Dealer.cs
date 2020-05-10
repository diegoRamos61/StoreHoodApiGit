using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Dealer
    {
        //Lógica de negocio de la entidad Dealer.
        // Tendremos las propiedadas de nuestra entidad.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Cif { get; set; }
        public string Mail { get; set; }
        public bool Active { get; set; }

    }
}
