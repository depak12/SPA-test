using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class notsurewhatsgoingtohappenhere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employer",
                table: "Employer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicant",
                table: "Applicant");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Employer",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "telephoneNumber",
                table: "Employer",
                newName: "TelephoneNumber");

            migrationBuilder.RenameColumn(
                name: "streetAddress",
                table: "Employer",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Employer",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Employer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "locationId",
                table: "Employer",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Employer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ein",
                table: "Employer",
                newName: "Ein");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Employer",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "employerId",
                table: "Employer",
                newName: "EmployerId");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Applicant",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "streetAddress",
                table: "Applicant",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Applicant",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "middleName ",
                table: "Applicant",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Applicant",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Applicant",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "dateOfBirth",
                table: "Applicant",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "applicantId ",
                table: "Applicant",
                newName: "ApplicantId");

            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ein",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployerId",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(20)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Employer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "socialSecurityNumber",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicantId",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(20)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Applicant",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employer",
                table: "Employer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicant",
                table: "Applicant",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ConditionalCertification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    receivedConditionalCertification = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionalCertification", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConditionalCertification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employer",
                table: "Employer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicant",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Applicant");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Employer",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "TelephoneNumber",
                table: "Employer",
                newName: "telephoneNumber");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Employer",
                newName: "streetAddress");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Employer",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employer",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Employer",
                newName: "locationId");

            migrationBuilder.RenameColumn(
                name: "EmployerId",
                table: "Employer",
                newName: "employerId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employer",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Ein",
                table: "Employer",
                newName: "ein");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employer",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Applicant",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Applicant",
                newName: "streetAddress");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Applicant",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Applicant",
                newName: "middleName ");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Applicant",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Applicant",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Applicant",
                newName: "dateOfBirth");

            migrationBuilder.RenameColumn(
                name: "ApplicantId",
                table: "Applicant",
                newName: "applicantId ");

            migrationBuilder.AlterColumn<string>(
                name: "telephoneNumber",
                table: "Employer",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "streetAddress",
                table: "Employer",
                type: "nchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Employer",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Employer",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "locationId",
                table: "Employer",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "employerId",
                table: "Employer",
                type: "nchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ein",
                table: "Employer",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Employer",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "socialSecurityNumber",
                table: "Applicant",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Applicant",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "streetAddress",
                table: "Applicant",
                type: "nchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "middleName ",
                table: "Applicant",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Applicant",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Applicant",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dateOfBirth",
                table: "Applicant",
                type: "nchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "applicantId ",
                table: "Applicant",
                type: "nchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employer",
                table: "Employer",
                column: "employerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicant",
                table: "Applicant",
                column: "applicantId ");
        }
    }
}
