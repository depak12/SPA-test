using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Applicant
    {

        [Key]
        public Guid Id { get; set; }
        public string ApplicantId { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string socialSecurityNumber { get; set; }
            public string DateOfBirth { get; set; }
            public string StreetAddress { get; set; }
           public string city { get; set; }
            public string State { get; set; }
            public int? ZipCode { get; set; }
           public string county { get; set; }
           public string phoneNumber { get; set; }
        
    }
}
