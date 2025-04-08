using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_Fname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    St_Lname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    St_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.St_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Crs_Duration = table.Column<int>(type: "int", nullable: true),
                    Dept_Id = table.Column<int>(type: "int", nullable: true),
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_Id);
                });

            migrationBuilder.CreateTable(
                name: "Student_Courses",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Courses", x => new { x.St_Id, x.Crs_Id });
                    table.ForeignKey(
                        name: "FK_Student_Courses_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Courses_Students_St_Id",
                        column: x => x.St_Id,
                        principalTable: "Students",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessionAttendances",
                columns: table => new
                {
                    CrsAttendance_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseSessionID = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessionAttendances", x => x.CrsAttendance_Id);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendances_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "St_Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseSessions",
                columns: table => new
                {
                    CourseSessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Id = table.Column<int>(type: "int", nullable: true),
                    Crs_Id = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Crs_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessions", x => x.CourseSessionId);
                    table.ForeignKey(
                        name: "FK_CourseSessions_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dept_Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dept_Manager = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Fname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ins_Lname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ins_Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dept_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Dept_Id",
                table: "Courses",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Ins_Id",
                table: "Courses",
                column: "Ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_CourseSessionID",
                table: "CourseSessionAttendances",
                column: "CourseSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_StudentID",
                table: "CourseSessionAttendances",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_Crs_Id",
                table: "CourseSessions",
                column: "Crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_Ins_Id",
                table: "CourseSessions",
                column: "Ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_Crs_Id",
                table: "Student_Courses",
                column: "Crs_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Dept_Id",
                table: "Courses",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_Ins_Id",
                table: "Courses",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Ins_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_CourseSessions_CourseSessionID",
                table: "CourseSessionAttendances",
                column: "CourseSessionID",
                principalTable: "CourseSessions",
                principalColumn: "CourseSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Instructors_Ins_Id",
                table: "CourseSessions",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager",
                principalTable: "Instructors",
                principalColumn: "Ins_Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "CourseSessionAttendances");

            migrationBuilder.DropTable(
                name: "Student_Courses");

            migrationBuilder.DropTable(
                name: "CourseSessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
