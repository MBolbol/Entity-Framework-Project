using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Ins_Id", "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[,]
                {
                    { 1, null, "Ahmed", "Ali", "0100000001" },
                    { 2, null, "Mona", "Hassan", "0100000002" },
                    { 3, null, "Khaled", "Omar", "0100000003" },
                    { 4, null, "Sarah", "Mahmoud", "0100000004" },
                    { 5, null, "Tamer", "Fahmy", "0100000005" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Dept_Id", "Dept_Location", "Dept_Manager", "Dept_Name" },
                values: new object[,]
                {
                    { 1, "Building A", 1, "Computer Science" },
                    { 2, "Building B", 2, "Mathematics" },
                    { 3, "Building C", 3, "Physics" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Dept_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Dept_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Dept_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 3);
        }
    }
}
