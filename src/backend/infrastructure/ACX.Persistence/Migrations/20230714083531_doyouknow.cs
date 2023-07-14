using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACX.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class doyouknow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423925db-6ad0-40fb-9e61-565b9b3c7876");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b022d27b-d4fa-458c-bc5f-424ffac130db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb853a9f-0338-44fe-bc6d-3e6974499582");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e250118c-ca5a-4f86-99dc-fdd85b2476d1");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DoYouKnows",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "PasswordResetCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36e65e34-ad10-4fc7-88f4-e1c454eb0fb5", null, "User", "USER" },
                    { "3b16a93b-ee2e-4b83-96b0-13ef3ac4683d", null, "Provider", "PROVIDER" },
                    { "9afe2b61-c4c5-4aa6-b5e6-228f6e7e0703", null, "Administrator", "ADMINISTRATOR" },
                    { "e74cfe7f-d8ce-4095-a5f9-e748d3d83ec0", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "DoYouKnows",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3871), "Engine oil is essential for the smooth running of your car's engine. Check the oil level regularly using the dipstick and change it as per the manufacturer's recommendations.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regularly check and change the engine oil" },
                    { 2, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3884), "Maintaining proper tire pressure improves fuel efficiency and extends tire life. Check the tire pressure at least once a month and inflate or deflate them as needed according to the recommended levels mentioned in the owner's manual.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keep an eye on tire pressure" },
                    { 3, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3889), "Rotating and balancing your car's tires helps ensure even wear and extends their lifespan. Have this done regularly, generally every 5,000 to 7,500 miles (8,000 to 12,000 kilometers) or as advised in the owner's manual.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rotate and balance tires" },
                    { 4, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3893), "Air filters prevent dirt and debris from entering the engine, ensuring its optimal performance. Regularly check and replace both the engine air filter and the cabin air filter based on the recommended intervals.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Replace air filters" },
                    { 5, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3898), "Your car has several fluids, such as coolant, brake fluid, power steering fluid, and transmission fluid, that require periodic checks and replacements. Refer to the owner's manual to understand the recommended intervals for each.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Check and replace other fluids" },
                    { 6, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3902), "Over time, belts and hoses can wear out and become prone to cracks or leaks. Regularly inspect them for any signs of damage or aging, and replace them as needed.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inspect and replace worn-out belts and hoses" },
                    { 7, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3906), "Regularly washing and waxing your car helps protect the paint from damage and keeps it looking good. Additionally, clean the interior regularly, including vacuuming the carpets and wiping down surfaces.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maintain a clean car" },
                    { 8, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3910), "If any warning lights appear on your dashboard, address them promptly. Ignoring these lights can lead to more significant issues. Consult the owner's manual or seek professional help if necessary.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pay attention to warning lights" },
                    { 9, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3914), "Follow the manufacturer's recommended maintenance schedule for your car. This typically includes routine inspections, oil changes, filter replacements, and other preventive maintenance tasks. Sticking to this schedule helps identify potential problems early on.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schedule regular maintenance services" },
                    { 10, null, new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(3918), "How you drive greatly impacts the longevity of your car. Avoid aggressive driving, rapid acceleration, and sudden braking, as these can put unnecessary strain on the vehicle's components.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drive carefully and avoid harsh driving habits" }
                });

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 14, 9, 35, 30, 821, DateTimeKind.Local).AddTicks(2492));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36e65e34-ad10-4fc7-88f4-e1c454eb0fb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b16a93b-ee2e-4b83-96b0-13ef3ac4683d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9afe2b61-c4c5-4aa6-b5e6-228f6e7e0703");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e74cfe7f-d8ce-4095-a5f9-e748d3d83ec0");

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DoYouKnows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DoYouKnows",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordResetCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "423925db-6ad0-40fb-9e61-565b9b3c7876", null, "User", "USER" },
                    { "b022d27b-d4fa-458c-bc5f-424ffac130db", null, "Provider", "PROVIDER" },
                    { "bb853a9f-0338-44fe-bc6d-3e6974499582", null, "Administrator", "ADMINISTRATOR" },
                    { "e250118c-ca5a-4f86-99dc-fdd85b2476d1", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Ref_Service_Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 3, 59, 24, 986, DateTimeKind.Local).AddTicks(9150));
        }
    }
}
