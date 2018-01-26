using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WOTCStateSubmission
{
    public partial class Employer
    {
        [Key]
        public Guid Id { get; set; }
        public string EmployerId { get; set; }
        public string LocationId { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string Ein { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
        public string Email { get; set; }
    }
}
