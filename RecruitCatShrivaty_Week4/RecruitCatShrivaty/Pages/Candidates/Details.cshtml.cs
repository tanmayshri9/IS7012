﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShrivaty.Data;
using RecruitCatShrivaty.Pages.Models;

namespace RecruitCatShrivaty.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShrivaty.Data.RecruitCatShrivatyContext _context;

        public DetailsModel(RecruitCatShrivaty.Data.RecruitCatShrivatyContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.CandidateId == id);

            if (Candidate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
