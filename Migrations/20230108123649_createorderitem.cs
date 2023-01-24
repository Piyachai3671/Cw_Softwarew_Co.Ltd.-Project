using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class createorderitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Order_TableOrderOrderID",
                table: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_TableOrderOrderID",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "Cartid",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "TableOrderOrderID",
                table: "CartProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cartid",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableOrderOrderID",
                table: "CartProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_TableOrderOrderID",
                table: "CartProduct",
                column: "TableOrderOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Order_TableOrderOrderID",
                table: "CartProduct",
                column: "TableOrderOrderID",
                principalTable: "Order",
                principalColumn: "OrderID");
        }
    }
}
