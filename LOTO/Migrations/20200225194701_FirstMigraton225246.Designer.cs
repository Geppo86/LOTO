﻿// <auto-generated />
using System;
using LOTO.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LOTO.Migrations
{
    [DbContext(typeof(LOTOContext))]
    [Migration("20200225194701_FirstMigraton225246")]
    partial class FirstMigraton225246
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LOTO.Models.LockoutPoint", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmationDeviceNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationDeviceNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationDeviceNumber3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnergyMagnitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnergyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LockoutPointPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LockoutTagNumber")
                        .HasColumnType("int");

                    b.Property<string>("MethodToIsolate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodToVerify")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LockoutPoint");
                });

            modelBuilder.Entity("LOTO.Models.Machine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Building")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineOemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ZoneId");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("LOTO.Models.MachineZone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HatchingFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZoneMapFile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MachineZone");
                });

            modelBuilder.Entity("LOTO.Models.Procedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LockoutpointID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("step")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LockoutpointID");

                    b.ToTable("Procedure");
                });

            modelBuilder.Entity("LOTO.Models.Task", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProcedureId")
                        .HasColumnType("int");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProcedureId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("LOTO.Models.Machine", b =>
                {
                    b.HasOne("LOTO.Models.MachineZone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId");
                });

            modelBuilder.Entity("LOTO.Models.Procedure", b =>
                {
                    b.HasOne("LOTO.Models.LockoutPoint", "Lockoutpoint")
                        .WithMany()
                        .HasForeignKey("LockoutpointID");
                });

            modelBuilder.Entity("LOTO.Models.Task", b =>
                {
                    b.HasOne("LOTO.Models.Procedure", "Procedure")
                        .WithMany()
                        .HasForeignKey("ProcedureId");

                    b.HasOne("LOTO.Models.MachineZone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId");
                });
#pragma warning restore 612, 618
        }
    }
}
