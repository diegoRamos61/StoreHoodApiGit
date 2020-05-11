using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class ActivityEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ActivityEntity> entityBuilder)
        {
            entityBuilder.ToTable("Activity");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            
            //Una actividad tiene un profesional y este puede dedicarse a varias actividades.
            entityBuilder.HasOne(x => x.Professional).WithMany(x => x.Activities);
            //Un calendario lo tiene muchas actividades y un mismo calendario lo tendrá varias actividades.
            //entityBuilder.HasOne(x => x.Calendary).WithMany(x => x.Activities);
            //Una actividad tiene muchos servicios y un servicio solo será ofrecído por una actividad.
            entityBuilder.HasMany(x => x.Services).WithOne(x => x.Activity);
      
        }
    }
}
