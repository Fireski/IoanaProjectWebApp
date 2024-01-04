﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IoanaProjectWebApp.Data;
using IoanaProjectWebApp.Models;

namespace IoanaProjectWebApp.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly IoanaProjectWebApp.Data.IoanaProjectWebAppContext _context;

        public IndexModel(IoanaProjectWebApp.Data.IoanaProjectWebAppContext context)
        {
            _context = context;
        }

        public IList<Clienti> Clienti { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Clienti = await _context.Clienti.ToListAsync();
        }
    }
}