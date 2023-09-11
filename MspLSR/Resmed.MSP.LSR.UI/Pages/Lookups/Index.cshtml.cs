using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resmed.MSP.LSR.UI.Models;

namespace Resmed.MSP.LSR.UI.Pages.Lookups
{
    public class IndexModel : PageModel
    {
        private readonly Resmed.MSP.LSR.UI.Models.AppDbContext _context;

        public IndexModel(Resmed.MSP.LSR.UI.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Lookup> Lookup { get;set; }

        public async Task OnGetAsync()
        {
            Lookup = await _context.Lookups.ToListAsync();
        }
    }
}
