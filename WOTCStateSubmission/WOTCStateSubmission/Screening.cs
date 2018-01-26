using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Screening
    {
        [Key]
        public Guid Id { get; set; }
        public string screeningId { get; set; }
        public Employer employer { get; set; }
        public Applicant applicant { get; set; }
        public ConditionalCertification conditionalCertification { get; set; }
        public FoodStamps foodStamps { get; set; }
        public Welfare welfare { get; set; }
        public VocationalRehabilitation vocationalRehabilitation { get; set; }
        public Veteran veteran { get; set; }
        public Ssi ssi { get; set; }
        public Felony felony { get; set; }
        public LongTermUnemployed longTermUnemployed { get; set; }
        public List<Document> documents { get; set; }
        public string gaveInformation { get; set; }
        public string offeredJob { get; set; }
        public string WasHired { get; set; }
        public string startedJob { get; set; }
        public string position { get; set; }
        public int startingWage { get; set; }
    }
}

