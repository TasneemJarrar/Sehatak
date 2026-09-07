using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sehatak.Infrastructure.Data.Migrations.TenantMigrations
{
    /// <inheritdoc />
    public partial class AddChangesToTenant2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_follow_ups_users_ReceptionistId",
                table: "follow_ups");

            migrationBuilder.AlterColumn<int>(
                name: "ReceptionistId",
                table: "follow_ups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_follow_ups_users_ReceptionistId",
                table: "follow_ups",
                column: "ReceptionistId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_follow_ups_users_ReceptionistId",
                table: "follow_ups");

            migrationBuilder.AlterColumn<int>(
                name: "ReceptionistId",
                table: "follow_ups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_follow_ups_users_ReceptionistId",
                table: "follow_ups",
                column: "ReceptionistId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
