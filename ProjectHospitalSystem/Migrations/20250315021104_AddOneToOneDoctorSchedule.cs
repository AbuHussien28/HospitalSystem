using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectHospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneDoctorSchedule : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_DoctorDetailsId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "DoctorDetailsId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalRecords");

            migrationBuilder.AddColumn<int>(
                name: "medicalRecordId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_medicalRecordId",
                table: "Appointments",
                column: "medicalRecordId",
                unique: true,
                filter: "[medicalRecordId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_MedicalRecords_medicalRecordId",
                table: "Appointments",
                column: "medicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "MedicalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_MedicalRecords_medicalRecordId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_medicalRecordId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "medicalRecordId",
                table: "Appointments");

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
        }
    }
}
