using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.Business.Models
{
    public class Opinion
    {
        //Lógica de negocio de la entidad opinion.
        // Tendremos las propiedadas de nuestra entidad.
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public int IdUser { get; set; }


    }
}
