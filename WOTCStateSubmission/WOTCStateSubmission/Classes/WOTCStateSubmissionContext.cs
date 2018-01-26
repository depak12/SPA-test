using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission.Classes
{
    public class WOTCStateSubmissionContext : DbContext
    {
        private string integer;

        //  public WOTCStateSubmissionContext() : base("TestConnection")
        //  {
        // }


        public WOTCStateSubmissionContext(DbContextOptions<WOTCStateSubmissionContext> options)
       : base(options)
        { }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=ERS-IT-LT-009; Database = WOTC; Trusted_Connection = True; MultipleActiveResultSets = true; ");
            }
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WOTCStateSubmissionContext>
        {
            public WOTCStateSubmissionContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<WOTCStateSubmissionContext>();
                var connectionString = configuration.GetConnectionString("TestConnection");
                builder.UseSqlServer(connectionString);
                return new WOTCStateSubmissionContext(builder.Options);
            }
        }

        public DbSet<WOTCStateSubmission.Employer> Employers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WOTCStateSubmission.Employer>(entity =>
            {
                entity.Property(e => e.employerId).ValueGeneratedNever();

                entity.Property(e => e.locationId).HasColumnType("nchar(20)");

                entity.Property(e => e.name).HasColumnType("nchar(100)");
                entity.Property(e => e.telephoneNumber).HasColumnType("nchar(100)");
                entity.Property(e => e.ein).HasColumnType("nchar(100)");
                entity.Property(e => e.streetAddress).HasColumnType("nchar(100)");
                entity.Property(e => e.city).HasColumnType("nchar(100)");
                entity.Property(e => e.state).HasColumnType("nchar(100)");
                entity.Property(e => e.zipCode).HasColumnType(integer);




            });
        }
        public DbSet<WOTCStateSubmission.Applicant> Applicants { get; set; }
        public DbSet<WOTCStateSubmission.ConditionalCertification> ConditionalCertifications { get; set; }
        public DbSet<WOTCStateSubmission.FoodStamps> FoodStamps { get; set; }
        public DbSet<WOTCStateSubmission.Welfare> Welfares { get; set; }
        public DbSet<WOTCStateSubmission.VocationalRehabilitation> VocationalRehabilitations { get; set; }
        public DbSet<WOTCStateSubmission.VeteranFoodStamps> VeteranFoodStamps { get; set; }

    }
}
