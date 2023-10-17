using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elev8_Final.Data.Migrations
{
    public partial class CT6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Enrollment",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enrollment",
                newName: "ID");
        }
    }
}
