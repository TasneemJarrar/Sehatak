using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sehatak.Infrastructure.Data.Migrations.TenantMigrations
{
    /// <inheritdoc />
    public partial class AddChangesToTenant4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_follow_ups_appointments_ScheduledAppointmentId",
                table: "follow_ups");

            migrationBuilder.AddForeignKey(
                name: "FK_follow_ups_appointments_ScheduledAppointmentId",
                table: "follow_ups",
                column: "ScheduledAppointmentId",
                principalTable: "appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_follow_ups_appointments_ScheduledAppointmentId",
                table: "follow_ups");

            migrationBuilder.AddForeignKey(
                name: "FK_follow_ups_appointments_ScheduledAppointmentId",
                table: "follow_ups",
                column: "ScheduledAppointmentId",
                principalTable: "appointments",
                principalColumn: "Id");
        }
    }
}
