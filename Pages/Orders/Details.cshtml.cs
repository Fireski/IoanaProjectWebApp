using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IoanaProjectWebApp.Data;
using IoanaProjectWebApp.Models;

namespace IoanaProjectWebApp.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly IoanaProjectWebApp.Data.IoanaProjectWebAppContext _context;

        public DetailsModel(IoanaProjectWebApp.Data.IoanaProjectWebAppContext context)
        {
            _context = context;
        }

        public Monitorizare Orders { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FirstOrDefaultAsync(m => m.ID == id);
            if (orders == null)
            {
                return NotFound();
            }
            else
            {
                Orders = orders;
            }
            return Page();
        }
    }
}
