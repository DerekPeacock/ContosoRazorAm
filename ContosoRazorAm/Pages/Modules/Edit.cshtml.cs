using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoRazorAm.Data;
using ContosoRazorAm.Models;

namespace ContosoRazorAm.Pages.Modules
{
    public class EditModel : PageModel
    {
        private readonly ContosoRazorAm.Data.ApplicationDbContext _context;

        public EditModel(ContosoRazorAm.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Module Module { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var module =  await _context.Modules.FirstOrDefaultAsync(m => m.ID == id);
            if (module == null)
            {
                return NotFound();
            }
            Module = module;
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

            _context.Attach(Module).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(Module.ID))
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

        private bool ModuleExists(int id)
        {
          return _context.Modules.Any(e => e.ID == id);
        }
    }
}
