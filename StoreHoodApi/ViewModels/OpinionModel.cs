using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.ViewModels
{
    /// <summary>
    /// Son las estructuras que nos llegarán para las peticiones.
    /// </summary>
    public class OpinionModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public int IdUser { get; set; }
    }
}
