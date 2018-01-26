using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class RootObject
    {
        [Key]
        public Guid Id { get; set; }
        public List<Screening> screenings { get; set; }
    }
}
