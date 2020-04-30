using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class PromotionEntity
    {
        //Pendiente de analizar que campos harán falta.
        public double AmountMin { get; set; }
        public double AmountMax { get; set; }
        public double DiscountMoney { get; set; }
        public double DiscountPerc { get; set; }
        public bool Active { get; set; }       


        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
