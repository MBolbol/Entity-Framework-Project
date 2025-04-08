using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseSessions",
                columns: new[] { "CourseSessionId", "Crs_Date", "Crs_Id", "Ins_Id", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Intro to Algorithms" },
                    { 2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "Calculus Basics" },
                    { 3, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, "Quantum Principles" }
                });

            migrationBuilder.InsertData(
                table: "Student_Courses",
                columns: new[] { "Crs_Id", "St_Id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 1, 5 },
                    { 3, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "CourseSessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "CourseSessionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseSessions",
                keyColumn: "CourseSessionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Student_Courses",
                keyColumns: new[] { "Crs_Id", "St_Id" },
                keyValues: new object[] { 3, 5 });
        }
    }
}
