using BookWebApp.Data;
using BookWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages.Categories;

//[BindProperties]
public class CreateModel : PageModel
{
    private readonly BookDbContext _db;

    //[BindProperty]
    public Book Book { get; set; }

    public CreateModel(BookDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostCreate(Book book)
    {
        await _db.Books.AddAsync(book);
        await _db.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}

