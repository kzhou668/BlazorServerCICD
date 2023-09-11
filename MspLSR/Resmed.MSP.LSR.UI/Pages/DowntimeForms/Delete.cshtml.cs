using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resmed.MSP.LSR.UI.Models;

namespace Resmed.MSP.LSR.UI.Pages.DowntimeForms
{
    public class DeleteModel : PageModel
    {
        private readonly Resmed.MSP.LSR.UI.Models.AppDbContext _context;

        public DeleteModel(Resmed.MSP.LSR.UI.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DowntimeForm DowntimeForm { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DowntimeForm = await _context.DowntimeForms.FirstOrDefaultAsync(m => m.AutoId == id);

            if (DowntimeForm == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DowntimeForm = await _context.DowntimeForms.FindAsync(id);

            if (DowntimeForm != null)
            {
                _context.DowntimeForms.Remove(DowntimeForm);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
