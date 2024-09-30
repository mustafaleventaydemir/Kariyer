using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForeign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Uyelikler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "UserGuid" },
                values: new object[] { new DateTime(2024, 9, 30, 11, 28, 34, 201, DateTimeKind.Local).AddTicks(9504), new Guid("abf19994-b831-4f75-ac88-16c6c035518d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Uyelikler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "UserGuid" },
                values: new object[] { new DateTime(2024, 9, 30, 11, 16, 50, 68, DateTimeKind.Local).AddTicks(6957), new Guid("602b0418-9551-4a34-bab9-638b09b4a32b") });
        }
    }
}
