using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static WOTCStateSubmission.WOTCApi;

namespace WOTCStateSubmission
{
    public partial class WOTCApiContext : DbContext
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
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Screening> Screening { get; set; }
        public virtual DbSet<RootObject> RootObject { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=ERS-IT-LT-009;Database= WOTCStateApiDev;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }
    }

}
