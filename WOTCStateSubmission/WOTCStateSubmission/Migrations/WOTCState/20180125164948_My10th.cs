using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class My10th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodStamps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    cityReceived = table.Column<string>(nullable: true),
                    receivedFoodStamps = table.Column<bool>(nullable: false),
                    recipientName = table.Column<string>(nullable: true),
                    stateReceived = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodStamps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodStamps");
        }
    }
}
