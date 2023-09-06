using BookWebApp.Data;
using BookWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages.Books;

//[BindProperties]
public class CreateModel : PageModel
{
    private readonly BookDbContext _db;

    [BindProperty]
    public Book Book { get; set; }

    public CreateModel(BookDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPost()
    {
        if (Book.Title == Book.Description)
        {
            ModelState.AddModelError("other", "title and description book cannot be the same");
        }
        if (ModelState.IsValid)
        {
            await _db.Books.AddAsync(Book);
            await _db.SaveChangesAsync();
            TempData["success"] = "Successfully created book";
            return RedirectToPage("Index");
        }

        return Page();
    }
}

