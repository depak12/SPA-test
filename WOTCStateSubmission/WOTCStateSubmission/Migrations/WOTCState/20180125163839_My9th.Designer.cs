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
    [Migration("20180125163839_My9th")]
    partial class My9th
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
#pragma warning restore 612, 618
        }
    }
}
