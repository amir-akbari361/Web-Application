using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dargahPardakhts",
                columns: table => new
                {
                    DargahPardakht_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DargahPardakht_NameBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DargahPardakht_Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dargahPardakhts", x => x.DargahPardakht_ID);
                });

            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otagh = table.Column<int>(type: "int", nullable: false),
                    money = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bathroom = table.Column<int>(type: "int", nullable: false),
                    urlpic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    Hotel_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Hotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jozeyat_Gheymat = table.Column<long>(type: "bigint", nullable: false),
                    ZamanShoroa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZamanPayan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Faal = table.Column<bool>(type: "bit", nullable: false),
                    Tozihat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bathroom = table.Column<int>(type: "int", nullable: false),
                    urlpic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tedad_takht = table.Column<int>(type: "int", nullable: false),
                    zarfiat = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.Hotel_ID);
                });

            migrationBuilder.CreateTable(
                name: "Jostejo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    NameHotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GheymatYekShab = table.Column<long>(type: "bigint", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tozihat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bathroom = table.Column<int>(type: "int", nullable: false),
                    tedad_takht = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jostejo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tanzimatEmails",
                columns: table => new
                {
                    Eamil_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eamil_EmailSend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eamil_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eamil_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eamil_Port = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eamil_Smtp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tanzimatEmails", x => x.Eamil_ID);
                });

            migrationBuilder.CreateTable(
                name: "nazarats",
                columns: table => new
                {
                    Nazarat_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazarat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazarat_Matn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazarat_Zaman = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazarat_HotelID = table.Column<int>(type: "int", nullable: false),
                    Nazarat_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nazarats", x => x.Nazarat_ID);
                    table.ForeignKey(
                        name: "FK_nazarats_hotels_Nazarat_HotelID",
                        column: x => x.Nazarat_HotelID,
                        principalTable: "hotels",
                        principalColumn: "Hotel_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rezervHotels",
                columns: table => new
                {
                    Rezerv_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rezerv_Jensiat = table.Column<int>(type: "int", nullable: false),
                    Rezerv_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rezerv_NameKhanevadgi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rezerv_Codemeli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rezerv_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rezerv_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rezerv_TeadadNafarat = table.Column<int>(type: "int", nullable: false),
                    Rezerv_TeadadOthagh = table.Column<int>(type: "int", nullable: false),
                    Rezerv_Vorod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rezerv_Khoroj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rezerv_Mablagh = table.Column<long>(type: "bigint", nullable: false),
                    Rezerv_Vazeyt = table.Column<bool>(type: "bit", nullable: false),
                    Rezerv_Roz = table.Column<int>(type: "int", nullable: false),
                    Rezerv_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hotel_ID = table.Column<int>(type: "int", nullable: true),
                    Hotels = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rezervHotels", x => x.Rezerv_ID);
                    table.ForeignKey(
                        name: "FK_rezervHotels_hotels_Hotels",
                        column: x => x.Hotels,
                        principalTable: "hotels",
                        principalColumn: "Hotel_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pardakhtHotels",
                columns: table => new
                {
                    Pardakh_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pardakh_IDHotel = table.Column<int>(type: "int", nullable: false),
                    Pardakh_ZamanVariz = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pardakh_Pigiry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pardakh_Mablagh = table.Column<long>(type: "bigint", nullable: false),
                    Pardakh_Vazeiat = table.Column<bool>(type: "bit", nullable: false),
                    Pardakh_Trakonesh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pardakh_Marjaa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pardakh_Rezerv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pardakhtHotels", x => x.Pardakh_ID);
                    table.ForeignKey(
                        name: "FK_pardakhtHotels_hotels_Pardakh_IDHotel",
                        column: x => x.Pardakh_IDHotel,
                        principalTable: "hotels",
                        principalColumn: "Hotel_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pardakhtHotels_rezervHotels_Pardakh_Rezerv",
                        column: x => x.Pardakh_Rezerv,
                        principalTable: "rezervHotels",
                        principalColumn: "Rezerv_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nazarats_Nazarat_HotelID",
                table: "nazarats",
                column: "Nazarat_HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_pardakhtHotels_Pardakh_IDHotel",
                table: "pardakhtHotels",
                column: "Pardakh_IDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_pardakhtHotels_Pardakh_Rezerv",
                table: "pardakhtHotels",
                column: "Pardakh_Rezerv");

            migrationBuilder.CreateIndex(
                name: "IX_rezervHotels_Hotels",
                table: "rezervHotels",
                column: "Hotels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dargahPardakhts");

            migrationBuilder.DropTable(
                name: "HotelRooms");

            migrationBuilder.DropTable(
                name: "Jostejo");

            migrationBuilder.DropTable(
                name: "nazarats");

            migrationBuilder.DropTable(
                name: "pardakhtHotels");

            migrationBuilder.DropTable(
                name: "tanzimatEmails");

            migrationBuilder.DropTable(
                name: "rezervHotels");

            migrationBuilder.DropTable(
                name: "hotels");
        }
    }
}
