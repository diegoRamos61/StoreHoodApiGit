using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreHood.Api.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Holiday = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname1 = table.Column<string>(nullable: true),
                    Surname2 = table.Column<string>(nullable: true),
                    Cif = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname1 = table.Column<string>(nullable: true),
                    Surname2 = table.Column<string>(nullable: true),
                    Cif = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname1 = table.Column<string>(nullable: true),
                    Surname2 = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    OpenHour = table.Column<string>(nullable: true),
                    CloseHour = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    IdDealer = table.Column<int>(nullable: false),
                    IdCalendary = table.Column<int>(nullable: false),
                    DealerId = table.Column<int>(nullable: true),
                    CalendaryId = table.Column<int>(nullable: true),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shop_Calendary_CalendaryId",
                        column: x => x.CalendaryId,
                        principalTable: "Calendary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shop_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc1 = table.Column<string>(nullable: true),
                    Desc2 = table.Column<string>(nullable: true),
                    Desc3 = table.Column<string>(nullable: true),
                    Desc4 = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    OpenHour = table.Column<string>(nullable: true),
                    CloseHour = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    IdProfessional = table.Column<int>(nullable: false),
                    IdCalendary = table.Column<int>(nullable: false),
                    ProfessionalId = table.Column<int>(nullable: true),
                    CalendaryId = table.Column<int>(nullable: true),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_Calendary_CalendaryId",
                        column: x => x.CalendaryId,
                        principalTable: "Calendary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activity_Professional_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ActivityEntityId = table.Column<int>(nullable: true),
                    ProductEntityId = table.Column<int>(nullable: true),
                    ServiceEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Activity_ActivityEntityId",
                        column: x => x.ActivityEntityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc1 = table.Column<string>(nullable: true),
                    Desc2 = table.Column<string>(nullable: true),
                    Desc3 = table.Column<string>(nullable: true),
                    Desc4 = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Discount = table.Column<decimal>(nullable: false),
                    DiscountAvaible = table.Column<bool>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    ShopId = table.Column<int>(nullable: true),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    CategoriesEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Categories_CategoriesEntityId",
                        column: x => x.CategoriesEntityId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc1 = table.Column<string>(nullable: true),
                    Desc2 = table.Column<string>(nullable: true),
                    Desc3 = table.Column<string>(nullable: true),
                    Desc4 = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    DiscountAvaible = table.Column<bool>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    CategoriesEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Categories_CategoriesEntityId",
                        column: x => x.CategoriesEntityId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Opinion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    IpCreate = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    IpUpdate = table.Column<string>(nullable: true),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    ActivityEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opinion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opinion_Activity_ActivityEntityId",
                        column: x => x.ActivityEntityId,
                        principalTable: "Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opinion_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opinion_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opinion_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_CalendaryId",
                table: "Activity",
                column: "CalendaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ProfessionalId",
                table: "Activity",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ActivityEntityId",
                table: "Categories",
                column: "ActivityEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductEntityId",
                table: "Categories",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ServiceEntityId",
                table: "Categories",
                column: "ServiceEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinion_ActivityEntityId",
                table: "Opinion",
                column: "ActivityEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinion_ProductId",
                table: "Opinion",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinion_ServiceId",
                table: "Opinion",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinion_UserId",
                table: "Opinion",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoriesEntityId",
                table: "Product",
                column: "CategoriesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopId",
                table: "Product",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ActivityId",
                table: "Service",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CategoriesEntityId",
                table: "Service",
                column: "CategoriesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_CalendaryId",
                table: "Shop",
                column: "CalendaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_DealerId",
                table: "Shop",
                column: "DealerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Product_ProductEntityId",
                table: "Categories",
                column: "ProductEntityId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Service_ServiceEntityId",
                table: "Categories",
                column: "ServiceEntityId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Calendary_CalendaryId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Calendary_CalendaryId",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Professional_ProfessionalId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Activity_ActivityEntityId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Activity_ActivityId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Product_ProductEntityId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Service_ServiceEntityId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Opinion");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Calendary");

            migrationBuilder.DropTable(
                name: "Professional");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
