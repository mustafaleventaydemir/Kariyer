using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalismaSekilleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSekilleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cinsiyetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinsiyetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeneyimSureleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeneyimSureleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IlanDurumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanDurumlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PozisyonAdi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsTanimi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Yetkinlikler = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tercihen = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    SirketImkanlari = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    PostaKodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IlanTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SonBasvuruTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mezuniyetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mezuniyetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mulakatlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mulakatlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sektorler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sektorler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalMedyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalMedyalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ulkeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulkeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universiteler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universiteler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YabanciDiller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YabanciDiller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YazilimDiller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YazilimDiller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniCalismaSekilleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalismaSekliId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniCalismaSekilleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniCalismaSekilleri_CalismaSekilleri_CalismaSekliId",
                        column: x => x.CalismaSekliId,
                        principalTable: "CalismaSekilleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniCalismaSekilleri_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniCinsiyetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinsiyetId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniCinsiyetler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniCinsiyetler_Cinsiyetler_CinsiyetId",
                        column: x => x.CinsiyetId,
                        principalTable: "Cinsiyetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniCinsiyetler_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniDeneyimSureleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeneyimSureId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniDeneyimSureleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniDeneyimSureleri_DeneyimSureleri_DeneyimSureId",
                        column: x => x.DeneyimSureId,
                        principalTable: "DeneyimSureleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniDeneyimSureleri_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniDurumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    IlanDurumId = table.Column<int>(type: "int", nullable: false),
                    IlanDurumuId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "IsIlaniMezuniyetleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MezuniyetId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniMezuniyetleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniMezuniyetleri_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniMezuniyetleri_Mezuniyetler_MezuniyetId",
                        column: x => x.MezuniyetId,
                        principalTable: "Mezuniyetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uyelikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyelikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uyelikler_Roller_RolId",
                        column: x => x.RolId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniSehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniSehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniSehirler_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniSehirler_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniSektorler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SektorId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniSektorler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniSektorler_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniSektorler_Sektorler_SektorId",
                        column: x => x.SektorId,
                        principalTable: "Sektorler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsIlaniUlkeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsIlaniUlkeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsIlaniUlkeler_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsIlaniUlkeler_Ulkeler_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulkeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fakulteler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    UniversiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakulteler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fakulteler_Universiteler_UniversiteId",
                        column: x => x.UniversiteId,
                        principalTable: "Universiteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IlaniYabanciDilleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    YabanciDilId = table.Column<int>(type: "int", nullable: false),
                    Okuma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Yazma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Konusma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlaniYabanciDilleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlaniYabanciDilleri_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IlaniYabanciDilleri_YabanciDiller_YabanciDilId",
                        column: x => x.YabanciDilId,
                        principalTable: "YabanciDiller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriIlanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyelikId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriIlanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriIlanlar_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriIlanlar_Uyelikler_UyelikId",
                        column: x => x.UyelikId,
                        principalTable: "Uyelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IlanKayitlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyelikId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanKayitlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlanKayitlari_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IlanKayitlari_Uyelikler_UyelikId",
                        column: x => x.UyelikId,
                        principalTable: "Uyelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ozgecmisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyelikId = table.Column<int>(type: "int", nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CinsiyetId = table.Column<int>(type: "int", nullable: false),
                    UyrukId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UlkeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ozgecmisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ozgecmisler_Cinsiyetler_CinsiyetId",
                        column: x => x.CinsiyetId,
                        principalTable: "Cinsiyetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ozgecmisler_Ulkeler_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulkeler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ozgecmisler_Uyelikler_UyelikId",
                        column: x => x.UyelikId,
                        principalTable: "Uyelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sirketler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Hakkimizda = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UyelikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sirketler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sirketler_Uyelikler_UyelikId",
                        column: x => x.UyelikId,
                        principalTable: "Uyelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    FakulteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bolumler_Fakulteler_FakulteId",
                        column: x => x.FakulteId,
                        principalTable: "Fakulteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Basvuranlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanId = table.Column<int>(type: "int", nullable: false),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvuranlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Basvuranlar_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basvuranlar_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EkBilgiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bilgiler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkBilgiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EkBilgiler_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    Meslek = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CalismaSekli = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Konum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DeneyimYili = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MezuniyetDerecesi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hakkimda_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hobiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobiler_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsDeneyimleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    SirketAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDeneyimleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsDeneyimleri_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzgecmisSehirleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzgecmisSehirleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzgecmisSehirleri_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OzgecmisSehirleri_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzgecmisSosyalMedyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SosyalMedyaId = table.Column<int>(type: "int", nullable: false),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzgecmisSosyalMedyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzgecmisSosyalMedyalar_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OzgecmisSosyalMedyalar_SosyalMedyalar_SosyalMedyaId",
                        column: x => x.SosyalMedyaId,
                        principalTable: "SosyalMedyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzgecmisYabanciDiller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false),
                    YabanciDilId = table.Column<int>(type: "int", nullable: false),
                    Okuma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Yazma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Konusma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzgecmisYabanciDiller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzgecmisYabanciDiller_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OzgecmisYabanciDiller_YabanciDiller_YabanciDilId",
                        column: x => x.YabanciDilId,
                        principalTable: "YabanciDiller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzgecmisYazilimDiller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BilgiOrani = table.Column<byte>(type: "tinyint", nullable: false),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false),
                    YazilimDilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzgecmisYazilimDiller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzgecmisYazilimDiller_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OzgecmisYazilimDiller_YazilimDiller_YazilimDilId",
                        column: x => x.YazilimDilId,
                        principalTable: "YazilimDiller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referanlar_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sertifikalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    KurumAdi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sertifikalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sertifikalar_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sinavlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Puan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinavlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinavlar_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MulakatListeleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false),
                    MulakatId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MulakatListeleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MulakatListeleri_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MulakatListeleri_Mulakatlar_MulakatId",
                        column: x => x.MulakatId,
                        principalTable: "Mulakatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MulakatListeleri_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MulakatListeleri_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OzgecmisHavuzlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzgecmisHavuzlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzgecmisHavuzlari_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OzgecmisHavuzlari_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SirketIlanlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketId = table.Column<int>(type: "int", nullable: false),
                    IlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketIlanlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SirketIlanlari_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SirketIlanlari_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SirketSehirleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketId = table.Column<int>(type: "int", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketSehirleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SirketSehirleri_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SirketSehirleri_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SirketSektorleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SektorId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketSektorleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SirketSektorleri_Sektorler_SektorId",
                        column: x => x.SektorId,
                        principalTable: "Sektorler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SirketSektorleri_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SirketSosyalMedyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SosyalMedyaId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketSosyalMedyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SirketSosyalMedyalar_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SirketSosyalMedyalar_SosyalMedyalar_SosyalMedyaId",
                        column: x => x.SosyalMedyaId,
                        principalTable: "SosyalMedyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SirketTakipleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyelikId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketTakipleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SirketTakipleri_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SirketTakipleri_Uyelikler_UyelikId",
                        column: x => x.UyelikId,
                        principalTable: "Uyelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Egitimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OzgecmisId = table.Column<int>(type: "int", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egitimler_Bolumler_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolumler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egitimler_Ozgecmisler_OzgecmisId",
                        column: x => x.OzgecmisId,
                        principalTable: "Ozgecmisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "RolAdi" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Uyelikler",
                columns: new[] { "Id", "Adi", "Email", "KayitTarihi", "KullaniciAdi", "RolId", "Sifre", "Soyadi", "UserGuid" },
                values: new object[] { 1, "Admin", "admin@kariyer.tc", new DateTime(2024, 9, 30, 11, 16, 50, 68, DateTimeKind.Local).AddTicks(6957), "Admin", 1, "123456", "ADMİN", new Guid("602b0418-9551-4a34-bab9-638b09b4a32b") });

            migrationBuilder.CreateIndex(
                name: "IX_Basvuranlar_IlanId",
                table: "Basvuranlar",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuranlar_OzgecmisId",
                table: "Basvuranlar",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_Bolumler_FakulteId",
                table: "Bolumler",
                column: "FakulteId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimler_BolumId",
                table: "Egitimler",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimler_OzgecmisId",
                table: "Egitimler",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_EkBilgiler_OzgecmisId",
                table: "EkBilgiler",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_Fakulteler_UniversiteId",
                table: "Fakulteler",
                column: "UniversiteId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriIlanlar_IlanId",
                table: "FavoriIlanlar",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriIlanlar_UyelikId",
                table: "FavoriIlanlar",
                column: "UyelikId");

            migrationBuilder.CreateIndex(
                name: "IX_Hakkimda_OzgecmisId",
                table: "Hakkimda",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobiler_OzgecmisId",
                table: "Hobiler",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_IlaniYabanciDilleri_IlanId",
                table: "IlaniYabanciDilleri",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IlaniYabanciDilleri_YabanciDilId",
                table: "IlaniYabanciDilleri",
                column: "YabanciDilId");

            migrationBuilder.CreateIndex(
                name: "IX_IlanKayitlari_IlanId",
                table: "IlanKayitlari",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IlanKayitlari_UyelikId",
                table: "IlanKayitlari",
                column: "UyelikId");

            migrationBuilder.CreateIndex(
                name: "IX_IsDeneyimleri_OzgecmisId",
                table: "IsDeneyimleri",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniCalismaSekilleri_CalismaSekliId",
                table: "IsIlaniCalismaSekilleri",
                column: "CalismaSekliId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniCalismaSekilleri_IlanId",
                table: "IsIlaniCalismaSekilleri",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniCinsiyetler_CinsiyetId",
                table: "IsIlaniCinsiyetler",
                column: "CinsiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniCinsiyetler_IlanId",
                table: "IsIlaniCinsiyetler",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniDeneyimSureleri_DeneyimSureId",
                table: "IsIlaniDeneyimSureleri",
                column: "DeneyimSureId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniDeneyimSureleri_IlanId",
                table: "IsIlaniDeneyimSureleri",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniDurumlari_IlanDurumuId",
                table: "IsIlaniDurumlari",
                column: "IlanDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniDurumlari_IlanId",
                table: "IsIlaniDurumlari",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniMezuniyetleri_IlanId",
                table: "IsIlaniMezuniyetleri",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniMezuniyetleri_MezuniyetId",
                table: "IsIlaniMezuniyetleri",
                column: "MezuniyetId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniSehirler_IlanId",
                table: "IsIlaniSehirler",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniSehirler_SehirId",
                table: "IsIlaniSehirler",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniSektorler_IlanId",
                table: "IsIlaniSektorler",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniSektorler_SektorId",
                table: "IsIlaniSektorler",
                column: "SektorId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniUlkeler_IlanId",
                table: "IsIlaniUlkeler",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IsIlaniUlkeler_UlkeId",
                table: "IsIlaniUlkeler",
                column: "UlkeId");

            migrationBuilder.CreateIndex(
                name: "IX_MulakatListeleri_IlanId",
                table: "MulakatListeleri",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_MulakatListeleri_MulakatId",
                table: "MulakatListeleri",
                column: "MulakatId");

            migrationBuilder.CreateIndex(
                name: "IX_MulakatListeleri_OzgecmisId",
                table: "MulakatListeleri",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_MulakatListeleri_SirketId",
                table: "MulakatListeleri",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisHavuzlari_OzgecmisId",
                table: "OzgecmisHavuzlari",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisHavuzlari_SirketId",
                table: "OzgecmisHavuzlari",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ozgecmisler_CinsiyetId",
                table: "Ozgecmisler",
                column: "CinsiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_Ozgecmisler_UlkeId",
                table: "Ozgecmisler",
                column: "UlkeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ozgecmisler_UyelikId",
                table: "Ozgecmisler",
                column: "UyelikId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisSehirleri_OzgecmisId",
                table: "OzgecmisSehirleri",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisSehirleri_SehirId",
                table: "OzgecmisSehirleri",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisSosyalMedyalar_OzgecmisId",
                table: "OzgecmisSosyalMedyalar",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisSosyalMedyalar_SosyalMedyaId",
                table: "OzgecmisSosyalMedyalar",
                column: "SosyalMedyaId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisYabanciDiller_OzgecmisId",
                table: "OzgecmisYabanciDiller",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisYabanciDiller_YabanciDilId",
                table: "OzgecmisYabanciDiller",
                column: "YabanciDilId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisYazilimDiller_OzgecmisId",
                table: "OzgecmisYazilimDiller",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_OzgecmisYazilimDiller_YazilimDilId",
                table: "OzgecmisYazilimDiller",
                column: "YazilimDilId");

            migrationBuilder.CreateIndex(
                name: "IX_Referanlar_OzgecmisId",
                table: "Referanlar",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_Sertifikalar_OzgecmisId",
                table: "Sertifikalar",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinavlar_OzgecmisId",
                table: "Sinavlar",
                column: "OzgecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketIlanlari_IlanId",
                table: "SirketIlanlari",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketIlanlari_SirketId",
                table: "SirketIlanlari",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_Sirketler_UyelikId",
                table: "Sirketler",
                column: "UyelikId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketSehirleri_SehirId",
                table: "SirketSehirleri",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketSehirleri_SirketId",
                table: "SirketSehirleri",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketSektorleri_SektorId",
                table: "SirketSektorleri",
                column: "SektorId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketSektorleri_SirketId",
                table: "SirketSektorleri",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketSosyalMedyalar_SirketId",
                table: "SirketSosyalMedyalar",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketSosyalMedyalar_SosyalMedyaId",
                table: "SirketSosyalMedyalar",
                column: "SosyalMedyaId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketTakipleri_SirketId",
                table: "SirketTakipleri",
                column: "SirketId");

            migrationBuilder.CreateIndex(
                name: "IX_SirketTakipleri_UyelikId",
                table: "SirketTakipleri",
                column: "UyelikId");

            migrationBuilder.CreateIndex(
                name: "IX_Uyelikler_RolId",
                table: "Uyelikler",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basvuranlar");

            migrationBuilder.DropTable(
                name: "Egitimler");

            migrationBuilder.DropTable(
                name: "EkBilgiler");

            migrationBuilder.DropTable(
                name: "FavoriIlanlar");

            migrationBuilder.DropTable(
                name: "Hakkimda");

            migrationBuilder.DropTable(
                name: "Hobiler");

            migrationBuilder.DropTable(
                name: "IlaniYabanciDilleri");

            migrationBuilder.DropTable(
                name: "IlanKayitlari");

            migrationBuilder.DropTable(
                name: "IsDeneyimleri");

            migrationBuilder.DropTable(
                name: "IsIlaniCalismaSekilleri");

            migrationBuilder.DropTable(
                name: "IsIlaniCinsiyetler");

            migrationBuilder.DropTable(
                name: "IsIlaniDeneyimSureleri");

            migrationBuilder.DropTable(
                name: "IsIlaniDurumlari");

            migrationBuilder.DropTable(
                name: "IsIlaniMezuniyetleri");

            migrationBuilder.DropTable(
                name: "IsIlaniSehirler");

            migrationBuilder.DropTable(
                name: "IsIlaniSektorler");

            migrationBuilder.DropTable(
                name: "IsIlaniUlkeler");

            migrationBuilder.DropTable(
                name: "MulakatListeleri");

            migrationBuilder.DropTable(
                name: "OzgecmisHavuzlari");

            migrationBuilder.DropTable(
                name: "OzgecmisSehirleri");

            migrationBuilder.DropTable(
                name: "OzgecmisSosyalMedyalar");

            migrationBuilder.DropTable(
                name: "OzgecmisYabanciDiller");

            migrationBuilder.DropTable(
                name: "OzgecmisYazilimDiller");

            migrationBuilder.DropTable(
                name: "Referanlar");

            migrationBuilder.DropTable(
                name: "Sertifikalar");

            migrationBuilder.DropTable(
                name: "Sinavlar");

            migrationBuilder.DropTable(
                name: "SirketIlanlari");

            migrationBuilder.DropTable(
                name: "SirketSehirleri");

            migrationBuilder.DropTable(
                name: "SirketSektorleri");

            migrationBuilder.DropTable(
                name: "SirketSosyalMedyalar");

            migrationBuilder.DropTable(
                name: "SirketTakipleri");

            migrationBuilder.DropTable(
                name: "Bolumler");

            migrationBuilder.DropTable(
                name: "CalismaSekilleri");

            migrationBuilder.DropTable(
                name: "DeneyimSureleri");

            migrationBuilder.DropTable(
                name: "IlanDurumlari");

            migrationBuilder.DropTable(
                name: "Mezuniyetler");

            migrationBuilder.DropTable(
                name: "Mulakatlar");

            migrationBuilder.DropTable(
                name: "YabanciDiller");

            migrationBuilder.DropTable(
                name: "YazilimDiller");

            migrationBuilder.DropTable(
                name: "Ozgecmisler");

            migrationBuilder.DropTable(
                name: "Ilanlar");

            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Sektorler");

            migrationBuilder.DropTable(
                name: "SosyalMedyalar");

            migrationBuilder.DropTable(
                name: "Sirketler");

            migrationBuilder.DropTable(
                name: "Fakulteler");

            migrationBuilder.DropTable(
                name: "Cinsiyetler");

            migrationBuilder.DropTable(
                name: "Ulkeler");

            migrationBuilder.DropTable(
                name: "Uyelikler");

            migrationBuilder.DropTable(
                name: "Universiteler");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
