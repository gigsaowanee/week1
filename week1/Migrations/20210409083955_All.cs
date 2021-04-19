using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c2b7a0f3-9175-4d62-a622-16c3068d4093"), "user" },
                    { new Guid("9a7bfbd5-dce0-4945-a963-8417605dfa71"), "Manager" },
                    { new Guid("73c8760d-8d40-45d2-ba5e-2e1dc758fa44"), "Admin" },
                    { new Guid("672fb2cd-180c-4918-80b0-6a7bbbe3812d"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("672fb2cd-180c-4918-80b0-6a7bbbe3812d"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("73c8760d-8d40-45d2-ba5e-2e1dc758fa44"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9a7bfbd5-dce0-4945-a963-8417605dfa71"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c2b7a0f3-9175-4d62-a622-16c3068d4093"));

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
        }
    }
}
