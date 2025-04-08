using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseSessionAttendances",
                columns: new[] { "CrsAttendance_Id", "CourseSessionID", "Grade", "Notes", "StudentID" },
                values: new object[,]
                {
                    { 1, 1, 90, "Excellent", 1 },
                    { 2, 1, 85, "Very Good", 2 },
                    { 3, 2, 88, "Good", 3 },
                    { 4, 3, 92, "Outstanding", 4 },
                    { 5, 3, 78, "Needs Improvement", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "CrsAttendance_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "CrsAttendance_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "CrsAttendance_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "CrsAttendance_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseSessionAttendances",
                keyColumn: "CrsAttendance_Id",
                keyValue: 5);
        }
    }
}
