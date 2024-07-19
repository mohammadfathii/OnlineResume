using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineResume.Migrations
{
    /// <inheritdoc />
    public partial class AddAllForeigns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_PersonalData_PersonalDataId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_PersonalData_PersonalDataId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_PersonalData_PersonalDataId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PersonalData_PersonalDataId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_PersonalData_PersonalDataId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftSkills_PersonalData_PersonalDataId",
                table: "SoftSkills");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "SoftSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Experiences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDay",
                value: new DateTime(2024, 7, 17, 9, 14, 20, 966, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_PersonalData_PersonalDataId",
                table: "Educations",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_PersonalData_PersonalDataId",
                table: "Experiences",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_PersonalData_PersonalDataId",
                table: "Languages",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PersonalData_PersonalDataId",
                table: "Projects",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_PersonalData_PersonalDataId",
                table: "Skills",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoftSkills_PersonalData_PersonalDataId",
                table: "SoftSkills",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_PersonalData_PersonalDataId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_PersonalData_PersonalDataId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_PersonalData_PersonalDataId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PersonalData_PersonalDataId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_PersonalData_PersonalDataId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftSkills_PersonalData_PersonalDataId",
                table: "SoftSkills");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "SoftSkills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Languages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Experiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalDataId",
                table: "Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDay",
                value: new DateTime(2024, 7, 17, 4, 31, 9, 622, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_PersonalData_PersonalDataId",
                table: "Educations",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_PersonalData_PersonalDataId",
                table: "Experiences",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_PersonalData_PersonalDataId",
                table: "Languages",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PersonalData_PersonalDataId",
                table: "Projects",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_PersonalData_PersonalDataId",
                table: "Skills",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftSkills_PersonalData_PersonalDataId",
                table: "SoftSkills",
                column: "PersonalDataId",
                principalTable: "PersonalData",
                principalColumn: "Id");
        }
    }
}
