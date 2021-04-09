using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1420fd19-2a52-4d68-a4e4-25187555cb7f"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5198ab3f-1d9d-4521-87a4-420948f07631"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7f246142-f57e-4458-a1bf-0a1f34f57f01"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f5230a33-61e0-43db-83b9-9c2dfbefed87"));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                schema: "Store",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("abf28d75-0260-46ef-9f23-14c6afc9e264"), "user" },
                    { new Guid("0b6a9cb0-8673-4778-80d9-eccac228f0f5"), "Manager" },
                    { new Guid("770d6a67-49ab-4136-b59f-3ce39eaf4457"), "Admin" },
                    { new Guid("49ac3a46-67d8-4dc8-8f2a-33759e469bd7"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0b6a9cb0-8673-4778-80d9-eccac228f0f5"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("49ac3a46-67d8-4dc8-8f2a-33759e469bd7"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("770d6a67-49ab-4136-b59f-3ce39eaf4457"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("abf28d75-0260-46ef-9f23-14c6afc9e264"));

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "Store",
                table: "Product");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7f246142-f57e-4458-a1bf-0a1f34f57f01"), "user" },
                    { new Guid("f5230a33-61e0-43db-83b9-9c2dfbefed87"), "Manager" },
                    { new Guid("5198ab3f-1d9d-4521-87a4-420948f07631"), "Admin" },
                    { new Guid("1420fd19-2a52-4d68-a4e4-25187555cb7f"), "Developer" }
                });
        }
    }
}
