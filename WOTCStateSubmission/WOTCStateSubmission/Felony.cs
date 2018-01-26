using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Felony
    {
        [Key]
        public Guid Id { get; set; }
        public bool hasFelonyConviction { get; set; }
        public string convictionDate { get; set; }
        public string releaseDate { get; set; }
        public bool federalConviction { get; set; }
    }
}
