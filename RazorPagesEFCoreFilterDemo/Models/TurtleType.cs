using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public class TurtleType
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; } = null!;
}
