using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatShrivaty.Pages.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        [DisplayName("Industry Name")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a valid Industry Name")]
        [Required(ErrorMessage = "Industry Name is required")]
        public string IndustryName { get; set; }
        [DisplayName("Industry Type")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Please enter a valid Industry Type")]
        [Required(ErrorMessage = "Industry Type is required")]
        public string IndustryType { get; set; }
        [DisplayName("Government")]
        public bool IsGovernment { get; set; }

        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }

    }
}
