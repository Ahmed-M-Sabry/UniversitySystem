﻿// <auto-generated />
using System;
using AspDotNetCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspDotNetCore.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int?>("Department_id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassDegree")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Department_id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AspDotNetCore.Models.CourseResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Course_id")
                        .HasColumnType("int");

                    b.Property<int>("Drgree")
                        .HasColumnType("int");

                    b.Property<int?>("Trainee_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Course_id");

                    b.HasIndex("Trainee_Id");

                    b.ToTable("CourseResults");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Instructore", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Course_id")
                        .HasColumnType("int");

                    b.Property<int?>("Department_id")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Course_id");

                    b.HasIndex("Department_id");

                    b.ToTable("Instructores");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Department_id")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Department_id");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Course", b =>
                {
                    b.HasOne("AspDotNetCore.Models.Department", "FkDepartment")
                        .WithMany("Courses")
                        .HasForeignKey("Department_id");

                    b.Navigation("FkDepartment");
                });

            modelBuilder.Entity("AspDotNetCore.Models.CourseResult", b =>
                {
                    b.HasOne("AspDotNetCore.Models.Course", "FkCourse")
                        .WithMany("CourseResults")
                        .HasForeignKey("Course_id");

                    b.HasOne("AspDotNetCore.Models.Trainee", "FkTrainee")
                        .WithMany("CourseResults")
                        .HasForeignKey("Trainee_Id");

                    b.Navigation("FkCourse");

                    b.Navigation("FkTrainee");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Instructore", b =>
                {
                    b.HasOne("AspDotNetCore.Models.Course", "FkCourse")
                        .WithMany("Instructores")
                        .HasForeignKey("Course_id");

                    b.HasOne("AspDotNetCore.Models.Department", "FkDepartment")
                        .WithMany("Instructores")
                        .HasForeignKey("Department_id");

                    b.Navigation("FkCourse");

                    b.Navigation("FkDepartment");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Trainee", b =>
                {
                    b.HasOne("AspDotNetCore.Models.Department", "FkDepartment")
                        .WithMany("Trainees")
                        .HasForeignKey("Department_id");

                    b.Navigation("FkDepartment");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Course", b =>
                {
                    b.Navigation("CourseResults");

                    b.Navigation("Instructores");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructores");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("AspDotNetCore.Models.Trainee", b =>
                {
                    b.Navigation("CourseResults");
                });
#pragma warning restore 612, 618
        }
    }
}