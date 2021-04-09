using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class Order_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                schema: "Store",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<double>(nullable: false),
                    TotalCount = table.Column<int>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    QTY = table.Column<int>(nullable: false),
                    OrderDetailDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "Store",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Store",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bc28591b-d3f7-463a-860f-903457b8b587"), "user" },
                    { new Guid("df5f0df9-fbfa-418b-87f5-d00bd857ac9b"), "Manager" },
                    { new Guid("89fe256f-8b28-4ab0-905b-4e1cc20afc77"), "Admin" },
                    { new Guid("8354fce6-6fe2-48ef-abcb-1ff8f5a6f32c"), "Developer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                schema: "Store",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                schema: "Store",
                table: "OrderDetail",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail",
                schema: "Store");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "Store");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8354fce6-6fe2-48ef-abcb-1ff8f5a6f32c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("89fe256f-8b28-4ab0-905b-4e1cc20afc77"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bc28591b-d3f7-463a-860f-903457b8b587"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("df5f0df9-fbfa-418b-87f5-d00bd857ac9b"));

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                schema: "Store",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

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
    }
}
