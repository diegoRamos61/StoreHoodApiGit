using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
        public string Desc4 { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public bool Active { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Discount { get; set; }
        public bool DiscountAvaible { get; set; }
        public byte[] Image { get; set; }

        /* Podemos tener entidades necesarias en la entidad de negocio.
         * Desde los services nos pediran los entitys, pero para ello tendremos los mappers, que será lo que utilicemos desde el service
        */

    }
}
