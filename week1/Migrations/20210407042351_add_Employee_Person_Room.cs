using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class add_Employee_Person_Room : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("20ec5a36-2310-4889-aec9-c8fc79ca2878"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("384698eb-6a12-4a19-bc98-8b8c07eda1ce"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("49e1e26d-0e22-4622-a0c7-178ab8a3edb8"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ff7367f0-36f5-4aad-b9f6-5c3bc01bf509"));

            migrationBuilder.EnsureSchema(
                name: "Personal");

            migrationBuilder.EnsureSchema(
                name: "Hotel");

            migrationBuilder.CreateTable(
                name: "Room",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    People = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "sale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("20cf6f9b-386e-4961-84d4-4c78301924db"), "user" },
                    { new Guid("30c71ef4-e845-49da-af9a-a56944da51c7"), "Manager" },
                    { new Guid("6c9c6274-10c3-4ef1-9e74-5d2d02096601"), "Admin" },
                    { new Guid("05433485-ac37-4f9c-be11-0b220fd3a15b"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Personal");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "sale");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("05433485-ac37-4f9c-be11-0b220fd3a15b"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("20cf6f9b-386e-4961-84d4-4c78301924db"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("30c71ef4-e845-49da-af9a-a56944da51c7"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6c9c6274-10c3-4ef1-9e74-5d2d02096601"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("384698eb-6a12-4a19-bc98-8b8c07eda1ce"), "user" },
                    { new Guid("ff7367f0-36f5-4aad-b9f6-5c3bc01bf509"), "Manager" },
                    { new Guid("20ec5a36-2310-4889-aec9-c8fc79ca2878"), "Admin" },
                    { new Guid("49e1e26d-0e22-4622-a0c7-178ab8a3edb8"), "Developer" }
                });
        }
    }
}
