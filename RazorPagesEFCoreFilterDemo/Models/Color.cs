using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public class Color
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(6)]
    public string Hex { get; set; } = null!;

    public ICollection<Mammal> Mammals { get; set; } = default!;
}
