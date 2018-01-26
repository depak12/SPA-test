using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Welfare
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedWelfare { get; set; }
        public string recipientName { get; set; }
        public string cityReceived { get; set; }
        public string stateReceived { get; set; }
        public bool receivedBenefitsPast18Months { get; set; }
        public bool receivedBenefitsAtLeast9Months { get; set; }
        public bool receivedBenefits18MonthsWithinPast2Years { get; set; }
        public bool maximizedBenefitsWithinPastTwoYears { get; set; }
    }
}

