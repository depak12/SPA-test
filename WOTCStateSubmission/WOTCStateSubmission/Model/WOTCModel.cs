using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WOTCStateSubmission.Model
{
    public class WOTCModel
    {

        public string ScreeningId { get; set; }
        public Employer Employer { get; set; }
        public Applicant Applicant { get; set; }

        public ConditionalCertification ConditionalCertification { get; set; }
        public FoodStamps FoodStamps { get; set; }
        public Welfare Welfare { get; set; }

        public VocationalRehabilitation VocationalRehabilitation { get; set; }

        public Veteran Veteran { get; set; }

        public Ssi Ssi { get; set; }
        public Felony Felony { get; set; }

        public LongTermUnemployed LongTermUnemployed { get; set; }

        public List<Document> Documents { get; set; }

        public string GaveInformation  { get; set; }

        public string OfferedJob { get; set; }

        public string WasHired { get; set; }

        public string StartedJob { get; set; }

        public string Position { get; set; }

        public string StartingWage { get; set; }

    }




    public partial class Employer
    {
       [Key]
        public Guid id { get; set; }
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

    public partial class Applicant
    {
        [Key]
        public Guid Id { get; set; }
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

    public partial class ConditionalCertification
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedConditionalCertification { get; set; }
    }

    public partial class FoodStamps
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedFoodStamps { get; set; }
        public string recipientName { get; set; }
        public string cityReceived { get; set; }
        public string stateReceived { get; set; }
    }

    public partial class Welfare
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedWelfare { get; set; }
        public string recipientName { get; set; }
        public string cityReceived { get; set; }
        public string stateReceived { get; set; }
        public bool receivedBenefitsPast18Months { get; set; }
        public bool receivedBenefitsAtLeast9Months { get; set; }
        public bool receivedBenefits18MonthsWithinPast2Years { get; set; }
        public bool maximizedBenefitsWithinPastTwoYears { get; set; }
    }

    public partial class VocationalRehabilitation
    {
        [Key]
        public Guid Id { get; set; }
        public bool completedVocationalRehabilitation { get; set; }
        public bool doneUnderTicketToWork { get; set; }
        public bool doneByDepartmentOfVeteransAffairs { get; set; }
    }

    public partial class VeteranFoodStamps
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedFoodStamps { get; set; }
        public string recipientName { get; set; }
        public string cityReceived { get; set; }
        public string stateReceived { get; set; }
    }

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

    public partial class Ssi
    {
        [Key]
        public Guid Id { get; set; }
        public bool receivedDisabilityPayments { get; set; }
    }

    public partial class Felony
    {
        [Key]
        public Guid Id { get; set; }
        public bool hasFelonyConviction { get; set; }
        public string convictionDate { get; set; }
        public string releaseDate { get; set; }
        public bool federalConviction { get; set; }
    }

    public partial class LongTermUnemployed
    {
        [Key]
        public Guid Id { get; set; }
        public bool unemployed6Months { get; set; }
        public bool receivedUnemploymentCompensation { get; set; }
        public string stateReceived { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }

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

    public partial class Screening
    {
        [Key]
        public Guid Id { get; set; }
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

    public partial class RootObject
    {
        [Key]
        public Guid Id { get; set; }
        public List<Screening> screenings { get; set; }
    }

    public partial class Response
    {
           public string batchId { get; set; }
           public string status { get; set; }
  

        
    }

}