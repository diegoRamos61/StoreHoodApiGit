using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.ViewModels
{
    /// <summary>
    /// Son las estructuras que nos llegarán para las peticiones.
    /// </summary>
    public class ServiceModel
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
    }
}
