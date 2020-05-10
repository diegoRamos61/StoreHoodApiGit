using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.ViewModels
{
    /// <summary>
    /// Son las estructuras que nos llegarán para las peticiones.
    /// </summary>
    public class CategoriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }       
        public bool Active { get; set; }
    }
}
