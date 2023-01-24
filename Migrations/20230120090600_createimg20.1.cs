using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class createimg201 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saveimg");

            migrationBuilder.CreateTable(
                name: "Img",
                columns: table => new
                {
                    Imgid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imgname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Img", x => x.Imgid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Img");

            migrationBuilder.CreateTable(
                name: "Saveimg",
                columns: table => new
                {
                    Imgid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Imgname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saveimg", x => x.Imgid);
                });
        }
    }
}
