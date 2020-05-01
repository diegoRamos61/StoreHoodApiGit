﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreHood.Api.DataAccess;

namespace StoreHood.Api.DataAccess.Migrations
{
    [DbContext(typeof(StoreHoodDBContext))]
    [Migration("20200501192041_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ActivityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CalendaryId")
                        .HasColumnType("int");

                    b.Property<string>("CloseHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCalendary")
                        .HasColumnType("int");

                    b.Property<int>("IdProfessional")
                        .HasColumnType("int");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfessionalId")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendaryId");

                    b.HasIndex("ProfessionalId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.CalendaryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Holiday")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Calendary");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.CategoriesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("ActivityEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductEntityId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityEntityId");

                    b.HasIndex("ProductEntityId");

                    b.HasIndex("ServiceEntityId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.DealerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Cif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dealer");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.OpinionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityEntityId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Opinion");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("CategoriesEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("DiscountAvaible")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesEntityId");

                    b.HasIndex("ShopId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ProfessionalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Cif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professional");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ServiceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriesEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("DiscountAvaible")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("CategoriesEntityId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ShopEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CalendaryId")
                        .HasColumnType("int");

                    b.Property<string>("CloseHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DealerId")
                        .HasColumnType("int");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCalendary")
                        .HasColumnType("int");

                    b.Property<int>("IdDealer")
                        .HasColumnType("int");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendaryId");

                    b.HasIndex("DealerId");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ActivityEntity", b =>
                {
                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.CalendaryEntity", "Calendary")
                        .WithMany("Activities")
                        .HasForeignKey("CalendaryId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ProfessionalEntity", "Professional")
                        .WithMany("Activities")
                        .HasForeignKey("ProfessionalId");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.CategoriesEntity", b =>
                {
                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ActivityEntity", null)
                        .WithMany("Categories")
                        .HasForeignKey("ActivityEntityId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ProductEntity", null)
                        .WithMany("Categories")
                        .HasForeignKey("ProductEntityId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ServiceEntity", null)
                        .WithMany("Categories")
                        .HasForeignKey("ServiceEntityId");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.OpinionEntity", b =>
                {
                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ActivityEntity", null)
                        .WithMany("Opinions")
                        .HasForeignKey("ActivityEntityId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ProductEntity", "Product")
                        .WithMany("Opinions")
                        .HasForeignKey("ProductId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ServiceEntity", "Service")
                        .WithMany("Opinions")
                        .HasForeignKey("ServiceId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ProductEntity", b =>
                {
                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.CategoriesEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoriesEntityId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ShopEntity", "Shop")
                        .WithMany("Products")
                        .HasForeignKey("ShopId");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ServiceEntity", b =>
                {
                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.ActivityEntity", "Activity")
                        .WithMany("Services")
                        .HasForeignKey("ActivityId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.CategoriesEntity", null)
                        .WithMany("Services")
                        .HasForeignKey("CategoriesEntityId");
                });

            modelBuilder.Entity("StoreHood.Api.DataAccess.Contracts.Entities.ShopEntity", b =>
                {
                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.CalendaryEntity", "Calendary")
                        .WithMany("Shops")
                        .HasForeignKey("CalendaryId");

                    b.HasOne("StoreHood.Api.DataAccess.Contracts.Entities.DealerEntity", "Dealer")
                        .WithMany("Shops")
                        .HasForeignKey("DealerId");
                });
#pragma warning restore 612, 618
        }
    }
}
