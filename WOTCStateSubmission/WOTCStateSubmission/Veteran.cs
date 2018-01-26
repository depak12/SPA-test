using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Veteran
    {
        [Key]
        public Guid Id { get; set; }
        public bool veteranOfArmedForces { get; set; }
        public bool hasServiceConnectedDisablility { get; set; }
        public bool dischargedWithinPastYear { get; set; }
        public bool unemployedLessThan6Months { get; set; }
        public bool unemployedForAtLeast6Months { get; set; }
        public VeteranFoodStamps veteranFoodStamps { get; set; }
    }
}
