﻿// <auto-generated />
using System;
using Hospital.Data.HospitalDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hospital.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Domain.Entitys.DiseaseCauses.DiseaseCause", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("SicknessId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SicknessId");

                    b.ToTable("DiseaseCauses");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Doctor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Worklocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Files.Picture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.HealthyFoods.HealthyFood", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("SicknessId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SicknessId");

                    b.ToTable("HealthyFoods");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Hospitals.Infirmary", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<long?>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Infirations");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Sickness", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Sickness");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Symptom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.TreatmentMethods.TreatmentMethod", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("SicknessId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SicknessId");

                    b.ToTable("TreatmentMethods");
                });

            modelBuilder.Entity("SicknessSymptom", b =>
                {
                    b.Property<long>("SymptomId")
                        .HasColumnType("bigint");

                    b.Property<long>("sicknessId")
                        .HasColumnType("bigint");

                    b.HasKey("SymptomId", "sicknessId");

                    b.HasIndex("sicknessId");

                    b.ToTable("SicknessSymptom");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.DiseaseCauses.DiseaseCause", b =>
                {
                    b.HasOne("Hospital.Domain.Entitys.Sickness", null)
                        .WithMany("DiseaseCause")
                        .HasForeignKey("SicknessId");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.HealthyFoods.HealthyFood", b =>
                {
                    b.HasOne("Hospital.Domain.Entitys.Sickness", null)
                        .WithMany("HealthyFood")
                        .HasForeignKey("SicknessId");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Hospitals.Infirmary", b =>
                {
                    b.HasOne("Hospital.Domain.Entitys.Doctor", null)
                        .WithMany("infirmaries")
                        .HasForeignKey("DoctorId");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.TreatmentMethods.TreatmentMethod", b =>
                {
                    b.HasOne("Hospital.Domain.Entitys.Sickness", null)
                        .WithMany("TreatmentMethod")
                        .HasForeignKey("SicknessId");
                });

            modelBuilder.Entity("SicknessSymptom", b =>
                {
                    b.HasOne("Hospital.Domain.Entitys.Symptom", null)
                        .WithMany()
                        .HasForeignKey("SymptomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Domain.Entitys.Sickness", null)
                        .WithMany()
                        .HasForeignKey("sicknessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Doctor", b =>
                {
                    b.Navigation("infirmaries");
                });

            modelBuilder.Entity("Hospital.Domain.Entitys.Sickness", b =>
                {
                    b.Navigation("DiseaseCause");

                    b.Navigation("HealthyFood");

                    b.Navigation("TreatmentMethod");
                });
#pragma warning restore 612, 618
        }
    }
}
