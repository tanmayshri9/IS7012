using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatShrivaty.Pages.Models
{
    public class Company
    {
       
            public int CompanyId { get; set; }
            public string CompanyName { get; set; }
            public string CompanyPosition { get; set; }
            public string MinimumSalary { get; set; }
            public string MaximumSalary { get; set; }
            public DateTime OptionalStartDate { get; set; }
            public string Location { get; set; }
            public string CompanyType { get; set; }
            public List<Candidate> Candidates { get; set; }
            public Industry Industry { get; set; }
            public int IndustryId { get; set; }

        }

    }

