using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace karbantartas.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Feladatok",
                columns: table => new
                {
                    fid = table.Column<long>(name: "f_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fnev = table.Column<string>(name: "f_nev", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    leiras = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feladatok", x => x.fid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Karbantartok",
                columns: table => new
                {
                    karbid = table.Column<long>(name: "karb_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    karbnev = table.Column<string>(name: "karb_nev", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    karbfiz = table.Column<long>(name: "karb_fiz", type: "bigint", nullable: true),
                    karbbeoszt = table.Column<string>(name: "karb_beoszt", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    karbtipus = table.Column<string>(name: "karb_tipus", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karbantartok", x => x.karbid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Anyagszukseglet",
                columns: table => new
                {
                    aid = table.Column<long>(name: "a_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fidikfid = table.Column<long>(name: "f_id_ikf_id", type: "bigint", nullable: true),
                    anev = table.Column<string>(name: "a_nev", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adb = table.Column<long>(name: "a_db", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anyagszukseglet", x => x.aid);
                    table.ForeignKey(
                        name: "FK_Anyagszukseglet_Feladatok_f_id_ikf_id",
                        column: x => x.fidikfid,
                        principalTable: "Feladatok",
                        principalColumn: "f_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Karbantartasok",
                columns: table => new
                {
                    kid = table.Column<long>(name: "k_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    karbidikkid = table.Column<long>(name: "karb_id_ikk_id", type: "bigint", nullable: true),
                    fidikfid = table.Column<long>(name: "f_id_ikf_id", type: "bigint", nullable: true),
                    kkezd = table.Column<DateTime>(name: "k_kezd", type: "datetime(6)", nullable: true),
                    kvege = table.Column<DateTime>(name: "k_vege", type: "datetime(6)", nullable: true),
                    ktipus = table.Column<string>(name: "k_tipus", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karbantartasok", x => x.kid);
                    table.ForeignKey(
                        name: "FK_Karbantartasok_Feladatok_f_id_ikf_id",
                        column: x => x.fidikfid,
                        principalTable: "Feladatok",
                        principalColumn: "f_id");
                    table.ForeignKey(
                        name: "FK_Karbantartasok_Karbantartasok_karb_id_ikk_id",
                        column: x => x.karbidikkid,
                        principalTable: "Karbantartasok",
                        principalColumn: "k_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Anyagszukseglet_f_id_ikf_id",
                table: "Anyagszukseglet",
                column: "f_id_ikf_id");

            migrationBuilder.CreateIndex(
                name: "IX_Karbantartasok_f_id_ikf_id",
                table: "Karbantartasok",
                column: "f_id_ikf_id");

            migrationBuilder.CreateIndex(
                name: "IX_Karbantartasok_karb_id_ikk_id",
                table: "Karbantartasok",
                column: "karb_id_ikk_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anyagszukseglet");

            migrationBuilder.DropTable(
                name: "Karbantartasok");

            migrationBuilder.DropTable(
                name: "Karbantartok");

            migrationBuilder.DropTable(
                name: "Feladatok");
        }
    }
}
