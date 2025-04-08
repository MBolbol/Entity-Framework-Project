using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 1,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { 1, null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 2,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { 2, null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 3,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { 3, null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 4,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { 2, null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 5,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { 3, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 1,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, "Ahmed", "Ali", "0100000001" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 2,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, "Mona", "Hassan", "0100000002" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 3,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, "Khaled", "Omar", "0100000003" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 4,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, "Sarah", "Mahmoud", "0100000004" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 5,
                columns: new[] { "Dept_Id", "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, "Tamer", "Fahmy", "0100000005" });
        }
    }
}
