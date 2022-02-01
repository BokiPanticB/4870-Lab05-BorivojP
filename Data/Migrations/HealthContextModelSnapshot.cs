﻿// <auto-generated />
using System;
using HealthAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthAPI.Data.Migrations
{
    [DbContext(typeof(HealthContext))]
    partial class HealthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthAPI.Models.Ailment", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Ailment");
                });

            modelBuilder.Entity("HealthAPI.Models.Medication", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Doses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("HealthAPI.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("HealthAPI.Models.Ailment", b =>
                {
                    b.HasOne("HealthAPI.Models.Patient", null)
                        .WithMany("Ailments")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HealthAPI.Models.Medication", b =>
                {
                    b.HasOne("HealthAPI.Models.Patient", null)
                        .WithMany("Medications")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HealthAPI.Models.Patient", b =>
                {
                    b.Navigation("Ailments");

                    b.Navigation("Medications");
                });
#pragma warning restore 612, 618
        }
    }
}
