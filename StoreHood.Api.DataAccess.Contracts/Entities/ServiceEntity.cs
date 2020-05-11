using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class ServiceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
        public string Desc4 { get; set; }        
        public decimal Price { get; set; }      
        public bool Active { get; set; }       
        public decimal Discount { get; set; }
        public bool DiscountAvaible { get; set; }
        public byte[] Image { get; set; }

        //Foreign Key
        public int ActivityId { get; set; }        

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }

        /* Navigation Properties
         * Una servicio pertenece a un única actividad profesional.
         * Una servicio tendrá asociado al menos una categoria.
         * Una servicio tendrá 0 o muchas opiniones.
         */
        public virtual ActivityEntity Activity { get; set; }
        public virtual ICollection<CategoriesEntity> Categories { get; set; }
        public virtual ICollection<OpinionEntity> Opinions { get; set; }

    }
}

