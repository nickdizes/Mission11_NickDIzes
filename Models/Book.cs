using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission11_NickDizes.Models;

public partial class Book
{
    [Key]
    public int BookId { get; set; }
    
    [Required(ErrorMessage="Title field is required")]
    public string Title { get; set; }

    [Required(ErrorMessage="Author field is required")]
    public string Author { get; set; }

    [Required(ErrorMessage="Publisher field is required")]
    public string Publisher { get; set; }

    [Required(ErrorMessage="Isbn field is required")]
    public string Isbn { get; set; }

    [Required(ErrorMessage="Classification field is required")]
    public string Classification { get; set; } 

    [Required(ErrorMessage="Category field is required")]
    public string Category { get; set; } 

    [Required(ErrorMessage="Page Count field is required.")]
    public int PageCount { get; set; }

    [Required(ErrorMessage="Price field is required")]
    public double Price { get; set; }
}
