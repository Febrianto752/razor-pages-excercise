using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWebApp.Models;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    public string Description { get; set; }

    [DefaultValue(0)]
    public int Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateDate { get; set; }
}

