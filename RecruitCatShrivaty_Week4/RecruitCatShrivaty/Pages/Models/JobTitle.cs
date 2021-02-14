using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatShrivaty.Pages.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }

        [DisplayName("Job Title")]
        public string JobTitleName { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(1000, 1000000)]
        public decimal MinimumSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(1000, 1000000)]
        public decimal MaximumSalary { get; set; }
        [DisplayName("Job Description")]
        public string JobDescription { get; set; }
        [DisplayName("Full Time")]
        public bool IsPermanent { get; set; }
        public List<Candidate> Candidates { get; set; }

    }
}
