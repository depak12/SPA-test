using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class My14thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Document",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Document",
                nullable: false,
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Document",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Document",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
