using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoRazorAm.Data;
using ContosoRazorAm.Models;

namespace ContosoRazorAm.Pages.Modules
{
    public class CreateModel : PageModel
    {
        private readonly ContosoRazorAm.Data.ApplicationDbContext _context;

        public CreateModel(ContosoRazorAm.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Module Module { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Modules.Add(Module);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
