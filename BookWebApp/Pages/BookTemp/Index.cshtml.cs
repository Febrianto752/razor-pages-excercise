using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookWebApp.Data;
using BookWebApp.Models;

namespace BookWebApp.Pages.BookTemp
{
    public class IndexModel : PageModel
    {
        private readonly BookWebApp.Data.BookDbContext _context;

        public IndexModel(BookWebApp.Data.BookDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Book = await _context.Books.ToListAsync();
            }
        }
    }
}
