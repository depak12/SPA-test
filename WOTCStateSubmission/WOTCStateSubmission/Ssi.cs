﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Ssi
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedDisabilityPayments { get; set; }
    }
}
