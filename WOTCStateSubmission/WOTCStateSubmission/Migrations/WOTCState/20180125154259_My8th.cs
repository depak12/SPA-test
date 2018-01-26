using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class My8th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    applicantId = table.Column<string>(name: "applicantId ", type: "nchar(20)", nullable: false),
                    dateOfBirth = table.Column<string>(type: "nchar(10)", nullable: true),
                    firstName = table.Column<string>(type: "nchar(10)", nullable: true),
                    lastName = table.Column<string>(type: "nchar(10)", nullable: true),
                    middleName = table.Column<string>(name: "middleName ", type: "nchar(10)", nullable: true),
                    state = table.Column<string>(nullable: true),
                    streetAddress = table.Column<string>(type: "nchar(100)", nullable: true),
                    zipCode = table.Column<int>(nullable: true),
                    city = table.Column<string>(type: "nchar(10)", nullable: true),
                    county = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<string>(nullable: true),
                    socialSecurityNumber = table.Column<string>(type: "nchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.applicantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");
        }
    }
}
