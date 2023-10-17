using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elev8_Final.Data.Migrations
{
    public partial class CT7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_AspNetUsers_UserId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Courses_CourseID",
                table: "Enrollment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                newName: "Enrollments2");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_UserId",
                table: "Enrollments2",
                newName: "IX_Enrollments2_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_CourseID",
                table: "Enrollments2",
                newName: "IX_Enrollments2_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments2",
                table: "Enrollments2",
                column: "EnrollmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments2_AspNetUsers_UserId",
                table: "Enrollments2",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments2_Courses_CourseID",
                table: "Enrollments2",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments2_AspNetUsers_UserId",
                table: "Enrollments2");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments2_Courses_CourseID",
                table: "Enrollments2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments2",
                table: "Enrollments2");

            migrationBuilder.RenameTable(
                name: "Enrollments2",
                newName: "Enrollment");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments2_UserId",
                table: "Enrollment",
                newName: "IX_Enrollment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments2_CourseID",
                table: "Enrollment",
                newName: "IX_Enrollment_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollment",
                table: "Enrollment",
                column: "EnrollmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_AspNetUsers_UserId",
                table: "Enrollment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Courses_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }
    }
}
