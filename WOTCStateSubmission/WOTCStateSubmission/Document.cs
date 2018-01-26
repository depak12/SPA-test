using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class Document
    {
       
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string href { get; set; }
        public bool signatureRequired { get; set; }
        public string signedName { get; set; }
        public string signedIpAddress { get; set; }
        public string signedDate { get; set; }
    }
}
