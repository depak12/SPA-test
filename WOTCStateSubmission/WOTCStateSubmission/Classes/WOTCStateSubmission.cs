using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission.Classes
{
    public class WOTCStateSubmission
    {
        public class Employer
        {
            public string employerId { get; set; }
            public string locationId { get; set; }
            public string name { get; set; }
            public string telephoneNumber { get; set; }
            public string ein { get; set; }
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public int zipCode { get; set; }
        }

        public class Applicant
        {
            public string applicantId { get; set; }
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string socialSecurityNumber { get; set; }
            public string dateOfBirth { get; set; }
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public int zipCode { get; set; }
            public string county { get; set; }
            public string phoneNumber { get; set; }
        }

        public class ConditionalCertification
        {
            public bool receivedConditionalCertification { get; set; }
        }

        public class FoodStamps
        {
            public bool receivedFoodStamps { get; set; }
            public string recipientName { get; set; }
            public string cityReceived { get; set; }
            public string stateReceived { get; set; }
        }

        public class Welfare
        {
            public bool receivedWelfare { get; set; }
            public string recipientName { get; set; }
            public string cityReceived { get; set; }
            public string stateReceived { get; set; }
            public bool receivedBenefitsPast18Months { get; set; }
            public bool receivedBenefitsAtLeast9Months { get; set; }
            public bool receivedBenefits18MonthsWithinPast2Years { get; set; }
            public bool maximizedBenefitsWithinPastTwoYears { get; set; }
        }

        public class VocationalRehabilitation
        {
            public bool completedVocationalRehabilitation { get; set; }
            public bool doneUnderTicketToWork { get; set; }
            public bool doneByDepartmentOfVeteransAffairs { get; set; }
        }

        public class VeteranFoodStamps
        {
            public bool receivedFoodStamps { get; set; }
            public string recipientName { get; set; }
            public string cityReceived { get; set; }
            public string stateReceived { get; set; }
        }

        public class Veteran
        {
            public bool veteranOfArmedForces { get; set; }
            public bool hasServiceConnectedDisablility { get; set; }
            public bool dischargedWithinPastYear { get; set; }
            public bool unemployedLessThan6Months { get; set; }
            public bool unemployedForAtLeast6Months { get; set; }
            public VeteranFoodStamps veteranFoodStamps { get; set; }
        }

        public class Ssi
        {
            public bool receivedDisabilityPayments { get; set; }
        }

        public class Felony
        {
            public bool hasFelonyConviction { get; set; }
            public string convictionDate { get; set; }
            public string releaseDate { get; set; }
            public bool federalConviction { get; set; }
        }

        public class LongTermUnemployed
        {
            public bool unemployed6Months { get; set; }
            public bool receivedUnemploymentCompensation { get; set; }
            public string stateReceived { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
        }

        public class Document
        {
            public string id { get; set; }
            public string name { get; set; }
            public string href { get; set; }
            public bool signatureRequired { get; set; }
            public string signedName { get; set; }
            public string signedIpAddress { get; set; }
            public string signedDate { get; set; }
        }

        public class Screening
        {
            public string screeningId { get; set; }
            public Employer employer { get; set; }
            public Applicant applicant { get; set; }
            public ConditionalCertification conditionalCertification { get; set; }
            public FoodStamps foodStamps { get; set; }
            public Welfare welfare { get; set; }
            public VocationalRehabilitation vocationalRehabilitation { get; set; }
            public Veteran veteran { get; set; }
            public Ssi ssi { get; set; }
            public Felony felony { get; set; }
            public LongTermUnemployed longTermUnemployed { get; set; }
            public List<Document> documents { get; set; }
            public string gaveInformation { get; set; }
            public string offeredJob { get; set; }
            public string WasHired { get; set; }
            public string startedJob { get; set; }
            public string position { get; set; }
            public int startingWage { get; set; }
        }

        public class RootObject
        {
            public List<Screening> screenings { get; set; }
        }

    }
}
