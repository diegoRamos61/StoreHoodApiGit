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
        public int IdUser { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual ProductEntity Product { get; set; }
        public virtual ServiceEntity Service { get; set; }
        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}