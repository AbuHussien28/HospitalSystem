﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectHospitalSystem.Models;

#nullable disable

namespace ProjectHospitalSystem.Migrations
{
    [DbContext(typeof(HospitalSystemContext))]
    partial class HospitalSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectHospitalSystem.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("AppointmentDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("DoctorDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<bool>("ReminderSent")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("medicalRecordId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorDetailsId");

                    b.HasIndex("PatientId");

                    b.HasIndex("UserId");

                    b.HasIndex("medicalRecordId")
                        .IsUnique()
                        .HasFilter("[medicalRecordId] IS NOT NULL");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("DATEADD(DAY, 3, GETDATE())");

                    b.Property<DateTime>("GenertedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<decimal?>("LateFee")
                        .HasColumnType("money");

                    b.Property<decimal>("OriginalAmount")
                        .HasColumnType("money");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("AppointmentId")
                        .IsUnique()
                        .HasFilter("[AppointmentId] IS NOT NULL");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PatientId");

                    b.HasIndex("UserId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"));

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Dept_Desc")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("DoctorMgnId")
                        .HasColumnType("int");

                    b.Property<decimal>("FeeAmount")
                        .HasColumnType("money");

                    b.HasKey("DeptId");

                    b.HasIndex("DoctorMgnId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.DoctorDetails", b =>
                {
                    b.Property<int>("DoctorDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorDetailsId"));

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DoctorDetailsId");

                    b.HasIndex("DeptId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor_Schedule", b =>
                {
                    b.Property<int>("DoctorDetailsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduleDay")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorDetailsId", "ScheduleDay");

                    b.ToTable("Doctor_Schedules");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.MedicalRecord", b =>
                {
                    b.Property<int>("MedicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicalId"));

                    b.Property<DateTime>("DateOfVist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Diaqnois")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LabResult")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Prescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TreatmentDetails")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("MedicalId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<int?>("DoctorDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasDefaultValue("Male");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MedicalHistory")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("DoctorDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("Patients", t =>
                        {
                            t.HasCheckConstraint("CK_PatientGender", "Gender IN ('Male', 'Female')");
                        });
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("money");

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("BillId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.PaymentMethod", b =>
                {
                    b.Property<int>("paymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("paymentMethodId"));

                    b.Property<string>("paymentMethodName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("paymentMethodId");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValue("Doctor");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users", t =>
                        {
                            t.HasCheckConstraint("CK_User_Role", "Role IN ('Admin', 'Doctor', 'Receptionist')");
                        });
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Appointment", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.DoctorDetails", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorDetailsId");

                    b.HasOne("ProjectHospitalSystem.Models.Patient", "Patient")
                        .WithMany("Appointment")
                        .HasForeignKey("PatientId");

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("ProjectHospitalSystem.Models.MedicalRecord", "MedicalRecord")
                        .WithOne("Appointments")
                        .HasForeignKey("ProjectHospitalSystem.Models.Appointment", "medicalRecordId");

                    b.Navigation("Doctor");

                    b.Navigation("MedicalRecord");

                    b.Navigation("Patient");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Bill", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Appointment", "Appointment")
                        .WithOne("Bill")
                        .HasForeignKey("ProjectHospitalSystem.Models.Bill", "AppointmentId");

                    b.HasOne("ProjectHospitalSystem.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectHospitalSystem.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Department");

                    b.Navigation("Patient");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Department", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.DoctorDetails", "DoctorManger")
                        .WithMany()
                        .HasForeignKey("DoctorMgnId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("DoctorManger");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.DoctorDetails", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Department", "Dept")
                        .WithMany("Doctors")
                        .HasForeignKey("DeptId");

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithOne("doctorDetails")
                        .HasForeignKey("ProjectHospitalSystem.Models.DoctorDetails", "UserId");

                    b.Navigation("Dept");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor_Schedule", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.DoctorDetails", "Doctor")
                        .WithMany("doctorSchedule")
                        .HasForeignKey("DoctorDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.DoctorDetails", "DoctorDetails")
                        .WithMany()
                        .HasForeignKey("DoctorDetailsId");

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("DoctorDetails");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Payment", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Bill", "Bill")
                        .WithMany("Payments")
                        .HasForeignKey("BillId");

                    b.HasOne("ProjectHospitalSystem.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentMethodId");

                    b.Navigation("Bill");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Appointment", b =>
                {
                    b.Navigation("Bill")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Bill", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Department", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.DoctorDetails", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("doctorSchedule");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.MedicalRecord", b =>
                {
                    b.Navigation("Appointments")
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient", b =>
                {
                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.PaymentMethod", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("doctorDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
