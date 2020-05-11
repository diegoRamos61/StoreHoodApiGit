using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class ShopEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ShopEntity> entityBuilder)
        {
            entityBuilder.ToTable("Shop");
            entityBuilder.HasKey(x => x.Id);            
            entityBuilder.Property(x => x.Id).IsRequired();

            //Una tienda tiene un comerciante y este puede tener varias tiendas.
            entityBuilder.HasOne(x => x.Dealer).WithMany(x => x.Shops);
            //Un tienda tiene un solo calendario.
            entityBuilder.HasOne(x => x.Calendary);
            //Un tienda tiene muchos productos y un producto solo puede estar en una tienda.
            entityBuilder.HasMany(x => x.Products).WithOne(x => x.Shop);
      
        }
    }
}
