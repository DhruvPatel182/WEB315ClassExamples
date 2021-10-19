using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            //_context
        }

        public IList<Hero> Hero { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CountriesOfOrigin { get; set; }
        [BindProperty(SupportsGet = true)]
        public string HeroCountryOfOrigin { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> countryOfOriginQuery = from m in _context.Hero
                                    orderby m.CountryOfOrigin
                                    select m.CountryOfOrigin;

            // Hero = await _context.Hero.ToListAsync();
            var heroes = from h in _context.Hero
                 select h;
            if (!string.IsNullOrEmpty(SearchString))
            {
                heroes = heroes.Where(h => h.Name == SearchString);
            }

            if (!string.IsNullOrEmpty(HeroCountryOfOrigin))
            {
                heroes = heroes.Where(x => x.CountryOfOrigin == HeroCountryOfOrigin);
            }
            CountriesOfOrigin = new SelectList(await countryOfOriginQuery.Distinct().ToListAsync());

            Hero = await heroes.ToListAsync();
        }
    }
}
