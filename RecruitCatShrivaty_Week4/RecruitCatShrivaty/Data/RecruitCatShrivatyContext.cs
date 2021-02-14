using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatShrivaty.Pages.Models;

namespace RecruitCatShrivaty.Data
{
    public class RecruitCatShrivatyContext : DbContext
    {
        public RecruitCatShrivatyContext (DbContextOptions<RecruitCatShrivatyContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatShrivaty.Pages.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatShrivaty.Pages.Models.Company> Company { get; set; }

        public DbSet<RecruitCatShrivaty.Pages.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatShrivaty.Pages.Models.JobTitle> JobTitle { get; set; }
    }
}
