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
    public class DetailsModel : PageModel
    {
        private readonly MarvelHerosHeroContext _context;

        public DetailsModel(MarvelHerosHeroContext context)
        {
            _context = context;
        }

        public Hero Hero { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("./Index");
            }

            Hero = await _context.Hero.FirstOrDefaultAsync(m => m.ID == id);

            if (Hero == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
