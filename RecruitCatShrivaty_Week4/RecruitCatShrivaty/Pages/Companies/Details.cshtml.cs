using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShrivaty.Data;
using RecruitCatShrivaty.Pages.Models;

namespace RecruitCatShrivaty.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShrivaty.Data.RecruitCatShrivatyContext _context;

        public DetailsModel(RecruitCatShrivaty.Data.RecruitCatShrivatyContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.Candidates).FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
