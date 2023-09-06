using BookWebApp.Data;
using BookWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages.Books;

public class IndexModel : PageModel
{
    private readonly BookDbContext _db;
    public IEnumerable<Book> Books { get; set; }

    public IndexModel(BookDbContext db)
    {
        _db = db;
    }
    public void OnGet([FromQuery] string? title)
    {
        Console.WriteLine($"title : {title}");
        Books = _db.Books;
    }
}

