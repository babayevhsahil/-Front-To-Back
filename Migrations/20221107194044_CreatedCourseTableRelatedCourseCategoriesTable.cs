using Microsoft.EntityFrameworkCore.Migrations;

namespace BaxkendEterna.Migrations
{
    public partial class CreatedCourseTableRelatedCourseCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCategoryId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseCategoryId",
                table: "Courses");
        }
    }
}
