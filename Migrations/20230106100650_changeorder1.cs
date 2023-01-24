using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class changeorder1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_TableOrder_TableOrderOrderID",
                table: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableOrder",
                table: "TableOrder");

            migrationBuilder.RenameTable(
                name: "TableOrder",
                newName: "Order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Order_TableOrderOrderID",
                table: "CartProduct",
                column: "TableOrderOrderID",
                principalTable: "Order",
                principalColumn: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Order_TableOrderOrderID",
                table: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "TableOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableOrder",
                table: "TableOrder",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_TableOrder_TableOrderOrderID",
                table: "CartProduct",
                column: "TableOrderOrderID",
                principalTable: "TableOrder",
                principalColumn: "OrderID");
        }
    }
}
