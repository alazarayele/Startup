﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp.Infrastructure.Data;

#nullable disable

namespace asp.Migrations
{
    [DbContext(typeof(AspContext))]
    [Migration("20230717132224_interfaceAdding")]
    partial class interfaceAdding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("asp.Model.CapitalCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NumberOfPopulation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("CapitalCities");
                });

            modelBuilder.Entity("asp.Model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<int>("continent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("asp.Model.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreditHour")
                        .HasColumnType("int");

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("asp.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("asp.Model.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("asp.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Station")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("asp.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("asp.Model.CapitalCity", b =>
                {
                    b.HasOne("asp.Model.Country", "Country")
                        .WithOne("CapitalCity")
                        .HasForeignKey("asp.Model.CapitalCity", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("asp.Model.Course", b =>
                {
                    b.HasOne("asp.Model.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("asp.Model.EmployeeProject", b =>
                {
                    b.HasOne("asp.Model.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp.Model.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("asp.Model.Country", b =>
                {
                    b.Navigation("CapitalCity");
                });

            modelBuilder.Entity("asp.Model.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("asp.Model.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("asp.Model.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
