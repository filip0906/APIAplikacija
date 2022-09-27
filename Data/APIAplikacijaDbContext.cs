using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIAplikacija.Models;

    public class APIAplikacijaDbContext : DbContext
    {
        public APIAplikacijaDbContext (DbContextOptions<APIAplikacijaDbContext> options)
            : base(options)
        {
        }

        public DbSet<APIAplikacija.Models.SuperHero> SuperHero { get; set; } = default!;
    }
