﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class DealerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Cif { get; set; }
        public string Mail { get; set; }
        public bool Active { get; set; }
        
        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }

        /* Navigation Properties
         * Un Comerciante puede tener 0 o muchas comercios asociados.
         */
        public virtual ICollection<ShopEntity> Shops { get; set; }
    }
}
