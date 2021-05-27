using Microsoft.EntityFrameworkCore.Migrations;

namespace JwtAuthDemo.Migrations
{
    public partial class map_schedule_faculty_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "TimeTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "TimeTables",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "TimeTables");
        }
    }
}
