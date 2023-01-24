using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CWordermedicine.Migrations
{
    /// <inheritdoc />
    public partial class updateusertel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportUserID = table.Column<int>(type: "int", nullable: false),
                    ReportUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportOrderID = table.Column<int>(type: "int", nullable: false),
                    ReportOrderItemID = table.Column<int>(type: "int", nullable: false),
                    ReportGroupID = table.Column<int>(type: "int", nullable: false),
                    ReportDepartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportPriceSum = table.Column<double>(type: "float", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "User");
        }
    }
}
