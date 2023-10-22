using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Carabiber_Diana_la2.Data;
using Carabiber_Diana_la2.Models;

namespace Carabiber_Diana_la2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Carabiber_Diana_la2.Data.Carabiber_Diana_la2Context _context;

        public DetailsModel(Carabiber_Diana_la2.Data.Carabiber_Diana_la2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
