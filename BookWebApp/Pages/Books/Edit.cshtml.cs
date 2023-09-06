using BookWebApp.Data;
using BookWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages.Books;

public class EditModel : PageModel
{
    private readonly BookDbContext _db;

    [BindProperty]
    public Book Book { get; set; }

    public EditModel(BookDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Book = _db.Books.Find(id);
    }

    public IActionResult OnPost()
    {
        if (Book.Title == Book.Description)
        {
            ModelState.AddModelError(string.Empty, "title and description book cannot be the same");
        }
        if (ModelState.IsValid)
        {
            _db.Books.Update(Book);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }

        return Page();
    }
}

