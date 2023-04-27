using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models;
[DisplayColumn("Category")]
public class Category
{
    [Key] 
    public int Id { get; set; }

    [Display(Name = "Title")]
    [Required]
    public string? Name { get; set; }

    public List<Article>? Articles { get; set; }
}