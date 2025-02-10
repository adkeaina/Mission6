using System.ComponentModel.DataAnnotations;

namespace Mission6.Models;

public class Movie
{ 
    [Key]
    public int MovieId { get; set; }
    
    [Required]
    public string Category { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    [Required]
    public string Year { get; set; } // string because you can input e.g. "2023-2024"
    
    [Required]
    public string Director { get; set; }
    
    [Required]
    public string Rating { get; set; }
    
    public bool? Edited { get; set; }
    
    public string? LentTo { get; set; }
    
    [MaxLength(25)]
    public string? Notes { get; set; }
}