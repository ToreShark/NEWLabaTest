using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models;
[DisplayColumn("News")]
public class Article
{
    [Key] 
    public int Id { get; set; }

    [Display(Name = "Title")]
    [Required]
    public string? Name { get; set; }
    [Display(Name = "News Text")]
    public string? FullText { get; set; }

    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}