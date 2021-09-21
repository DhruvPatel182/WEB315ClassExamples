using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarvelHeros.Models;

    public class MarvelHerosHeroContext : DbContext
    {
        public MarvelHerosHeroContext (DbContextOptions<MarvelHerosHeroContext> options)
            : base(options)
        {
        }

        public DbSet<MarvelHeros.Models.Hero> Hero { get; set; }
    }
