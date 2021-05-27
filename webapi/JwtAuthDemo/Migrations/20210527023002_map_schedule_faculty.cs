using Microsoft.EntityFrameworkCore.Migrations;

namespace JwtAuthDemo.Migrations
{
    public partial class map_schedule_faculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_Faculties_FacultyId",
                table: "TimeTables");

            migrationBuilder.DropIndex(
                name: "IX_TimeTables_FacultyId",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "TimeTables");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_FacultyId",
                table: "Schedules",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Faculties_FacultyId",
                table: "Schedules",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Faculties_FacultyId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_FacultyId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Schedules");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "TimeTables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_FacultyId",
                table: "TimeTables",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTables_Faculties_FacultyId",
                table: "TimeTables",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
