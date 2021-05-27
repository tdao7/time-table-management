using Microsoft.EntityFrameworkCore.Migrations;

namespace JwtAuthDemo.Migrations
{
    public partial class add_schedule_models_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T0Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T2Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T3Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T4Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T5Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T6Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_TimeTables_T7Id",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleRooms_Schedule_ScheduleId",
                table: "ScheduleRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTableClassrooms_Schedule_ScheduleId",
                table: "TimeTableClassrooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T7Id",
                table: "Schedules",
                newName: "IX_Schedules_T7Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T6Id",
                table: "Schedules",
                newName: "IX_Schedules_T6Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T5Id",
                table: "Schedules",
                newName: "IX_Schedules_T5Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T4Id",
                table: "Schedules",
                newName: "IX_Schedules_T4Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T3Id",
                table: "Schedules",
                newName: "IX_Schedules_T3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T2Id",
                table: "Schedules",
                newName: "IX_Schedules_T2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_T0Id",
                table: "Schedules",
                newName: "IX_Schedules_T0Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleRooms_Schedules_ScheduleId",
                table: "ScheduleRooms",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T0Id",
                table: "Schedules",
                column: "T0Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T2Id",
                table: "Schedules",
                column: "T2Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T3Id",
                table: "Schedules",
                column: "T3Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T4Id",
                table: "Schedules",
                column: "T4Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T5Id",
                table: "Schedules",
                column: "T5Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T6Id",
                table: "Schedules",
                column: "T6Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_TimeTables_T7Id",
                table: "Schedules",
                column: "T7Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTableClassrooms_Schedules_ScheduleId",
                table: "TimeTableClassrooms",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleRooms_Schedules_ScheduleId",
                table: "ScheduleRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T0Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T2Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T3Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T4Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T5Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T6Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_TimeTables_T7Id",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeTableClassrooms_Schedules_ScheduleId",
                table: "TimeTableClassrooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T7Id",
                table: "Schedule",
                newName: "IX_Schedule_T7Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T6Id",
                table: "Schedule",
                newName: "IX_Schedule_T6Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T5Id",
                table: "Schedule",
                newName: "IX_Schedule_T5Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T4Id",
                table: "Schedule",
                newName: "IX_Schedule_T4Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T3Id",
                table: "Schedule",
                newName: "IX_Schedule_T3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T2Id",
                table: "Schedule",
                newName: "IX_Schedule_T2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_T0Id",
                table: "Schedule",
                newName: "IX_Schedule_T0Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T0Id",
                table: "Schedule",
                column: "T0Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T2Id",
                table: "Schedule",
                column: "T2Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T3Id",
                table: "Schedule",
                column: "T3Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T4Id",
                table: "Schedule",
                column: "T4Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T5Id",
                table: "Schedule",
                column: "T5Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T6Id",
                table: "Schedule",
                column: "T6Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_TimeTables_T7Id",
                table: "Schedule",
                column: "T7Id",
                principalTable: "TimeTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleRooms_Schedule_ScheduleId",
                table: "ScheduleRooms",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeTableClassrooms_Schedule_ScheduleId",
                table: "TimeTableClassrooms",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
