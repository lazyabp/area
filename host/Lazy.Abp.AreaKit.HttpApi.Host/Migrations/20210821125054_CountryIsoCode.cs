using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lazy.Abp.AreaKit.Migrations
{
    public partial class CountryIsoCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaKitAddresses_AreaKitCountries_CountryId",
                table: "AreaKitAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AreaKitCities_AreaKitStateProvinces_StateProvinceId",
                table: "AreaKitCities");

            migrationBuilder.DropForeignKey(
                name: "FK_AreaKitStateProvinces_AreaKitCountries_CountryId",
                table: "AreaKitStateProvinces");

            migrationBuilder.DropIndex(
                name: "IX_AreaKitStateProvinces_CountryId",
                table: "AreaKitStateProvinces");

            migrationBuilder.DropIndex(
                name: "IX_AreaKitCities_StateProvinceId",
                table: "AreaKitCities");

            migrationBuilder.DropIndex(
                name: "IX_AreaKitAddresses_CountryId",
                table: "AreaKitAddresses");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "AreaKitStateProvinces");

            migrationBuilder.DropColumn(
                name: "IsoCode2",
                table: "AreaKitCountries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "AreaKitCities");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "AreaKitAddresses");

            migrationBuilder.RenameColumn(
                name: "IsoCode3",
                table: "AreaKitCountries",
                newName: "CountryIsoCode");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AreaKitAddresses",
                newName: "StateProvince");

            migrationBuilder.AddColumn<string>(
                name: "CountryIsoCode",
                table: "AreaKitStateProvinces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryIsoCode",
                table: "AreaKitCities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryIsoCode",
                table: "AreaKitAddresses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryIsoCode",
                table: "AreaKitStateProvinces");

            migrationBuilder.DropColumn(
                name: "CountryIsoCode",
                table: "AreaKitCities");

            migrationBuilder.DropColumn(
                name: "CountryIsoCode",
                table: "AreaKitAddresses");

            migrationBuilder.RenameColumn(
                name: "CountryIsoCode",
                table: "AreaKitCountries",
                newName: "IsoCode3");

            migrationBuilder.RenameColumn(
                name: "StateProvince",
                table: "AreaKitAddresses",
                newName: "State");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "AreaKitStateProvinces",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "IsoCode2",
                table: "AreaKitCountries",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "AreaKitCities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "AreaKitAddresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AreaKitStateProvinces_CountryId",
                table: "AreaKitStateProvinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaKitCities_StateProvinceId",
                table: "AreaKitCities",
                column: "StateProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaKitAddresses_CountryId",
                table: "AreaKitAddresses",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaKitAddresses_AreaKitCountries_CountryId",
                table: "AreaKitAddresses",
                column: "CountryId",
                principalTable: "AreaKitCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AreaKitCities_AreaKitStateProvinces_StateProvinceId",
                table: "AreaKitCities",
                column: "StateProvinceId",
                principalTable: "AreaKitStateProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AreaKitStateProvinces_AreaKitCountries_CountryId",
                table: "AreaKitStateProvinces",
                column: "CountryId",
                principalTable: "AreaKitCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
