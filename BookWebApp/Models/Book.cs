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
    [Range(0, 100, ErrorMessage = "Quantity must be in range of 0 to 100")]
    public int Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateDate { get; set; }
}

