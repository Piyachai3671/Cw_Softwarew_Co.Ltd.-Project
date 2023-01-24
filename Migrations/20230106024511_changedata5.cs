using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class changedata5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    Cartid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDProduct = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountProduct = table.Column<int>(type: "int", nullable: true),
                    UnitProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<double>(type: "float", nullable: true),
                    SumPriceProduct = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => x.Cartid);
                });

            migrationBuilder.CreateTable(
                name: "GroupMember",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMember", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IDProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RemainderProduct = table.Column<int>(type: "int", nullable: true),
                    UnitProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IDProduct);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropTable(
                name: "GroupMember");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
