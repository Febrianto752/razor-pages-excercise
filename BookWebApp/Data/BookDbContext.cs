using BookWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWebApp.Data;

public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
}

