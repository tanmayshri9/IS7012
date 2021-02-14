using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShrivaty.Data;
using RecruitCatShrivaty.Pages.Models;

namespace RecruitCatShrivaty.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShrivaty.Data.RecruitCatShrivatyContext _context;

        public DetailsModel(RecruitCatShrivaty.Data.RecruitCatShrivatyContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.IndustryId == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
