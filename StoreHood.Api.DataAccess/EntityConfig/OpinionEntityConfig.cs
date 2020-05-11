using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreHood.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.EntityConfig
{
    public class OpinionEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<OpinionEntity> entityBuilder)
        {
            entityBuilder.ToTable("Opinion");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            entityBuilder.HasOne(x => x.User).WithMany(x => x.Opinions);
            //Una opinión corresponde unicamente a un producto, pero este puedes tener varias.
            entityBuilder.HasOne(x => x.Product).WithMany(x => x.Opinions);
            //Una opinión corresponde unicamente a una actividadProfesional, pero este puedes tener varias.
            entityBuilder.HasOne(x => x.Service).WithMany(x => x.Opinions);
        } 
    }
}
