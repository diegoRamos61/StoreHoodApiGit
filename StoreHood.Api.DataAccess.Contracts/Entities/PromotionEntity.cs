using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class PromotionEntity
    {
        //Pendiente de analizar que campos harán falta.
        public int Id { get; set; }
        public decimal AmountMin { get; set; }
        public decimal AmountMax { get; set; }
        public decimal DiscountMoney { get; set; }
        public decimal DiscountPerc { get; set; }
        public bool Active { get; set; }       


        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
