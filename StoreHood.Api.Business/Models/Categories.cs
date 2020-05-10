using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Categories
    {
        //Lógica de negocio de la entidad Categories.
        // Tendremos las propiedadas de nuestra entidad.
        public int Id { get; set; }
        public string Name { get; set; }        
        public bool Active { get; set; }

    }
}
