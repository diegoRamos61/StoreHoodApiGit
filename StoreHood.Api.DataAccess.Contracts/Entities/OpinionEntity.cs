using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class OpinionEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public int UserId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }

        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }

        /* Navigation Properties
         * Una opinión es realizada por un usuario y será referida a un producto o servicio        
         */
        public virtual UserEntity User { get; set; }
        public virtual ProductEntity Product { get; set; }
        public virtual ServiceEntity Service { get; set; }


    }
}