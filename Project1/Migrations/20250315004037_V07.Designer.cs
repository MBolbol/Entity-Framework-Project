﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.context;

#nullable disable

namespace Project1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20250315004037_V07")]
    partial class V07
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project1.models.Course", b =>
                {
                    b.Property<int>("Crs_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Crs_Id"));

                    b.Property<int?>("Crs_Duration")
                        .HasColumnType("int");

                    b.Property<string>("Crs_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.HasKey("Crs_Id");

                    b.HasIndex("Dept_Id");

                    b.HasIndex("Ins_Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Crs_Id = 1,
                            Crs_Duration = 45,
                            Crs_Name = "Algorithms",
                            Dept_Id = 1,
                            Ins_Id = 1
                        },
                        new
                        {
                            Crs_Id = 2,
                            Crs_Duration = 50,
                            Crs_Name = "Data Structures",
                            Dept_Id = 1,
                            Ins_Id = 4
                        },
                        new
                        {
                            Crs_Id = 3,
                            Crs_Duration = 40,
                            Crs_Name = "Calculus",
                            Dept_Id = 2,
                            Ins_Id = 2
                        },
                        new
                        {
                            Crs_Id = 4,
                            Crs_Duration = 42,
                            Crs_Name = "Linear Algebra",
                            Dept_Id = 2,
                            Ins_Id = 5
                        },
                        new
                        {
                            Crs_Id = 5,
                            Crs_Duration = 55,
                            Crs_Name = "Quantum Mechanics",
                            Dept_Id = 3,
                            Ins_Id = 3
                        });
                });

            modelBuilder.Entity("Project1.models.CourseSession", b =>
                {
                    b.Property<int>("CourseSessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseSessionId"));

                    b.Property<DateTime>("Crs_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CourseSessionId");

                    b.HasIndex("Crs_Id");

                    b.HasIndex("Ins_Id");

                    b.ToTable("CourseSessions");

                    b.HasData(
                        new
                        {
                            CourseSessionId = 1,
                            Crs_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Crs_Id = 1,
                            Ins_Id = 1,
                            Title = "Intro to Algorithms"
                        },
                        new
                        {
                            CourseSessionId = 2,
                            Crs_Date = new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Crs_Id = 3,
                            Ins_Id = 2,
                            Title = "Calculus Basics"
                        },
                        new
                        {
                            CourseSessionId = 3,
                            Crs_Date = new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Crs_Id = 5,
                            Ins_Id = 3,
                            Title = "Quantum Principles"
                        });
                });

            modelBuilder.Entity("Project1.models.CourseSessionAttendance", b =>
                {
                    b.Property<int>("CrsAttendance_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CrsAttendance_Id"));

                    b.Property<int?>("CourseSessionID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("CrsAttendance_Id");

                    b.HasIndex("CourseSessionID");

                    b.HasIndex("StudentID");

                    b.ToTable("CourseSessionAttendances");

                    b.HasData(
                        new
                        {
                            CrsAttendance_Id = 1,
                            CourseSessionID = 1,
                            Grade = 90,
                            Notes = "Excellent",
                            StudentID = 1
                        },
                        new
                        {
                            CrsAttendance_Id = 2,
                            CourseSessionID = 1,
                            Grade = 85,
                            Notes = "Very Good",
                            StudentID = 2
                        },
                        new
                        {
                            CrsAttendance_Id = 3,
                            CourseSessionID = 2,
                            Grade = 88,
                            Notes = "Good",
                            StudentID = 3
                        },
                        new
                        {
                            CrsAttendance_Id = 4,
                            CourseSessionID = 3,
                            Grade = 92,
                            Notes = "Outstanding",
                            StudentID = 4
                        },
                        new
                        {
                            CrsAttendance_Id = 5,
                            CourseSessionID = 3,
                            Grade = 78,
                            Notes = "Needs Improvement",
                            StudentID = 5
                        });
                });

            modelBuilder.Entity("Project1.models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_Id"));

                    b.Property<string>("Dept_Location")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Dept_Manager")
                        .HasColumnType("int");

                    b.Property<string>("Dept_Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Dept_Id");

                    b.HasIndex("Dept_Manager")
                        .IsUnique();

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Dept_Id = 1,
                            Dept_Location = "Building A",
                            Dept_Manager = 1,
                            Dept_Name = "Computer Science"
                        },
                        new
                        {
                            Dept_Id = 2,
                            Dept_Location = "Building B",
                            Dept_Manager = 2,
                            Dept_Name = "Mathematics"
                        },
                        new
                        {
                            Dept_Id = 3,
                            Dept_Location = "Building C",
                            Dept_Manager = 3,
                            Dept_Name = "Physics"
                        });
                });

            modelBuilder.Entity("Project1.models.Instructor", b =>
                {
                    b.Property<int>("Ins_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ins_Id"));

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<string>("Ins_Fname")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ins_Lname")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ins_Phone")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Ins_Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Ins_Id = 1,
                            Dept_Id = 1,
                            Ins_Fname = "Ahmed",
                            Ins_Lname = "Ali",
                            Ins_Phone = "0100000001"
                        },
                        new
                        {
                            Ins_Id = 2,
                            Dept_Id = 2,
                            Ins_Fname = "Mona",
                            Ins_Lname = "Hassan",
                            Ins_Phone = "0100000002"
                        },
                        new
                        {
                            Ins_Id = 3,
                            Dept_Id = 3,
                            Ins_Fname = "Khaled",
                            Ins_Lname = "Omar",
                            Ins_Phone = "0100000003"
                        },
                        new
                        {
                            Ins_Id = 4,
                            Dept_Id = 2,
                            Ins_Fname = "Sarah",
                            Ins_Lname = "Mahmoud",
                            Ins_Phone = "0100000004"
                        },
                        new
                        {
                            Ins_Id = 5,
                            Dept_Id = 3,
                            Ins_Fname = "Tamer",
                            Ins_Lname = "Fahmy",
                            Ins_Phone = "0100000005"
                        });
                });

            modelBuilder.Entity("Project1.models.Student", b =>
                {
                    b.Property<int>("St_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("St_Id"));

                    b.Property<string>("St_Fname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("St_Lname")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("St_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("St_Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            St_Id = 1,
                            St_Fname = "Youssef",
                            St_Lname = "Hassan",
                            St_Phone = "0111111111"
                        },
                        new
                        {
                            St_Id = 2,
                            St_Fname = "Nour",
                            St_Lname = "Mohamed",
                            St_Phone = "0111111112"
                        },
                        new
                        {
                            St_Id = 3,
                            St_Fname = "Hussein",
                            St_Lname = "Sami",
                            St_Phone = "0111111113"
                        },
                        new
                        {
                            St_Id = 4,
                            St_Fname = "Laila",
                            St_Lname = "Osman",
                            St_Phone = "0111111114"
                        },
                        new
                        {
                            St_Id = 5,
                            St_Fname = "Mariam",
                            St_Lname = "Zaki",
                            St_Phone = "0111111115"
                        });
                });

            modelBuilder.Entity("Project1.models.Student_Course", b =>
                {
                    b.Property<int>("St_Id")
                        .HasColumnType("int");

                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.HasKey("St_Id", "Crs_Id");

                    b.HasIndex("Crs_Id");

                    b.ToTable("Student_Courses");

                    b.HasData(
                        new
                        {
                            St_Id = 1,
                            Crs_Id = 1
                        },
                        new
                        {
                            St_Id = 1,
                            Crs_Id = 2
                        },
                        new
                        {
                            St_Id = 2,
                            Crs_Id = 3
                        },
                        new
                        {
                            St_Id = 3,
                            Crs_Id = 4
                        },
                        new
                        {
                            St_Id = 4,
                            Crs_Id = 5
                        },
                        new
                        {
                            St_Id = 5,
                            Crs_Id = 1
                        },
                        new
                        {
                            St_Id = 5,
                            Crs_Id = 3
                        });
                });

            modelBuilder.Entity("Project1.models.Course", b =>
                {
                    b.HasOne("Project1.models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("Dept_Id");

                    b.HasOne("Project1.models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Project1.models.CourseSession", b =>
                {
                    b.HasOne("Project1.models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Crs_Id");

                    b.HasOne("Project1.models.Instructor", "Instructor")
                        .WithMany("CourseSessions")
                        .HasForeignKey("Ins_Id");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Project1.models.CourseSessionAttendance", b =>
                {
                    b.HasOne("Project1.models.CourseSession", "CourseSession")
                        .WithMany("CourseSessionAttendances")
                        .HasForeignKey("CourseSessionID");

                    b.HasOne("Project1.models.Student", "Student")
                        .WithMany("CourseSessionAttendances")
                        .HasForeignKey("StudentID");

                    b.Navigation("CourseSession");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Project1.models.Department", b =>
                {
                    b.HasOne("Project1.models.Instructor", "DeptManager")
                        .WithOne()
                        .HasForeignKey("Project1.models.Department", "Dept_Manager")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DeptManager");
                });

            modelBuilder.Entity("Project1.models.Instructor", b =>
                {
                    b.HasOne("Project1.models.Department", "ManagedDepartment")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ManagedDepartment");
                });

            modelBuilder.Entity("Project1.models.Student_Course", b =>
                {
                    b.HasOne("Project1.models.Course", "Course")
                        .WithMany("Student_Courses")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.models.Student", "Student")
                        .WithMany("Student_Courses")
                        .HasForeignKey("St_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Project1.models.Course", b =>
                {
                    b.Navigation("Student_Courses");
                });

            modelBuilder.Entity("Project1.models.CourseSession", b =>
                {
                    b.Navigation("CourseSessionAttendances");
                });

            modelBuilder.Entity("Project1.models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("Project1.models.Instructor", b =>
                {
                    b.Navigation("CourseSessions");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Project1.models.Student", b =>
                {
                    b.Navigation("CourseSessionAttendances");

                    b.Navigation("Student_Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
