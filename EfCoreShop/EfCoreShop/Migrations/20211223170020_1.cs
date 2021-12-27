using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreShop.Migrations
{
    public partial class _1 : Migration
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
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shopitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopItemTags",
                columns: table => new
                {
                    ShopItemId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItemTags", x => new { x.TagId, x.ShopItemId });
                    table.ForeignKey(
                        name: "FK_ShopItemTags_Shopitems_ShopItemId",
                        column: x => x.ShopItemId,
                        principalTable: "Shopitems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopItemTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pirmas" },
                    { 2, "Antras" }
                });

            migrationBuilder.InsertData(
                table: "Shopitems",
                columns: new[] { "Id", "ExpiryDate", "Name", "ShopId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 23, 17, 0, 20, 306, DateTimeKind.Utc).AddTicks(7471), "Kola", 1 },
                    { 3, new DateTime(2021, 12, 23, 17, 0, 20, 306, DateTimeKind.Utc).AddTicks(7998), "Sviestas", 1 },
                    { 4, new DateTime(2021, 12, 23, 17, 0, 20, 306, DateTimeKind.Utc).AddTicks(7999), "Grietinė", 1 },
                    { 2, new DateTime(2021, 12, 23, 17, 0, 20, 306, DateTimeKind.Utc).AddTicks(7996), "Bulka", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shopitems_ShopId",
                table: "Shopitems",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopItemTags_ShopItemId",
                table: "ShopItemTags",
                column: "ShopItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItemTags");

            migrationBuilder.DropTable(
                name: "Shopitems");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
