using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspDotNetCore.Migrations
{
    /// <inheritdoc />
    public partial class AddNullabelToFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Courses_Course_id",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Trainees_Trainee_Id",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Department_id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Courses_Course_id",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Departments_Department_id",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_Department_id",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "Department_id",
                table: "Trainees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Department_id",
                table: "Instructores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Course_id",
                table: "Instructores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Department_id",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Trainee_Id",
                table: "CourseResults",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Course_id",
                table: "CourseResults",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Courses_Course_id",
                table: "CourseResults",
                column: "Course_id",
                principalTable: "Courses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Trainees_Trainee_Id",
                table: "CourseResults",
                column: "Trainee_Id",
                principalTable: "Trainees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Department_id",
                table: "Courses",
                column: "Department_id",
                principalTable: "Departments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Courses_Course_id",
                table: "Instructores",
                column: "Course_id",
                principalTable: "Courses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Departments_Department_id",
                table: "Instructores",
                column: "Department_id",
                principalTable: "Departments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Department_id",
                table: "Trainees",
                column: "Department_id",
                principalTable: "Departments",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Courses_Course_id",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Trainees_Trainee_Id",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Department_id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Courses_Course_id",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Departments_Department_id",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_Department_id",
                table: "Trainees");

            migrationBuilder.AlterColumn<int>(
                name: "Department_id",
                table: "Trainees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_id",
                table: "Instructores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Course_id",
                table: "Instructores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Department_id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Trainee_Id",
                table: "CourseResults",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Course_id",
                table: "CourseResults",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Courses_Course_id",
                table: "CourseResults",
                column: "Course_id",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Trainees_Trainee_Id",
                table: "CourseResults",
                column: "Trainee_Id",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Department_id",
                table: "Courses",
                column: "Department_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Courses_Course_id",
                table: "Instructores",
                column: "Course_id",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Departments_Department_id",
                table: "Instructores",
                column: "Department_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Department_id",
                table: "Trainees",
                column: "Department_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
