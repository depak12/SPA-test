using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class My17thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "RootObject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RootObject",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screening",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RootObjectId = table.Column<Guid>(nullable: true),
                    WasHired = table.Column<string>(nullable: true),
                    applicantId = table.Column<Guid>(nullable: true),
                    conditionalCertificationId = table.Column<Guid>(nullable: true),
                    employerId = table.Column<Guid>(nullable: true),
                    felonyId = table.Column<Guid>(nullable: true),
                    foodStampsId = table.Column<Guid>(nullable: true),
                    gaveInformation = table.Column<string>(nullable: true),
                    longTermUnemployedId = table.Column<Guid>(nullable: true),
                    offeredJob = table.Column<string>(nullable: true),
                    position = table.Column<string>(nullable: true),
                    screeningId = table.Column<string>(nullable: true),
                    ssiId = table.Column<Guid>(nullable: true),
                    startedJob = table.Column<string>(nullable: true),
                    startingWage = table.Column<int>(nullable: false),
                    veteranId = table.Column<Guid>(nullable: true),
                    vocationalRehabilitationId = table.Column<Guid>(nullable: true),
                    welfareId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screening_RootObject_RootObjectId",
                        column: x => x.RootObjectId,
                        principalTable: "RootObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_Applicant_applicantId",
                        column: x => x.applicantId,
                        principalTable: "Applicant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_ConditionalCertification_conditionalCertificationId",
                        column: x => x.conditionalCertificationId,
                        principalTable: "ConditionalCertification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_Employer_employerId",
                        column: x => x.employerId,
                        principalTable: "Employer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_Felony_felonyId",
                        column: x => x.felonyId,
                        principalTable: "Felony",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_FoodStamps_foodStampsId",
                        column: x => x.foodStampsId,
                        principalTable: "FoodStamps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_LongTermUnemployed_longTermUnemployedId",
                        column: x => x.longTermUnemployedId,
                        principalTable: "LongTermUnemployed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_Ssi_ssiId",
                        column: x => x.ssiId,
                        principalTable: "Ssi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_Veteran_veteranId",
                        column: x => x.veteranId,
                        principalTable: "Veteran",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_VocationalRehabilitation_vocationalRehabilitationId",
                        column: x => x.vocationalRehabilitationId,
                        principalTable: "VocationalRehabilitation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screening_Welfare_welfareId",
                        column: x => x.welfareId,
                        principalTable: "Welfare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    ScreeningId = table.Column<Guid>(nullable: true),
                    href = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    signatureRequired = table.Column<bool>(nullable: false),
                    signedDate = table.Column<string>(nullable: true),
                    signedIpAddress = table.Column<string>(nullable: true),
                    signedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.id);
                    table.ForeignKey(
                        name: "FK_Document_Screening_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screening",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_ScreeningId",
                table: "Document",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_RootObjectId",
                table: "Screening",
                column: "RootObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_applicantId",
                table: "Screening",
                column: "applicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_conditionalCertificationId",
                table: "Screening",
                column: "conditionalCertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_employerId",
                table: "Screening",
                column: "employerId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_felonyId",
                table: "Screening",
                column: "felonyId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_foodStampsId",
                table: "Screening",
                column: "foodStampsId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_longTermUnemployedId",
                table: "Screening",
                column: "longTermUnemployedId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_ssiId",
                table: "Screening",
                column: "ssiId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_veteranId",
                table: "Screening",
                column: "veteranId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_vocationalRehabilitationId",
                table: "Screening",
                column: "vocationalRehabilitationId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_welfareId",
                table: "Screening",
                column: "welfareId");
        }
    }
}
