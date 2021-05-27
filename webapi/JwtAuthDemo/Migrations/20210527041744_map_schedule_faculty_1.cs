using Microsoft.EntityFrameworkCore.Migrations;

namespace JwtAuthDemo.Migrations
{
    public partial class map_schedule_faculty_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "TimeTables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_SubjectId",
                table: "TimeTables",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTables_Subjects_SubjectId",
                table: "TimeTables",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeTables_Subjects_SubjectId",
                table: "TimeTables");

            migrationBuilder.DropIndex(
                name: "IX_TimeTables_SubjectId",
                table: "TimeTables");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "TimeTables");
        }
    }
}
