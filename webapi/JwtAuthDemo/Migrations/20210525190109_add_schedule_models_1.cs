using Microsoft.EntityFrameworkCore.Migrations;

namespace JwtAuthDemo.Migrations
{
    public partial class add_schedule_models_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleRooms_Classrooms_ClassroomId",
                table: "ScheduleRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleRooms_Rooms_RoomId",
                table: "ScheduleRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduleRooms",
                table: "ScheduleRooms");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleRooms_RoomId",
                table: "ScheduleRooms");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "ScheduleRooms");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "ScheduleRooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduleRooms",
                table: "ScheduleRooms",
                columns: new[] { "RoomId", "ScheduleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleRooms_Rooms_RoomId",
                table: "ScheduleRooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleRooms_Rooms_RoomId",
                table: "ScheduleRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduleRooms",
                table: "ScheduleRooms");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "ScheduleRooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "ScheduleRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduleRooms",
                table: "ScheduleRooms",
                columns: new[] { "ClassroomId", "ScheduleId" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleRooms_RoomId",
                table: "ScheduleRooms",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleRooms_Classrooms_ClassroomId",
                table: "ScheduleRooms",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleRooms_Rooms_RoomId",
                table: "ScheduleRooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
