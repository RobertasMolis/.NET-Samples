using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreShop.Migrations
{
    public partial class Shop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shopitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopitems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shopitems_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
             table: "Shops",
             columns: new[] { "Id", "Name" },
             values: new object[,]
             {
                    { 1, "Minima" },
                    { 2, "Media" }
             });

            migrationBuilder.InsertData(
                table: "Shopitems",
                columns: new[] { "Id", "ExpiryDate", "Name", "ShopId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 16, 17, 10, 58, 537, DateTimeKind.Utc).AddTicks(1605), "Kola", 1 },
                    { 2, new DateTime(2021, 12, 16, 17, 10, 58, 537, DateTimeKind.Utc).AddTicks(2007), "Bulka", 1 },
                    { 3, new DateTime(2021, 12, 16, 17, 10, 58, 537, DateTimeKind.Utc).AddTicks(2009), "Sviestas", 1 },
                    { 4, new DateTime(2021, 12, 16, 17, 10, 58, 537, DateTimeKind.Utc).AddTicks(2011), "Grietinė", 1 }
                });

         

            migrationBuilder.CreateIndex(
                name: "IX_Shopitems_ShopId",
                table: "Shopitems",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shopitems");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
