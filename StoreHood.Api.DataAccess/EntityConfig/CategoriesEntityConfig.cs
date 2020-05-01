using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class CategoriesEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<CategoriesEntity> entityBuilder)
        {
            entityBuilder.ToTable("Categories");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Una categoria puede pertenecer a muchos productos.
            entityBuilder.HasMany(x => x.Products);
            //Una categoria puede pertenecer a muchos servicios.
            entityBuilder.HasMany(x => x.Services);            
      
        }
    }
}
