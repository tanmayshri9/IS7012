using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShrivaty.Pages.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public string JobDescription { get; set; }
        public bool IsPermanent { get; set; }
        public List<Candidate> Candidates { get; set; }

    }
}
