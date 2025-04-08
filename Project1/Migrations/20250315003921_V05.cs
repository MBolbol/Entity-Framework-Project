using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Crs_Id", "Crs_Duration", "Crs_Name", "Dept_Id", "Ins_Id" },
                values: new object[,]
                {
                    { 1, 45, "Algorithms", 1, 1 },
                    { 2, 50, "Data Structures", 1, 4 },
                    { 3, 40, "Calculus", 2, 2 },
                    { 4, 42, "Linear Algebra", 2, 5 },
                    { 5, 55, "Quantum Mechanics", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "St_Id", "St_Fname", "St_Lname", "St_Phone" },
                values: new object[,]
                {
                    { 1, "Youssef", "Hassan", "0111111111" },
                    { 2, "Nour", "Mohamed", "0111111112" },
                    { 3, "Hussein", "Sami", "0111111113" },
                    { 4, "Laila", "Osman", "0111111114" },
                    { 5, "Mariam", "Zaki", "0111111115" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Crs_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Crs_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Crs_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Crs_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Crs_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "St_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "St_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "St_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "St_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "St_Id",
                keyValue: 5);
        }
    }
}
