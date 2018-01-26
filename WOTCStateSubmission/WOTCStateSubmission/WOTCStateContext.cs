using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WOTCStateSubmission
{
    public partial class WOTCStateContext : DbContext
    {
      

        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<ConditionalCertification> ConditionalCertification { get; set; }
        public virtual DbSet<FoodStamps> FoodStamps { get; set; }
        public virtual DbSet<Welfare> Welfare { get; set; }
        public virtual DbSet<VocationalRehabilitation> VocationalRehabilitation { get; set; }
        public virtual DbSet<VeteranFoodStamps> VeteranFoodStamps { get; set; }
        public virtual DbSet<Veteran> Veteran { get; set; }
        public virtual DbSet<Ssi> Ssi { get; set; }
        public virtual DbSet<Felony> Felony { get; set; }
        public virtual DbSet<LongTermUnemployed> LongTermUnemployed { get; set; }
       // public virtual DbSet<Document> Document { get => _document; set => _document = value; }
       // public virtual DbSet<Screening> Screening { get; set; }
      //  public virtual DbSet<RootObject> RootObject { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=ERS-IT-LT-009;Database= WOTCState;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employer>(entity =>
        //    {
        //        entity.Property(e => e.EmployerId)
        //            .HasColumnName("employerId")
        //            .HasColumnType("nchar(20)")
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.City)
        //            .HasColumnName("city")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.Ein)
        //            .HasColumnName("ein")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.LocationId)
        //            .HasColumnName("locationId")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.Name)
        //            .HasColumnName("name")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.State)
        //            .HasColumnName("state")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.StreetAddress)
        //            .HasColumnName("streetAddress")
        //            .HasColumnType("nchar(100)");

        //        entity.Property(e => e.TelephoneNumber)
        //            .HasColumnName("telephoneNumber")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.ZipCode).HasColumnName("zipCode");
        //        entity.Property(e => e.Email).HasColumnName("email");
        //    });


        //    modelBuilder.Entity<Applicant>(entity =>
        //    {
        //        entity.Property(e => e.ApplicantId)
        //            .HasColumnName("applicantId ")
        //            .HasColumnType("nchar(20)")
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.FirstName)
        //            .HasColumnName("firstName")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.MiddleName)
        //            .HasColumnName("middleName ")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.LastName)
        //            .HasColumnName("lastName")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.socialSecurityNumber)
        //            .HasColumnName("socialSecurityNumber")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.DateOfBirth)
        //            .HasColumnName("dateOfBirth")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.StreetAddress)
        //            .HasColumnName("streetAddress")
        //            .HasColumnType("nchar(100)");

        //        entity.Property(e => e.city)
        //            .HasColumnName("city")
        //            .HasColumnType("nchar(10)");

        //        entity.Property(e => e.State).HasColumnName("state");
        //        entity.Property(e => e.ZipCode).HasColumnName("zipCode");
        //        entity.Property(e => e.county).HasColumnName("county");
        //        entity.Property(e => e.phoneNumber).HasColumnName("phoneNumber");
        //    });
        //    modelBuilder.Entity<ConditionalCertification>(entity =>
        //    {
        //        entity.Property(e => e.receivedConditionalCertification)
        //            .HasColumnName("receivedConditionalCertification  ")
        //            .HasColumnType("b")
        //            .ValueGeneratedNever();






        //    });
        //}
    }
}
