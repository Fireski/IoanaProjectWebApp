using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IoanaProjectWebApp.Models;

namespace IoanaProjectWebApp.Data
{
    public class IoanaProjectWebAppContext : DbContext
    {
        public IoanaProjectWebAppContext (DbContextOptions<IoanaProjectWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<IoanaProjectWebApp.Models.Monitorizare> Orders { get; set; } = default!;
        public DbSet<IoanaProjectWebApp.Models.Angajati> Angajati { get; set; } = default!;
    }
}
