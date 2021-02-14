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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatShrivaty.Data.RecruitCatShrivatyContext _context;

        public IndexModel(RecruitCatShrivaty.Data.RecruitCatShrivatyContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
