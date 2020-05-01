using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class ShopEntity
    {
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
        //Tendrá asociado un comerciante.
        public virtual DealerEntity Dealer { get; set; }
        //Tendrá una lista de productos.
        public virtual ICollection<ProductEntity> Products {get; set;}
        //Tendrá una lista de categorias.
        public virtual ICollection<CategoriesEntity> Categories { get; set; }        
        // Un calendario asociado de la provincia al que pertenezca
        public virtual CalendaryEntity Calendary { get; set; }

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
