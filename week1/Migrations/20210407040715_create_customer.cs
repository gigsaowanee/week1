using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("207a38f7-21de-47e1-8312-da94f760335c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("472a62d6-e7e3-459e-871b-05dbe85817ed"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("651b8be1-1cae-412b-b8f3-d55b7ae0eeb5"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("89e70d24-0e43-4bf0-8835-48d0be700bea"));

            migrationBuilder.EnsureSchema(
                name: "sale");

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "sale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    BankAccount = table.Column<string>(maxLength: 15, nullable: false),
                    ATMCode = table.Column<string>(maxLength: 6, nullable: false),
                    Balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer",
                schema: "sale");

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

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("472a62d6-e7e3-459e-871b-05dbe85817ed"), "user" },
                    { new Guid("207a38f7-21de-47e1-8312-da94f760335c"), "Manager" },
                    { new Guid("651b8be1-1cae-412b-b8f3-d55b7ae0eeb5"), "Admin" },
                    { new Guid("89e70d24-0e43-4bf0-8835-48d0be700bea"), "Developer" }
                });
        }
    }
}
