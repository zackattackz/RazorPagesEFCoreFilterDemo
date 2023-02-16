using System.ComponentModel.DataAnnotations;

namespace RazorPagesEFCoreFilterDemo.Models;

public class Primate : Mammal
{
    [Range(0, int.MaxValue)]
    public int? GameHighScore { get; set; }

    public int PrimateTypeId { get; set; }

    [Required]
    public PrimateType PrimateType { get; set; } = default!;
}
