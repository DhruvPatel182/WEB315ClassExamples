using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarvelHeros.Models;

namespace MarvelHeros.Pages_Heros
{
    public class CreateModel : PageModel
    {
        private readonly MarvelHerosHeroContext _context;

        public CreateModel(MarvelHerosHeroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hero Hero { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hero.Add(Hero);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
