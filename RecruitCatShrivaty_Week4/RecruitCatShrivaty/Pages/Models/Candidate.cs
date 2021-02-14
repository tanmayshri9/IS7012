using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatShrivaty.Pages.Models
{
    public class Candidate
    {
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }
        [DisplayName("First Name")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a valid Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a valid Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [RegularExpression("^\\d{3}-?\\d{2}-?\\d{4}$", ErrorMessage = "Please enter a valid Name")]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "Please enter a valid SSN")]
        [Required(ErrorMessage = "SSN is required")]
        [DisplayName("Social Security Number")]
        public string SSN { get; set; }

        [DisplayName("Target Salary")]
        [Range(1000,1000000)]
        public decimal TargetSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? OptionalStartDate { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        public Company Company { get; set; }
       
        public int CompanyId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        public int JobId { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
       
        public int IndustryId { get; set; }
        [DisplayName("Credit Score")]
        public int CreditScore { get; set; }

    }
}
