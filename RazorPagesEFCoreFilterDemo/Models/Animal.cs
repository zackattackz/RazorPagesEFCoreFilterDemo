using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public abstract class Animal
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; } = null!;

    [StringLength(32)]
    public string Type { get; set; } = null!;

    [Required]
    public Sex Sex { get; set; }

    public DateTime? BirthDate { get; set; }

}
