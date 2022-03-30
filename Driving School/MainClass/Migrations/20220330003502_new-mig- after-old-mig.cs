using Microsoft.EntityFrameworkCore.Migrations;

namespace Driving_School.DB.Migrations
{
    public partial class newmigafteroldmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Driving_instructors",
                columns: new[] { "Driving_instructors_Id", "Courses_Id", "Driving_instructor_IdentityNumber", "Email", "First_Name", "Last_Name", "Password", "Phone_Number", "UserName" },
                values: new object[] { 1, 0, 0, "gilnotok@gmail.com", "gil", "alkobi", "124126", 0, "gilgul" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_Id", "Courses_Id", "Email", "First_Name", "Last_Name", "Password", "Phone_Number", "Student_IdentityNumber", "UserName" },
                values: new object[] { 1, 0, "yoy@gmail.com", "yakov", "lulu", "123123", 0, 0, "yasha111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Driving_instructors",
                keyColumn: "Driving_instructors_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Student_Id",
                keyValue: 1);
        }
    }
}



