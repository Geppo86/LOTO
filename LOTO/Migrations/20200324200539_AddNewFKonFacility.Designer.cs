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
    [Migration("20200324200539_AddNewFKonFacility")]
    partial class AddNewFKonFacility
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LOTO.Models.Building", b =>
                {
                    b.Property<int>("BID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FID1")
                        .HasColumnType("int");

                    b.Property<string>("Map")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameBuilding")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BID");

                    b.HasIndex("FID1");

                    b.ToTable("Building");
                });

            modelBuilder.Entity("LOTO.Models.ConfirmationPoint", b =>
                {
                    b.Property<int>("CPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmationDeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationDevicePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationDeviceSafeStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationDeviceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationTagNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CPID");

                    b.ToTable("ConfirmationPoint");
                });

            modelBuilder.Entity("LOTO.Models.EnergyType", b =>
                {
                    b.Property<int>("ETID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnergyTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ETID");

                    b.ToTable("EnergyType");
                });

            modelBuilder.Entity("LOTO.Models.Facility", b =>
                {
                    b.Property<int>("FID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacilityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SID1")
                        .HasColumnType("int");

                    b.HasKey("FID");

                    b.HasIndex("SID1");

                    b.ToTable("Facility");
                });

            modelBuilder.Entity("LOTO.Models.LockoutPoint", b =>
                {
                    b.Property<int>("LPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CPID1")
                        .HasColumnType("int");

                    b.Property<string>("Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ETID1")
                        .HasColumnType("int");

                    b.Property<string>("EnergyMagnitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LockoutPointPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LockoutTagNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodToIsolate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodToVerify")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LPID");

                    b.HasIndex("CPID1");

                    b.HasIndex("ETID1");

                    b.ToTable("LockoutPoint");
                });

            modelBuilder.Entity("LOTO.Models.Machine", b =>
                {
                    b.Property<int>("MID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BID1")
                        .HasColumnType("int");

                    b.Property<string>("CustomerDefinedArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineNamePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineOemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachinePictureFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineSerialName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MID");

                    b.HasIndex("BID1");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("LOTO.Models.MachineZone", b =>
                {
                    b.Property<int>("MZID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MID1")
                        .HasColumnType("int");

                    b.Property<string>("MachineZoneDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameMachineZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZoneMapFile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MZID");

                    b.HasIndex("MID1");

                    b.ToTable("MachineZone");
                });

            modelBuilder.Entity("LOTO.Models.Procedure", b =>
                {
                    b.Property<int>("PID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateLastAudit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotoOrApm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcedureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UID1")
                        .HasColumnType("int");

                    b.HasKey("PID");

                    b.HasIndex("UID1");

                    b.ToTable("Procedure");
                });

            modelBuilder.Entity("LOTO.Models.Site", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SiteAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SID");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("LOTO.Models.Task", b =>
                {
                    b.Property<int>("TID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MZID1")
                        .HasColumnType("int");

                    b.Property<int?>("PID1")
                        .HasColumnType("int");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TID");

                    b.HasIndex("MZID1");

                    b.HasIndex("PID1");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("LOTO.Models.User", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("LOTO.Models.Building", b =>
                {
                    b.HasOne("LOTO.Models.Facility", "FID")
                        .WithMany()
                        .HasForeignKey("FID1");
                });

            modelBuilder.Entity("LOTO.Models.Facility", b =>
                {
                    b.HasOne("LOTO.Models.Site", "SID")
                        .WithMany()
                        .HasForeignKey("SID1");
                });

            modelBuilder.Entity("LOTO.Models.LockoutPoint", b =>
                {
                    b.HasOne("LOTO.Models.ConfirmationPoint", "CPID")
                        .WithMany()
                        .HasForeignKey("CPID1");

                    b.HasOne("LOTO.Models.EnergyType", "ETID")
                        .WithMany()
                        .HasForeignKey("ETID1");
                });

            modelBuilder.Entity("LOTO.Models.Machine", b =>
                {
                    b.HasOne("LOTO.Models.Building", "BID")
                        .WithMany()
                        .HasForeignKey("BID1");
                });

            modelBuilder.Entity("LOTO.Models.MachineZone", b =>
                {
                    b.HasOne("LOTO.Models.Machine", "MID")
                        .WithMany()
                        .HasForeignKey("MID1");
                });

            modelBuilder.Entity("LOTO.Models.Procedure", b =>
                {
                    b.HasOne("LOTO.Models.User", "UID")
                        .WithMany()
                        .HasForeignKey("UID1");
                });

            modelBuilder.Entity("LOTO.Models.Task", b =>
                {
                    b.HasOne("LOTO.Models.MachineZone", "MZID")
                        .WithMany()
                        .HasForeignKey("MZID1");

                    b.HasOne("LOTO.Models.Procedure", "PID")
                        .WithMany()
                        .HasForeignKey("PID1");
                });
#pragma warning restore 612, 618
        }
    }
}