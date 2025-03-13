using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectHospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_UserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Doctors_DoctorDetailsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DoctorDetailsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DoctorDetailsId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users_UserId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "DoctorDetailsId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_DoctorDetailsId",
                table: "Users",
                column: "DoctorDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "Doctors",
                principalColumn: "DoctorDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Doctors_DoctorDetailsId",
                table: "Users",
                column: "DoctorDetailsId",
                principalTable: "Doctors",
                principalColumn: "DoctorDetailsId");
        }
    }
}
