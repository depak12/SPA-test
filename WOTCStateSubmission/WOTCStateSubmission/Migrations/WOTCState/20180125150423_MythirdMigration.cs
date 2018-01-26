using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class MythirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employer",
                columns: table => new
                {
                    employerId = table.Column<string>(type: "nchar(20)", nullable: false),
                    city = table.Column<string>(type: "nchar(10)", nullable: true),
                    ein = table.Column<string>(type: "nchar(10)", nullable: true),
                    email = table.Column<string>(nullable: true),
                    locationId = table.Column<string>(type: "nchar(10)", nullable: true),
                    name = table.Column<string>(type: "nchar(10)", nullable: true),
                    state = table.Column<string>(type: "nchar(10)", nullable: true),
                    streetAddress = table.Column<string>(type: "nchar(100)", nullable: true),
                    telephoneNumber = table.Column<string>(type: "nchar(10)", nullable: true),
                    zipCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.employerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employer");
        }
    }
}
