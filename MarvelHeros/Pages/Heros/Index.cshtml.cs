using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarvelHeros.Models;

namespace MarvelHeros.Pages_Heros
{
    public class IndexModel : PageModel
    {
        private readonly MarvelHerosHeroContext _context;

        public IndexModel(MarvelHerosHeroContext context)
        {
            _context = context;
        }

        public IList<Hero> Hero { get;set; }

        public async Task OnGetAsync()
        {
            Hero = await _context.Hero.ToListAsync();
        }
    }
}
