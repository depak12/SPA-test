using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class LongTermUnemployed
    {
        [Key]
        public Guid Id { get; set; }
        public bool unemployed6Months { get; set; }
        public bool receivedUnemploymentCompensation { get; set; }
        public string stateReceived { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
}
