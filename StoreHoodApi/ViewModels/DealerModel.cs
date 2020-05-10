using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.ViewModels
{
    /// <summary>
    /// Son las estructuras que nos llegarán para las peticiones.
    /// </summary>
    public class DealerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Cif { get; set; }
        public string Mail { get; set; }
        public bool Active { get; set; }
    }
}
