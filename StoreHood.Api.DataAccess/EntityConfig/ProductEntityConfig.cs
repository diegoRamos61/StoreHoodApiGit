using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class ProductEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ProductEntity> entityBuilder)
        {
            entityBuilder.ToTable("Product");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Un producto pertenece a una tienda y esta puede tener muchos productos.
            entityBuilder.HasOne(x => x.Shop).WithMany(x => x.Products);
            //Un producto tiene una o muchas categorias.
            entityBuilder.HasMany(x => x.Categories);
            //Un producto tiene una o muchas opiniones y una opinión solo puede ser de un producto.
            entityBuilder.HasMany(x => x.Opinions).WithOne(x => x.Product);
      
        }
    }
}
