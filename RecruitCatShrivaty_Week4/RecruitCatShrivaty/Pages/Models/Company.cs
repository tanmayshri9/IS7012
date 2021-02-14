using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatShrivaty.Pages.Models
{
    public class Company
    {
       
            public int CompanyId { get; set; }
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a valid Company Name")]
        [Required(ErrorMessage = "Company Name is required")]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a valid Company Position")]
        [Required(ErrorMessage = "Company Position is required")]
        [DisplayName("Company Position")]
        public string CompanyPosition { get; set; }
        
        [DisplayName("Minimum Salary")]
        [Range(1000, 1000000)]
        public string MinimumSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(1000, 1000000)]
        public string MaximumSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }
            public string Location { get; set; }
        [DisplayName("Company Type")]

        public string CompanyType { get; set; }
            public List<Candidate> Candidates { get; set; }
            public Industry Industry { get; set; }
            public int IndustryId { get; set; }

        }

    }

