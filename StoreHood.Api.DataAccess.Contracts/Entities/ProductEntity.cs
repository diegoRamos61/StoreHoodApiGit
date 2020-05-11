using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class ProductEntity
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

        //Foreign keys
        public int ShopId { get; set; }

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }

        /* Navigation Properties
        * Un producto pertenece a una tienda.
        * Puede tener una o varias categorias.
        * Puedes tener una o varias opiniones.
        */

        public virtual ShopEntity Shop { get; set; }
        public virtual ICollection<CategoriesEntity> Categories { get; set; }
        public virtual ICollection<OpinionEntity> Opinions { get; set; }

    }
}

