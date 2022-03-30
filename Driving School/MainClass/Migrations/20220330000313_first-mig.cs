using Microsoft.EntityFrameworkCore.Migrations;

namespace Driving_School.DB.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_IdentityNumber = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Courses_Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_Id);
                });

            migrationBuilder.CreateTable(
                name: "Driving_instructors",
                columns: table => new
                {
                    Driving_instructors_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Driving_instructor_IdentityNumber = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Courses_Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driving_instructors", x => x.Driving_instructors_Id);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    History_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Driving_instructor_Id = table.Column<int>(type: "int", nullable: false),
                    Student_Id = table.Column<int>(type: "int", nullable: false),
                    Courses_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.History_Id);
                });

            migrationBuilder.CreateTable(
                name: "Drive_Courses",
                columns: table => new
                {
                    Courses_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Number_Of_Lessones = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Driving_instructor_Id = table.Column<int>(type: "int", nullable: false),
                    History_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drive_Courses", x => x.Courses_Id);
                    table.ForeignKey(
                        name: "FK_Drive_Courses_History",
                        column: x => x.History_Id,
                        principalTable: "History",
                        principalColumn: "History_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drive_Courses_History_Id",
                table: "Drive_Courses",
                column: "History_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Driving_instructors_Courses_Id",
                table: "Driving_instructors",
                column: "Courses_Id");

            migrationBuilder.CreateIndex(
                name: "IX_History_Courses_Id",
                table: "History",
                column: "Courses_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driving_instructors_Drive_Courses",
                table: "Driving_instructors",
                column: "Courses_Id",
                principalTable: "Drive_Courses",
                principalColumn: "Courses_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Drive_Courses",
                table: "History",
                column: "Courses_Id",
                principalTable: "Drive_Courses",
                principalColumn: "Courses_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drive_Courses_History",
                table: "Drive_Courses");

            migrationBuilder.DropTable(
                name: "Driving_instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Drive_Courses");
        }
    }
}
