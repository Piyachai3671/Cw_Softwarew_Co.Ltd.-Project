using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class changeorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TableOrderOrderID",
                table: "CartProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TableOrder",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderAmount = table.Column<int>(type: "int", nullable: false),
                    OrderSumPrice = table.Column<double>(type: "float", nullable: false),
                    OrderDateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderUserID = table.Column<int>(type: "int", nullable: false),
                    OrderUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderGroupID = table.Column<int>(type: "int", nullable: false),
                    Cartid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableOrder", x => x.OrderID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_TableOrderOrderID",
                table: "CartProduct",
                column: "TableOrderOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_TableOrder_TableOrderOrderID",
                table: "CartProduct",
                column: "TableOrderOrderID",
                principalTable: "TableOrder",
                principalColumn: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_TableOrder_TableOrderOrderID",
                table: "CartProduct");

            migrationBuilder.DropTable(
                name: "TableOrder");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_TableOrderOrderID",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "TableOrderOrderID",
                table: "CartProduct");
        }
    }
}
