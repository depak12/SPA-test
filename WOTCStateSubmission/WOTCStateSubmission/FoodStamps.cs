using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission
{
    public partial class FoodStamps
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedFoodStamps { get; set; }
        public string recipientName { get; set; }
        public string cityReceived { get; set; }
        public string stateReceived { get; set; }
    }
}
