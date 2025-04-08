using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class V04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 1,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { "Ahmed", "Ali", "0100000001" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 2,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { "Mona", "Hassan", "0100000002" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 3,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { "Khaled", "Omar", "0100000003" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 4,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { "Sarah", "Mahmoud", "0100000004" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 5,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { "Tamer", "Fahmy", "0100000005" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 1,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 2,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 3,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 4,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Ins_Id",
                keyValue: 5,
                columns: new[] { "Ins_Fname", "Ins_Lname", "Ins_Phone" },
                values: new object[] { null, null, null });
        }
    }
}
