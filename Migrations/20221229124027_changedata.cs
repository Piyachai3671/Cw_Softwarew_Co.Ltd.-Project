using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class changedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TableUser",
                table: "TableUser");

            migrationBuilder.RenameTable(
                name: "TableUser",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "TableUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableUser",
                table: "TableUser",
                column: "UserID");
        }
    }
}
