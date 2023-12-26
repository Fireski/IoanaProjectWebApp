using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IoanaProjectWebApp.Data;
using IoanaProjectWebApp.Models;

namespace IoanaProjectWebApp.Pages.AngajatiFirma
{
    public class DeleteModel : PageModel
    {
        private readonly IoanaProjectWebApp.Data.IoanaProjectWebAppContext _context;

        public DeleteModel(IoanaProjectWebApp.Data.IoanaProjectWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Angajati Angajati { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajati = await _context.Angajati.FirstOrDefaultAsync(m => m.ID == id);

            if (angajati == null)
            {
                return NotFound();
            }
            else
            {
                Angajati = angajati;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajati = await _context.Angajati.FindAsync(id);
            if (angajati != null)
            {
                Angajati = angajati;
                _context.Angajati.Remove(Angajati);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
