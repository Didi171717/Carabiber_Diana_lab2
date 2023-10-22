using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Carabiber_Diana_la2.Data;
using Carabiber_Diana_la2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Carabiber_Diana_la2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Carabiber_Diana_la2.Data.Carabiber_Diana_la2Context _context;

        public IndexModel(Carabiber_Diana_la2.Data.Carabiber_Diana_la2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ViewData["AuthorID"] = new SelectList(_context.Author, "ID", "FirstName","LastName");
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b=>b.Publisher).Include(b=>b.Author).ToListAsync();
            }
        }
    }
}
