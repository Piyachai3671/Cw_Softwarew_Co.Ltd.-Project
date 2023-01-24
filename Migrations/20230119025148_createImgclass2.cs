using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class createImgclass2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Saveimg",
                columns: table => new
                {
                    Imgid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imgname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saveimg", x => x.Imgid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saveimg");

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
    }
}
