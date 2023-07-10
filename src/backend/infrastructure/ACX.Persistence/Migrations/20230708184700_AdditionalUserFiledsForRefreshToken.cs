using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACX.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserFiledsForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dd4c2cf-e0bc-42b5-9503-8cce3323fc07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e9b0981-a7f3-4506-851b-cb9d4386d7e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14cfd80d-b290-41b4-b4f2-c33a38f1443f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4daf4b6c-9302-4a44-bb6d-7bdeac60e43f");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0858da27-2eac-43f2-9f24-7024610360d4", null, "Administrator", "ADMINISTRATOR" },
                    { "87737215-160a-45a2-ada6-49aa319aa3f2", null, "User", "USER" },
                    { "f708bb95-5559-4e3b-b7e2-30c104e43ac4", null, "Provider", "PROVIDER" },
                    { "fe10f865-c2ab-49cb-837a-664e0ee4fd78", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 19, 47, 0, 704, DateTimeKind.Local).AddTicks(5615));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0858da27-2eac-43f2-9f24-7024610360d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87737215-160a-45a2-ada6-49aa319aa3f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f708bb95-5559-4e3b-b7e2-30c104e43ac4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe10f865-c2ab-49cb-837a-664e0ee4fd78");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dd4c2cf-e0bc-42b5-9503-8cce3323fc07", null, "Provider", "PROVIDER" },
                    { "0e9b0981-a7f3-4506-851b-cb9d4386d7e5", null, "User", "USER" },
                    { "14cfd80d-b290-41b4-b4f2-c33a38f1443f", null, "Manager", "MANAGER" },
                    { "4daf4b6c-9302-4a44-bb6d-7bdeac60e43f", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 10, 8, 52, 999, DateTimeKind.Local).AddTicks(2070));
        }
    }
}
