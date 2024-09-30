using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsIlaniDurumlari");

            migrationBuilder.AddColumn<int>(
                name: "IlanDurumId",
                table: "Ilanlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IlanDurumuId",
                table: "Ilanlar",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Uyelikler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "UserGuid" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 6, 14, 196, DateTimeKind.Local).AddTicks(3038), new Guid("0e1ee7a3-eed8-49f4-bbac-13f4f22cc9ef") });

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanDurumuId",
                table: "Ilanlar",
                column: "IlanDurumuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ilanlar_IlanDurumlari_IlanDurumuId",
                table: "Ilanlar",
                column: "IlanDurumuId",
                principalTable: "IlanDurumlari",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ilanlar_IlanDurumlari_IlanDurumuId",
                table: "Ilanlar");

            migrationBuilder.DropIndex(
                name: "IX_Ilanlar_IlanDurumuId",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "IlanDurumId",
                table: "Ilanlar");

            migrationBuilder.DropColumn(
                name: "IlanDurumuId",
                table: "Ilanlar");

            migrationBuilder.CreateTable(
                name: "IsIlaniDurumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanDurumuId = table.Column<int>(type: "int", nullable: true),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanDurumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniDurumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniDurumlari_IlanDurumlari_IlanDurumuId",
                        column: x => x.IlanDurumuId,
                        principalTable: "IlanDurumlari",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IsIlaniDurumlari_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Uyelikler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayitTarihi", "UserGuid" },
                values: new object[] { new DateTime(2024, 9, 30, 11, 28, 34, 201, DateTimeKind.Local).AddTicks(9504), new Guid("abf19994-b831-4f75-ac88-16c6c035518d") });

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniDurumlari_IlanDurumuId",
                table: "IsIlaniDurumlari",
                column: "IlanDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniDurumlari_IlanId",
                table: "IsIlaniDurumlari",
                column: "IlanId");
        }
    }
}
