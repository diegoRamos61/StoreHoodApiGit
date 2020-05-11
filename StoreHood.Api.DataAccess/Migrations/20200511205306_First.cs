using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreHood.Api.DataAccess.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Professional_ProfessionalId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Activity_ActivityEntityId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_Activity_ActivityEntityId",
                table: "Opinion");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_Users_UserId",
                table: "Opinion");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoriesEntityId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shop_ShopId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Activity_ActivityId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Categories_CategoriesEntityId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Dealer_DealerId",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Service_CategoriesEntityId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoriesEntityId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Opinion_ActivityEntityId",
                table: "Opinion");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ActivityEntityId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IdCalendary",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "IdDealer",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "CategoriesEntityId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "CategoriesEntityId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ActivityEntityId",
                table: "Opinion");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Opinion");

            migrationBuilder.DropColumn(
                name: "ActivityEntityId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IdCalendary",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "IdProfessional",
                table: "Activity");

            migrationBuilder.AlterColumn<int>(
                name: "DealerId",
                table: "Shop",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "Service",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Opinion",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalId",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Professional_ProfessionalId",
                table: "Activity",
                column: "ProfessionalId",
                principalTable: "Professional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_Users_UserId",
                table: "Opinion",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shop_ShopId",
                table: "Product",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Activity_ActivityId",
                table: "Service",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Dealer_DealerId",
                table: "Shop",
                column: "DealerId",
                principalTable: "Dealer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Professional_ProfessionalId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinion_Users_UserId",
                table: "Opinion");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shop_ShopId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Activity_ActivityId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Dealer_DealerId",
                table: "Shop");

            migrationBuilder.AlterColumn<int>(
                name: "DealerId",
                table: "Shop",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdCalendary",
                table: "Shop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDealer",
                table: "Shop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoriesEntityId",
                table: "Service",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoriesEntityId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Opinion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ActivityEntityId",
                table: "Opinion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Opinion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ActivityEntityId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalId",
                table: "Activity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdCalendary",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProfessional",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Service_CategoriesEntityId",
                table: "Service",
                column: "CategoriesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoriesEntityId",
                table: "Product",
                column: "CategoriesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinion_ActivityEntityId",
                table: "Opinion",
                column: "ActivityEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ActivityEntityId",
                table: "Categories",
                column: "ActivityEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Professional_ProfessionalId",
                table: "Activity",
                column: "ProfessionalId",
                principalTable: "Professional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Activity_ActivityEntityId",
                table: "Categories",
                column: "ActivityEntityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_Activity_ActivityEntityId",
                table: "Opinion",
                column: "ActivityEntityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinion_Users_UserId",
                table: "Opinion",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoriesEntityId",
                table: "Product",
                column: "CategoriesEntityId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shop_ShopId",
                table: "Product",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Activity_ActivityId",
                table: "Service",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Categories_CategoriesEntityId",
                table: "Service",
                column: "CategoriesEntityId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Dealer_DealerId",
                table: "Shop",
                column: "DealerId",
                principalTable: "Dealer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
