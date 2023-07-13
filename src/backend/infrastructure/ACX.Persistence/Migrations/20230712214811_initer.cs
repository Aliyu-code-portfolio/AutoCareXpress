using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACX.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c8b0c0-c97e-4f2d-bea5-6296ae1a5d6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95995341-0590-462c-b63c-8d78a776ec92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd06bb80-6b5c-4191-b39d-ecc2a57bf397");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe8dda6f-4733-4859-84a7-67e27d7c4b45");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmailTokenExpiryDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmailVerifyCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmailVerifyDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPasswordChangeDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordChangeTokenExpiryDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordResetCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "039da016-9bc9-4035-85f1-b3fad26005e9", null, "Provider", "PROVIDER" },
                    { "4891255d-ca8e-43a2-a083-c7f570135f00", null, "Manager", "MANAGER" },
                    { "4fce71ac-38e5-4ba5-908f-ddc1a5e13a45", null, "Administrator", "ADMINISTRATOR" },
                    { "fd726990-3240-47b2-a265-2052b5807f03", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 842, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 22, 48, 10, 843, DateTimeKind.Local).AddTicks(837));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "039da016-9bc9-4035-85f1-b3fad26005e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4891255d-ca8e-43a2-a083-c7f570135f00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fce71ac-38e5-4ba5-908f-ddc1a5e13a45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd726990-3240-47b2-a265-2052b5807f03");

            migrationBuilder.DropColumn(
                name: "EmailTokenExpiryDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailVerifyCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailVerifyDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastPasswordChangeDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordChangeTokenExpiryDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordResetCode",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93c8b0c0-c97e-4f2d-bea5-6296ae1a5d6d", null, "Administrator", "ADMINISTRATOR" },
                    { "95995341-0590-462c-b63c-8d78a776ec92", null, "User", "USER" },
                    { "dd06bb80-6b5c-4191-b39d-ecc2a57bf397", null, "Manager", "MANAGER" },
                    { "fe8dda6f-4733-4859-84a7-67e27d7c4b45", null, "Provider", "PROVIDER" }
                });

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 901, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 902, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 902, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 902, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 902, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 6, 33, 49, 902, DateTimeKind.Local).AddTicks(87));
        }
    }
}
