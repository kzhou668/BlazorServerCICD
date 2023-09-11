using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resmed.MSP.LSR.UI.Models;

namespace Resmed.MSP.LSR.UI.Pages.DowntimeForms
{
    public class EditModel : PageModel
    {
        private readonly Resmed.MSP.LSR.UI.Models.AppDbContext _context;

        public EditModel(Resmed.MSP.LSR.UI.Models.AppDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DowntimeForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DowntimeFormExists(DowntimeForm.AutoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DowntimeFormExists(long id)
        {
            return _context.DowntimeForms.Any(e => e.AutoId == id);
        }
    }
}
