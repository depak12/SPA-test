using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    public partial class My11th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Felony",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    convictionDate = table.Column<string>(nullable: true),
                    federalConviction = table.Column<bool>(nullable: false),
                    hasFelonyConviction = table.Column<bool>(nullable: false),
                    releaseDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felony", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LongTermUnemployed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    endDate = table.Column<string>(nullable: true),
                    receivedUnemploymentCompensation = table.Column<bool>(nullable: false),
                    startDate = table.Column<string>(nullable: true),
                    stateReceived = table.Column<string>(nullable: true),
                    unemployed6Months = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LongTermUnemployed", x => x.Id);
                });

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
                name: "Ssi",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    receivedDisabilityPayments = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ssi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeteranFoodStamps",
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
                    table.PrimaryKey("PK_VeteranFoodStamps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VocationalRehabilitation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    completedVocationalRehabilitation = table.Column<bool>(nullable: false),
                    doneByDepartmentOfVeteransAffairs = table.Column<bool>(nullable: false),
                    doneUnderTicketToWork = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocationalRehabilitation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Welfare",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    cityReceived = table.Column<string>(nullable: true),
                    maximizedBenefitsWithinPastTwoYears = table.Column<bool>(nullable: false),
                    receivedBenefits18MonthsWithinPast2Years = table.Column<bool>(nullable: false),
                    receivedBenefitsAtLeast9Months = table.Column<bool>(nullable: false),
                    receivedBenefitsPast18Months = table.Column<bool>(nullable: false),
                    receivedWelfare = table.Column<bool>(nullable: false),
                    recipientName = table.Column<string>(nullable: true),
                    stateReceived = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veteran",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    dischargedWithinPastYear = table.Column<bool>(nullable: false),
                    hasServiceConnectedDisablility = table.Column<bool>(nullable: false),
                    unemployedForAtLeast6Months = table.Column<bool>(nullable: false),
                    unemployedLessThan6Months = table.Column<bool>(nullable: false),
                    veteranFoodStampsId = table.Column<Guid>(nullable: true),
                    veteranOfArmedForces = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veteran", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veteran_VeteranFoodStamps_veteranFoodStampsId",
                        column: x => x.veteranFoodStampsId,
                        principalTable: "VeteranFoodStamps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Id = table.Column<Guid>(nullable: false),
                    ScreeningId = table.Column<Guid>(nullable: true),
                    href = table.Column<string>(nullable: true),
                    id = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    signatureRequired = table.Column<bool>(nullable: false),
                    signedDate = table.Column<string>(nullable: true),
                    signedIpAddress = table.Column<string>(nullable: true),
                    signedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_Veteran_veteranFoodStampsId",
                table: "Veteran",
                column: "veteranFoodStampsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "RootObject");

            migrationBuilder.DropTable(
                name: "Felony");

            migrationBuilder.DropTable(
                name: "LongTermUnemployed");

            migrationBuilder.DropTable(
                name: "Ssi");

            migrationBuilder.DropTable(
                name: "Veteran");

            migrationBuilder.DropTable(
                name: "VocationalRehabilitation");

            migrationBuilder.DropTable(
                name: "Welfare");

            migrationBuilder.DropTable(
                name: "VeteranFoodStamps");
        }
    }
}
