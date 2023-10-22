using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Carabiber_Diana_la2.Data;
using Carabiber_Diana_la2.Models;

namespace Carabiber_Diana_la2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Carabiber_Diana_la2.Data.Carabiber_Diana_la2Context _context;

        public DetailsModel(Carabiber_Diana_la2.Data.Carabiber_Diana_la2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
