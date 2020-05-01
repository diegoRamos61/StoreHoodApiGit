using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class CalendaryEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<CalendaryEntity> entityBuilder)
        {
            entityBuilder.ToTable("Calendary");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Un calendario lo tendrán asignado muchas tiendas y estas solo uno.
            entityBuilder.HasMany(x => x.Shops).WithOne(x => x.Calendary);
            //Un calendario lo tendrán asignado muchas Actividades y estas solo uno.
            entityBuilder.HasMany(x => x.Activities).WithOne(x => x.Calendary);

        }
    }
}
