using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Professional
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Cif { get; set; }
        public string Mail { get; set; }
        public bool Active { get; set; }

        /* Podemos tener entidades necesarias en la entidad de negocio.
         * Desde los services nos pediran los entitys, pero para ello tendremos los mappers, que será lo que utilicemos desde el service
        */

    }
}
