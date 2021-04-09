using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class add_product_new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3960da17-4ac2-4303-aea7-ddcff548ceec"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("596474ec-7f2e-4cb4-a1ca-fc1403d2d4eb"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("612f1740-12c7-4205-9ca0-8d2801567e52"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("66e3bcc3-8058-453e-95c1-21c753179f42"));

            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.CreateTable(
                name: "ProductGroup",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(maxLength: 5, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    NumberOfProduct = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductGroup_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalSchema: "Store",
                        principalTable: "ProductGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGroupId",
                schema: "Store",
                table: "Product",
                column: "ProductGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "Store");

            migrationBuilder.DropTable(
                name: "ProductGroup",
                schema: "Store");

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

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("66e3bcc3-8058-453e-95c1-21c753179f42"), "user" },
                    { new Guid("3960da17-4ac2-4303-aea7-ddcff548ceec"), "Manager" },
                    { new Guid("596474ec-7f2e-4cb4-a1ca-fc1403d2d4eb"), "Admin" },
                    { new Guid("612f1740-12c7-4205-9ca0-8d2801567e52"), "Developer" }
                });
        }
    }
}
