using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
               
        // Campos de Auditoría.
        public string IpCreate { get; set; }
        public DateTime DateCreate  { get; set; }
        public string IpUpdate { get; set; }
        public DateTime DateUpdate { get; set; }

        /* Navigation Properties
         * Un usuario tendrá una 0 o muchas opiniones realizadas.
         */
        public virtual ICollection<OpinionEntity> Opinions { get; set; }
    }
}
