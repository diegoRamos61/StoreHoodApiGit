using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class ServiceEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ServiceEntity> entityBuilder)
        {
            entityBuilder.ToTable("Service");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //Un servicio pertenece a una actividad y esta puede tener muchos servicios prestados.
            entityBuilder.HasOne(x => x.Activity).WithMany(x => x.Services);
            //Un servicio tiene una o muchas categorias.
            entityBuilder.HasMany(x => x.Categories);
            //Un servicio tiene una o muchas opiniones y una opinión solo puede ser de un servicio.
            entityBuilder.HasMany(x => x.Opinions).WithOne(x => x.Service);
      
        }
    }
}
