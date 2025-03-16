using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectHospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Doctors_DoctorDetailsId",
                table: "MedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Patients_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorDetailsId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorDetailsId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_DoctorDetailsId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "DoctorDetailsId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorDetailsId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalRecords");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorDetailsId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorDetailsId",
                table: "MedicalRecords",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "MedicalRecords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorDetailsId",
                table: "Patients",
                column: "DoctorDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_DoctorDetailsId",
                table: "MedicalRecords",
                column: "DoctorDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Doctors_DoctorDetailsId",
                table: "MedicalRecords",
                column: "DoctorDetailsId",
                principalTable: "Doctors",
                principalColumn: "DoctorDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Patients_PatientId",
                table: "MedicalRecords",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorDetailsId",
                table: "Patients",
                column: "DoctorDetailsId",
                principalTable: "Doctors",
                principalColumn: "DoctorDetailsId");
        }
    }
}
