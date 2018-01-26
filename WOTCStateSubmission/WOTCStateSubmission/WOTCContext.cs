using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WOTCStateSubmission
{
    public partial class WOTCContext : DbContext
    {
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=ERS-IT-LT-009; Database = WOTC; Trusted_Connection = True; MultipleActiveResultSets = true; ");

//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=ERS-IT-LT-009;Database= WOTC;Trusted_Connection=True;MultipleActiveResultSets=true;");
           }
        }

        //FluentAPI
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test2");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasColumnType("nchar(10)");

                entity.Property(e => e.Address).HasColumnType("nchar(100)");
                entity.Property(e => e.City).HasColumnType("nchar(100)");
            });
        }
    }
}

