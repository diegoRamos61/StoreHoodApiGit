using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class ShopEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpenHour { get; set; }
        public string CloseHour { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        //Info para google maps, dirección, latitud y longitud
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
       
        //Info rrss       
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        
        //Foreign Key
        public int DealerId { get; set; }
        public int? CalendaryId { get; set; }

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }

        /* Navigation Properties
         * Una tienda pertenece a un único comerciante.
         * Una tienda tendrá 0 o muchos productos.
         * Una tienda tendrá un calendario asociado. (Puede ser nullable)
         */
      
        public virtual DealerEntity Dealer { get; set; }      
        public virtual CalendaryEntity Calendary { get; set; }      
        public virtual ICollection<ProductEntity> Products { get; set; }

    }
}
