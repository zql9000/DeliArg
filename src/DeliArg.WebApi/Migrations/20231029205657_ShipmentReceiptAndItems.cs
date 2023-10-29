using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliArg.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class ShipmentReceiptAndItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShipmentReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ShipmentReceiptStatusId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentReceipts_ShipmentReceiptStatuses_ShipmentReceiptStatusId",
                        column: x => x.ShipmentReceiptStatusId,
                        principalTable: "ShipmentReceiptStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentReceipts_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentReceipts_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentReceiptItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipmentReceiptId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentReceiptItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentReceiptItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentReceiptItem_ShipmentReceipts_ShipmentReceiptId",
                        column: x => x.ShipmentReceiptId,
                        principalTable: "ShipmentReceipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentReceiptItem_ProductId",
                table: "ShipmentReceiptItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentReceiptItem_ShipmentReceiptId",
                table: "ShipmentReceiptItem",
                column: "ShipmentReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentReceipts_ShipmentReceiptStatusId",
                table: "ShipmentReceipts",
                column: "ShipmentReceiptStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentReceipts_StoreId",
                table: "ShipmentReceipts",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentReceipts_WarehouseId",
                table: "ShipmentReceipts",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipmentReceiptItem");

            migrationBuilder.DropTable(
                name: "ShipmentReceipts");
        }
    }
}
