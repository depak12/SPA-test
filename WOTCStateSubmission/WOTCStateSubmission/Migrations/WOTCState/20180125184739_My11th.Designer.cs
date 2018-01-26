﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WOTCStateSubmission;

namespace WOTCStateSubmission.Migrations.WOTCState
{
    [DbContext(typeof(WOTCStateContext))]
    [Migration("20180125184739_My11th")]
    partial class My11th
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WOTCStateSubmission.Applicant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicantId");

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<int?>("ZipCode");

                    b.Property<string>("city");

                    b.Property<string>("county");

                    b.Property<string>("phoneNumber");

                    b.Property<string>("socialSecurityNumber");

                    b.HasKey("Id");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("WOTCStateSubmission.ConditionalCertification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("receivedConditionalCertification");

                    b.HasKey("Id");

                    b.ToTable("ConditionalCertification");
                });

            modelBuilder.Entity("WOTCStateSubmission.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ScreeningId");

                    b.Property<string>("href");

                    b.Property<string>("id");

                    b.Property<string>("name");

                    b.Property<bool>("signatureRequired");

                    b.Property<string>("signedDate");

                    b.Property<string>("signedIpAddress");

                    b.Property<string>("signedName");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("WOTCStateSubmission.Employer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Ein");

                    b.Property<string>("Email");

                    b.Property<string>("EmployerId");

                    b.Property<string>("LocationId");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("TelephoneNumber");

                    b.Property<int?>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Employer");
                });

            modelBuilder.Entity("WOTCStateSubmission.Felony", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("convictionDate");

                    b.Property<bool>("federalConviction");

                    b.Property<bool>("hasFelonyConviction");

                    b.Property<string>("releaseDate");

                    b.HasKey("Id");

                    b.ToTable("Felony");
                });

            modelBuilder.Entity("WOTCStateSubmission.FoodStamps", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cityReceived");

                    b.Property<bool>("receivedFoodStamps");

                    b.Property<string>("recipientName");

                    b.Property<string>("stateReceived");

                    b.HasKey("Id");

                    b.ToTable("FoodStamps");
                });

            modelBuilder.Entity("WOTCStateSubmission.LongTermUnemployed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("endDate");

                    b.Property<bool>("receivedUnemploymentCompensation");

                    b.Property<string>("startDate");

                    b.Property<string>("stateReceived");

                    b.Property<bool>("unemployed6Months");

                    b.HasKey("Id");

                    b.ToTable("LongTermUnemployed");
                });

            modelBuilder.Entity("WOTCStateSubmission.RootObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("RootObject");
                });

            modelBuilder.Entity("WOTCStateSubmission.Screening", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("RootObjectId");

                    b.Property<string>("WasHired");

                    b.Property<Guid?>("applicantId");

                    b.Property<Guid?>("conditionalCertificationId");

                    b.Property<Guid?>("employerId");

                    b.Property<Guid?>("felonyId");

                    b.Property<Guid?>("foodStampsId");

                    b.Property<string>("gaveInformation");

                    b.Property<Guid?>("longTermUnemployedId");

                    b.Property<string>("offeredJob");

                    b.Property<string>("position");

                    b.Property<string>("screeningId");

                    b.Property<Guid?>("ssiId");

                    b.Property<string>("startedJob");

                    b.Property<int>("startingWage");

                    b.Property<Guid?>("veteranId");

                    b.Property<Guid?>("vocationalRehabilitationId");

                    b.Property<Guid?>("welfareId");

                    b.HasKey("Id");

                    b.HasIndex("RootObjectId");

                    b.HasIndex("applicantId");

                    b.HasIndex("conditionalCertificationId");

                    b.HasIndex("employerId");

                    b.HasIndex("felonyId");

                    b.HasIndex("foodStampsId");

                    b.HasIndex("longTermUnemployedId");

                    b.HasIndex("ssiId");

                    b.HasIndex("veteranId");

                    b.HasIndex("vocationalRehabilitationId");

                    b.HasIndex("welfareId");

                    b.ToTable("Screening");
                });

            modelBuilder.Entity("WOTCStateSubmission.Ssi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("receivedDisabilityPayments");

                    b.HasKey("Id");

                    b.ToTable("Ssi");
                });

            modelBuilder.Entity("WOTCStateSubmission.Veteran", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("dischargedWithinPastYear");

                    b.Property<bool>("hasServiceConnectedDisablility");

                    b.Property<bool>("unemployedForAtLeast6Months");

                    b.Property<bool>("unemployedLessThan6Months");

                    b.Property<Guid?>("veteranFoodStampsId");

                    b.Property<bool>("veteranOfArmedForces");

                    b.HasKey("Id");

                    b.HasIndex("veteranFoodStampsId");

                    b.ToTable("Veteran");
                });

            modelBuilder.Entity("WOTCStateSubmission.VeteranFoodStamps", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cityReceived");

                    b.Property<bool>("receivedFoodStamps");

                    b.Property<string>("recipientName");

                    b.Property<string>("stateReceived");

                    b.HasKey("Id");

                    b.ToTable("VeteranFoodStamps");
                });

            modelBuilder.Entity("WOTCStateSubmission.VocationalRehabilitation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("completedVocationalRehabilitation");

                    b.Property<bool>("doneByDepartmentOfVeteransAffairs");

                    b.Property<bool>("doneUnderTicketToWork");

                    b.HasKey("Id");

                    b.ToTable("VocationalRehabilitation");
                });

            modelBuilder.Entity("WOTCStateSubmission.Welfare", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cityReceived");

                    b.Property<bool>("maximizedBenefitsWithinPastTwoYears");

                    b.Property<bool>("receivedBenefits18MonthsWithinPast2Years");

                    b.Property<bool>("receivedBenefitsAtLeast9Months");

                    b.Property<bool>("receivedBenefitsPast18Months");

                    b.Property<bool>("receivedWelfare");

                    b.Property<string>("recipientName");

                    b.Property<string>("stateReceived");

                    b.HasKey("Id");

                    b.ToTable("Welfare");
                });

            modelBuilder.Entity("WOTCStateSubmission.Document", b =>
                {
                    b.HasOne("WOTCStateSubmission.Screening")
                        .WithMany("documents")
                        .HasForeignKey("ScreeningId");
                });

            modelBuilder.Entity("WOTCStateSubmission.Screening", b =>
                {
                    b.HasOne("WOTCStateSubmission.RootObject")
                        .WithMany("screenings")
                        .HasForeignKey("RootObjectId");

                    b.HasOne("WOTCStateSubmission.Applicant", "applicant")
                        .WithMany()
                        .HasForeignKey("applicantId");

                    b.HasOne("WOTCStateSubmission.ConditionalCertification", "conditionalCertification")
                        .WithMany()
                        .HasForeignKey("conditionalCertificationId");

                    b.HasOne("WOTCStateSubmission.Employer", "employer")
                        .WithMany()
                        .HasForeignKey("employerId");

                    b.HasOne("WOTCStateSubmission.Felony", "felony")
                        .WithMany()
                        .HasForeignKey("felonyId");

                    b.HasOne("WOTCStateSubmission.FoodStamps", "foodStamps")
                        .WithMany()
                        .HasForeignKey("foodStampsId");

                    b.HasOne("WOTCStateSubmission.LongTermUnemployed", "longTermUnemployed")
                        .WithMany()
                        .HasForeignKey("longTermUnemployedId");

                    b.HasOne("WOTCStateSubmission.Ssi", "ssi")
                        .WithMany()
                        .HasForeignKey("ssiId");

                    b.HasOne("WOTCStateSubmission.Veteran", "veteran")
                        .WithMany()
                        .HasForeignKey("veteranId");

                    b.HasOne("WOTCStateSubmission.VocationalRehabilitation", "vocationalRehabilitation")
                        .WithMany()
                        .HasForeignKey("vocationalRehabilitationId");

                    b.HasOne("WOTCStateSubmission.Welfare", "welfare")
                        .WithMany()
                        .HasForeignKey("welfareId");
                });

            modelBuilder.Entity("WOTCStateSubmission.Veteran", b =>
                {
                    b.HasOne("WOTCStateSubmission.VeteranFoodStamps", "veteranFoodStamps")
                        .WithMany()
                        .HasForeignKey("veteranFoodStampsId");
                });
#pragma warning restore 612, 618
        }
    }
}
