using BookWebApp.Data;
using BookWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookWebApp.Pages.Books;

public class DeleteModel : PageModel
{
    private readonly BookDbContext _db;

    [BindProperty]
    public Book Book { get; set; }

    public DeleteModel(BookDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Book = _db.Books.Find(id);
    }

    public IActionResult OnPost()
    {
        var bookById = _db.Books.Find(Book.Id);

        try
        {
            _db.Books.Remove(bookById);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
        catch (Exception ex)
        {
            return RedirectToPage("Index");
        }


    }
}
