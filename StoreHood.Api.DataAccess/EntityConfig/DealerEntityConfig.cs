using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class DealerEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<DealerEntity> entityBuilder)
        {
            entityBuilder.ToTable("Dealer");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            entityBuilder.HasMany(x => x.Shops).WithOne(x => x.Dealer);
        } 
    }
}
