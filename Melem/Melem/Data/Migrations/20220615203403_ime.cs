using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Melem.Data.Migrations
{
    public partial class ime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailAdresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    korisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    slikaProfila = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spol = table.Column<int>(type: "int", nullable: false),
                    tipKoze = table.Column<int>(type: "int", nullable: false),
                    IDRutine = table.Column<int>(type: "int", nullable: false),
                    tipStrucnjaka = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kviz",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnickiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kviz", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Odgovor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vrijednostOdgovora = table.Column<int>(type: "int", nullable: false),
                    IDPitanja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odgovor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Produkt",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cijena = table.Column<double>(type: "float", nullable: false),
                    ocjena = table.Column<double>(type: "float", nullable: false),
                    lokacija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slikaProdukta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slikaTestera = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkt", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rutina",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKorisnika = table.Column<int>(type: "int", nullable: false),
                    vrsta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zavrsnea = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutina", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RutinaKorisnika",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRutine = table.Column<int>(type: "int", nullable: false),
                    IDProdukta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutinaKorisnika", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sastojak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sastojak", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SastojakIzProdukta",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDProdukta = table.Column<int>(type: "int", nullable: false),
                    IDSastojka = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SastojakIzProdukta", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pitanje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tekstPitanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    odgovorID = table.Column<int>(type: "int", nullable: true),
                    IDKviza = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitanje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pitanje_Odgovor_odgovorID",
                        column: x => x.odgovorID,
                        principalTable: "Odgovor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pitanje_odgovorID",
                table: "Pitanje",
                column: "odgovorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Kviz");

            migrationBuilder.DropTable(
                name: "Pitanje");

            migrationBuilder.DropTable(
                name: "Produkt");

            migrationBuilder.DropTable(
                name: "Rutina");

            migrationBuilder.DropTable(
                name: "RutinaKorisnika");

            migrationBuilder.DropTable(
                name: "Sastojak");

            migrationBuilder.DropTable(
                name: "SastojakIzProdukta");

            migrationBuilder.DropTable(
                name: "Odgovor");
        }
    }
}
