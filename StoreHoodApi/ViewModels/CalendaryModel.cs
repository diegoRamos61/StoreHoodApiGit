using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.ViewModels
{
    /// <summary>
    /// Son las estructuras que nos llegarán para las peticiones.
    /// </summary>
    public class CalendaryModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Holiday { get; set; }
    }
}
