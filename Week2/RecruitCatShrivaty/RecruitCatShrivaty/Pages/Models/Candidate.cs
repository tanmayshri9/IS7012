using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShrivaty.Pages.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public datetime? OptionalStartDate { get; set; }
        public datetime DateOfBirth { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle Job { get; set; }
        public int JobId { get; set; }
        public Industry Industry { get; set; }
        public int CreditScore { get; set; }
        public int IndustryId { get; set; }

    }
}
