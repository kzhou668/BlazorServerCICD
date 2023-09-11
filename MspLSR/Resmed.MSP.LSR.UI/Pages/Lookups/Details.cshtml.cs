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
    public class DetailsModel : PageModel
    {
        private readonly Resmed.MSP.LSR.UI.Models.AppDbContext _context;

        public DetailsModel(Resmed.MSP.LSR.UI.Models.AppDbContext context)
        {
            _context = context;
        }

        public Lookup Lookup { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lookup = await _context.Lookups.FirstOrDefaultAsync(m => m.AutoId == id);

            if (Lookup == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
