using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class createImgclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountProduct",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "IDProduct",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "NameProduct",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "PriceProduct",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "SumPriceProduct",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "UnitProduct",
                table: "CartProduct");

            migrationBuilder.RenameColumn(
                name: "Cartid",
                table: "CartProduct",
                newName: "Imgid");

            migrationBuilder.AddColumn<byte[]>(
                name: "Img",
                table: "CartProduct",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "Imgname",
                table: "CartProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "Imgname",
                table: "CartProduct");

            migrationBuilder.RenameColumn(
                name: "Imgid",
                table: "CartProduct",
                newName: "Cartid");

            migrationBuilder.AddColumn<int>(
                name: "AmountProduct",
                table: "CartProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDProduct",
                table: "CartProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameProduct",
                table: "CartProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "CartProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceProduct",
                table: "CartProduct",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SumPriceProduct",
                table: "CartProduct",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitProduct",
                table: "CartProduct",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
