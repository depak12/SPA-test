using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class VocationalRehabilitation
    {
        [Key]
        public Guid Id { get; set; }
        public bool completedVocationalRehabilitation { get; set; }
        public bool doneUnderTicketToWork { get; set; }
        public bool doneByDepartmentOfVeteransAffairs { get; set; }
    }
}

