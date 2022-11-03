using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoRazorAm.Data;
using ContosoRazorAm.Models;

namespace ContosoRazorAm.Pages.Modules
{
    public class IndexModel : PageModel
    {
        private readonly ContosoRazorAm.Data.ApplicationDbContext _context;

        public IndexModel(ContosoRazorAm.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Module> Module { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Modules != null)
            {
                Module = await _context.Modules.ToListAsync();
            }
        }
    }
}
