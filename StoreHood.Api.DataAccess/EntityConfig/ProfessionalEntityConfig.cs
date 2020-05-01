using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class ProfessionalEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ProfessionalEntity> entityBuilder)
        {
            entityBuilder.ToTable("Professional");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            entityBuilder.HasMany(x => x.Activities).WithOne(x => x.Professional);
        } 
    }
}
